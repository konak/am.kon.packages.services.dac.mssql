# am.kon.packages.services.dac.mssql

`am.kon.packages.services.dac.mssql` wraps the raw `DataBase` implementation and exposes it as an injectable service that can manage multiple named SQL Server connections. Use it in ASP.NET Core or worker services when you prefer to resolve connections from the DI container.

## Installation

```bash
 dotnet add package am.kon.packages.services.dac.mssql
```

## Configuration

Add the DAC configuration sections to your `appsettings.json`:

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

Register the configuration objects and the service:

```csharp
using am.kon.packages.dac.primitives.Config;
using am.kon.packages.services.dac.mssql;
using am.kon.packages.services.dac.mssql.Config;

var services = new ServiceCollection();
services.Configure<DacConfig>(configuration.GetSection(DacConfig.SectionDefaultName));
services.Configure<ConnectionStringsConfig>(configuration.GetSection(ConnectionStringsConfig.SectionDefaultName));
services.AddSingleton<DatabaseConnectionService>();
```

## Consuming the service

```csharp
public class ReportingRepository
{
    private readonly DatabaseConnectionService _connections;

    public ReportingRepository(DatabaseConnectionService connections)
    {
        _connections = connections;
    }

    public async Task<int> AppendAuditAsync(Guid itemId)
    {
        var parameters = new DacMsSqlParameters()
            .AddItem("@ItemId", itemId);

        return await _connections.ExecuteNonQueryAsync(
            sql: "dbo.audit_append",
            parameters: parameters.ToArray(),
            commandType: CommandType.StoredProcedure);
    }
}
```

Use the indexer to opt in to secondary connections when required:

```csharp
var operationalDb = _connections["Operational"];
var table = operationalDb.GetDataTable("SELECT * FROM SyncStatus", Array.Empty<SqlParameter>());
```

Call `Stop()` during shutdown to cancel outstanding operations gracefully.
