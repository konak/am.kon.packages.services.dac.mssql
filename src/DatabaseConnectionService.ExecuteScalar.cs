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
    /// Execute SQL command and return the value of the first column of the first row from results.
    /// </summary>
    /// <param name="sql">SQL command text to be executed.</param>
    /// <param name="parameters">Parameters of the SQL command.</param>
    /// <param name="commandType">SQL command type to be executed.</param>
    /// <returns>Value of the first column of the first row from results.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when a SqlException occurs during execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during execution.</exception>
    public Task<object> ExecuteScalarAsync(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
    }

    /// <summary>
    /// Executes a SQL command and retrieves the value of the first column of the first row from the result set.
    /// </summary>
    /// <param name="sql">The SQL command text to be executed.</param>
    /// <param name="parameters">An array of SqlParameter objects representing the parameters to be passed with the SQL command.</param>
    /// <param name="commandType">Specifies how the SQL command is interpreted (e.g., Text, StoredProcedure, or TableDirect). The default is CommandType.Text.</param>
    /// <returns>An object representing the value of the first column of the first row from the result set.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when a SQL exception occurs during execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero code.</exception>
    /// <exception cref="DacGenericException">Thrown if a general exception occurs during execution.</exception>
    public Task<object> ExecuteScalarAsync(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
    }

    /// <summary>
    /// Execute SQL command and return the value of the first column of the first row from results.
    /// </summary>
    /// <param name="sql">SQL command text to be executed.</param>
    /// <param name="parameters">Parameters of the SQL command.</param>
    /// <param name="commandType">SQL command type to be executed.</param>
    /// <returns>Value of the first column of the first row from results.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when a SqlException occurs during execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during execution.</exception>
    [Obsolete("Use ExecuteScalarAsync(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text) instead.", false)]
    public Task<object> ExecuteScalarAsync(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
    }

    /// <summary>
    /// Executes a SQL command and retrieves the value of the first column of the first row from the query result asynchronously.
    /// </summary>
    /// <param name="sql">The SQL command text to execute.</param>
    /// <param name="parameters">The parameters for the SQL command.</param>
    /// <param name="commandType">The type of the SQL command to be executed.</param>
    /// <returns>The value of the first column of the first row from the query result.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when a SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query returns a non-zero result code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic error occurs during SQL execution.</exception>
    public Task<object> ExecuteScalarAsync(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text)
    {
        return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
    }

}

