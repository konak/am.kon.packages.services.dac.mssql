using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using am.kon.packages.dac.mssql;
using am.kon.packages.dac.primitives.Config;
using am.kon.packages.services.dac.mssql.Config;

namespace am.kon.packages.services.dac.mssql;

/// <summary>
/// Component to interact with SQL Server Database
/// </summary>
public partial class DatabaseConnectionService
{
    private readonly ILogger<DatabaseConnectionService> _logger;
    private readonly IConfiguration _configuration;

    private readonly CancellationTokenSource _cancellationTokenSource;
    private readonly CancellationToken _cancellationToken;

    private readonly SortedList<string, DataBase> _databaseConnections;
    private readonly DataBase _defaultDatabase;

    private readonly DacConfig _dacConfig;
    private readonly ConnectionStringsConfig _connectionStringsConfig;

    /// <summary>
    /// Default database connection
    /// </summary>
    public DataBase DefaultDatabase { get { return _defaultDatabase; } }

    public DatabaseConnectionService(
        ILogger<DatabaseConnectionService> logger,
        IConfiguration configuration,
        IOptions<DacConfig> dacConfigOptions,
        IOptions<ConnectionStringsConfig> connectionStringsConfigOptions
        )
    {
        _logger = logger;
        _configuration = configuration;

        _dacConfig = dacConfigOptions.Value;
        _connectionStringsConfig = connectionStringsConfigOptions.Value;

        _cancellationTokenSource = new CancellationTokenSource();
        _cancellationToken = _cancellationTokenSource.Token;

        _databaseConnections = new SortedList<string, DataBase>(_connectionStringsConfig.Count);

        foreach (KeyValuePair<string, string> record in _connectionStringsConfig)
        {
            _databaseConnections.Add(record.Key, new DataBase(record.Value, _cancellationToken));
        }

        _defaultDatabase = _databaseConnections[_dacConfig.DefaultConnection];
    }

    /// <summary>
    /// Start service
    /// </summary>
    /// <returns></returns>
    public Task Start()
    {
        return Task.CompletedTask;
    }

    /// <summary>
    /// Stop Service
    /// </summary>
    /// <returns></returns>
    public Task Stop()
    {
        _cancellationTokenSource.Cancel();

        return Task.CompletedTask;
    }

    /// <summary>
    /// Indexer to return database connection by key
    /// </summary>
    /// <param name="key">Key of the database connection to look for</param>
    /// <returns>instance of <see cref="DataBase"/></returns>
    /// <remarks>
    /// keys of databases should be configured in appsettings.json in DAC section
    /// </remarks>
    public DataBase this[string key]
    {
        get
        {
            if (_databaseConnections.TryGetValue(key, out DataBase dataBase))
                return dataBase;

            return null;
        }
    }
}

