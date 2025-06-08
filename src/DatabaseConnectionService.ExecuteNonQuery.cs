using System.Data;
using System.Data.SqlClient;
using am.kon.packages.dac.mssql;
using am.kon.packages.dac.primitives;
using am.kon.packages.dac.primitives.Exceptions;
using Microsoft.Data.SqlClient;

namespace am.kon.packages.services.dac.mssql;

public partial class DatabaseConnectionService
{
    /// <summary>
    /// Executes a SQL command asynchronously and returns the number of affected rows.
    /// </summary>
    /// <param name="sql">The SQL query or stored procedure to execute.</param>
    /// <param name="parameters">The collection of parameters to be used with the SQL command.</param>
    /// <param name="commandType">The type of the SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <returns>The number of affected rows.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when an SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the executed SQL command returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic error occurs during SQL execution.</exception>
    public Task<int> ExecuteNonQueryAsync(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteNonQueryAsync(sql, parameters, commandType);
    }

    /// <summary>
    /// Executes a SQL command asynchronously and returns the number of affected rows.
    /// </summary>
    /// <param name="sql">The SQL query or stored procedure to execute.</param>
    /// <param name="parameters">The array of SQL parameters to be utilized with the SQL command.</param>
    /// <param name="commandType">The type of SQL command (Text, StoredProcedure, or TableDirect). Defaults to Text.</param>
    /// <returns>A task that represents the asynchronous operation. The task result contains the number of affected rows.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when an SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the executed SQL command returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic error occurs during SQL execution.</exception>
    public Task<int> ExecuteNonQueryAsync(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteNonQueryAsync(sql, parameters, commandType);
    }

    /// <summary>
    /// Executes a SQL command asynchronously and returns the number of affected rows.
    /// </summary>
    /// <param name="sql">The SQL query or stored procedure to execute.</param>
    /// <param name="parameters">The collection of parameters to be used with the SQL command.</param>
    /// <param name="commandType">The type of the SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <returns>The number of affected rows.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when an SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the executed SQL command returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic error occurs during SQL execution.</exception>
    [Obsolete("Use ExecuteNonQueryAsync(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text) instead.", false)]
    public Task<int> ExecuteNonQueryAsync(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteNonQueryAsync(sql, parameters, commandType);
    }

    /// <summary>
    /// Executes a SQL command asynchronously and returns the number of affected rows.
    /// </summary>
    /// <param name="sql">The SQL query or stored procedure to execute.</param>
    /// <param name="parameters">The parameters to be used with the SQL command.</param>
    /// <param name="commandType">The type of the SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <returns>The number of rows affected by the executed SQL command.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when an SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the executed SQL command returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic error occurs during SQL execution.</exception>
    public Task<int> ExecuteNonQueryAsync(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteNonQueryAsync(sql, parameters, commandType);
    }

}

