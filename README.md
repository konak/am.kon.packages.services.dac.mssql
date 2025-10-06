# am.kon.packages.services.dac.mssql

`am.kon.packages.services.dac.mssql` wraps the raw `DataBase` from `am.kon.packages.dac.mssql` and exposes it as an injectable service that manages one or more SQL Server connections. Resolve `DatabaseConnectionService` from your DI container to run commands, stream data, or execute transactional batches against the configured databases.

## Installation

```bash
 dotnet add package am.kon.packages.services.dac.mssql
```

## Configuration

Add the DAC configuration blocks to `appsettings.json` (or equivalent):

```json
{
  "am.kon.dac": {
    "DefaultConnection": "Reporting"
  },
  "ConnectionStrings": {
    "Reporting": "Server=localhost;Database=Reporting;Trusted_Connection=True;",
    "Operational": "Server=localhost;Database=Operational;Trusted_Connection=True;"
  }
}
```

Wire everything up during service registration:

```csharp
using am.kon.packages.dac.primitives.Config;
using am.kon.packages.services.dac.mssql;
using am.kon.packages.services.dac.mssql.Config;

services.Configure<DacConfig>(configuration.GetSection(DacConfig.SectionDefaultName));
services.Configure<ConnectionStringsConfig>(configuration.GetSection(ConnectionStringsConfig.SectionDefaultName));
services.AddSingleton<DatabaseConnectionService>();
```

At runtime the service builds a `DataBase` instance for each configured connection string, keeps a `DefaultDatabase` reference, and exposes an indexer to retrieve named databases on demand.

## Working with the default database

The service forwards most operations to the default connection. Each overload mirrors the methods on `DataBase` so you can pick the parameter type that suits your calling code (`IDataParameter[]`, `SqlParameter[]`, `DacMsSqlParameters`, or the legacy `DacSqlParameters`). Examples below assume `using Microsoft.Data.SqlClient;` and `using System.Data;`.

### Executing non-query commands

```csharp
public async Task<int> SaveAuditAsync(DatabaseConnectionService connections, Guid itemId)
{
    var parameters = new DacMsSqlParameters().AddItem("@ItemId", itemId);

    return await connections.ExecuteNonQueryAsync(
        sql: "dbo.audit_append",
        parameters: parameters.ToArray(),
        commandType: CommandType.StoredProcedure);
}
```

### Fetching scalar values

```csharp
object count = await connections.ExecuteScalarAsync(
    sql: "SELECT COUNT(1) FROM Sales.Orders WHERE Status = @Status",
    parameters: new[] { new SqlParameter("@Status", OrderStatus.Pending) });
```

### Streaming results

```csharp
await using var reader = await connections.ExecuteReaderAsync(
    sql: "dbo.GetPendingOrders",
    parameters: Array.Empty<SqlParameter>(),
    commandType: CommandType.StoredProcedure);

while (await reader.ReadAsync())
{
    // hydrate DTOs here
}
```

### Filling existing containers

```csharp
var buffer = new DataTable();
connections.FillData(
    dataOut: buffer,
    sql: "SELECT * FROM Reports.MonthlySummary",
    parameters: Array.Empty<SqlParameter>(),
    startRecord: 0,
    maxRecords: 100);
```

`FillDataSet`, `FillDataTable`, `GetDataSet`, and `GetDataTable` follow the same pattern as the underlying `DataBase` type—use them when you prefer to materialise tabular structures directly.

## Transactional and batch operations

`DatabaseConnectionService` exposes the underlying `DefaultDatabase` so you can opt into the batch helpers when required:

```csharp
var database = connections.DefaultDatabase;

await database.ExecuteTransactionalSQLBatchAsync(async transaction =>
{
    var conn = (SqlConnection)transaction.Connection;
    var tx = (SqlTransaction)transaction;

    using var updateInventory = new SqlCommand("dbo.UpdateInventory", conn, tx)
    {
        CommandType = CommandType.StoredProcedure
    };
    updateInventory.Parameters.AddWithValue("@Sku", sku);
    updateInventory.Parameters.AddWithValue("@Delta", -quantity);
    await updateInventory.ExecuteNonQueryAsync();

    using var log = new SqlCommand("dbo.LogFulfilment", conn, tx)
    {
        CommandType = CommandType.StoredProcedure
    };
    log.Parameters.AddWithValue("@Sku", sku);
    log.Parameters.AddWithValue("@Quantity", quantity);
    await log.ExecuteNonQueryAsync();

    return true;
});
```

For non-transactional batches, call `ExecuteSQLBatchAsync` in the same manner. Both helpers support the familiar `throwDBException`, `throwGenericException`, and `throwSystemException` switches.

## Deriving custom services

When you need to expose domain-specific helpers while keeping DI registration simple, derive from `DatabaseConnectionService` and add strongly typed methods that leverage the protected members and the `DefaultDatabase` property.

```csharp
public sealed class ReportingConnectionService : DatabaseConnectionService
{
    public ReportingConnectionService(
        ILogger<DatabaseConnectionService> logger,
        IConfiguration configuration,
        IOptions<DacConfig> dacConfig,
        IOptions<ConnectionStringsConfig> connectionOptions)
        : base(logger, configuration, dacConfig, connectionOptions) { }

    public Task<DataSet> LoadHeadcountAsync(DateOnly asOf)
    {
        var parameters = new DacMsSqlParameters()
            .AddItem("@AsOf", asOf);

        return DefaultDatabase.GetDataSet(
            sql: "dbo.HR_GetHeadcount",
            parameters: parameters.ToArray(),
            commandType: CommandType.StoredProcedure);
    }

    public Task<int> AppendAuditAsync(Guid itemId)
    {
        var parameters = new DacMsSqlParameters()
            .AddItem("@ItemId", itemId);

        return ExecuteNonQueryAsync(
            sql: "dbo.audit_append",
            parameters: parameters.ToArray(),
            commandType: CommandType.StoredProcedure);
    }
}
```

Register the derived class in DI (`services.AddSingleton<ReportingConnectionService>()`) alongside or instead of the base service, depending on your needs.

## Managing multiple databases

```csharp
var reporting = connections.DefaultDatabase;
var operational = connections["Operational"];

DataSet latest = reporting.GetDataSet(
    sql: "dbo.GetLatestMetrics",
    parameters: Array.Empty<SqlParameter>(),
    commandType: CommandType.StoredProcedure);

DataTable syncStatus = operational.GetDataTable(
    sql: "SELECT * FROM SyncStatus",
    parameters: Array.Empty<SqlParameter>());
```

The indexer returns `null` when a key is missing; handle that scenario if consumers provide user input.

## Lifecycle hooks

- `Start()` currently returns a completed task and is available for symmetry with hosted services.
- `Stop()` cancels the shared `CancellationTokenSource`, signalling any in-flight operations to exit.

Call `Stop()` during application shutdown or implement `IHostedService` to delegate to these methods automatically.

For lower-level usage without dependency injection, use [`am.kon.packages.dac.mssql`](../am.kon.packages.dac.mssql/README.md) directly.
