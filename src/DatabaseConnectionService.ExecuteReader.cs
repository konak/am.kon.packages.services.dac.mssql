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
    /// Executes a SQL command asynchronously and returns an <see cref="IDataReader"/> object for reading the result set.
    /// </summary>
    /// <param name="sql">The SQL command or stored procedure to execute.</param>
    /// <param name="parameters">An array of SQL parameters to pass to the command.</param>
    /// <param name="commandType">The type of the command (e.g., Text, StoredProcedure). Default is <see cref="CommandType.Text"/>.</param>
    /// <param name="throwDBException">Specifies whether to throw database-related exceptions. Default is true.</param>
    /// <param name="throwGenericException">Specifies whether to throw generic exceptions. Default is true.</param>
    /// <param name="throwSystemException">Specifies whether to throw system-level exceptions. Default is true.</param>
    /// <returns>An <see cref="IDataReader"/> object to read the result set.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Executes a SQL command asynchronously and returns an <see cref="IDataReader"/> object for reading the result set.
    /// </summary>
    /// <param name="sql">The SQL query or stored procedure to execute.</param>
    /// <param name="parameters">An array of SQL parameters to pass to the command.</param>
    /// <param name="commandType">Indicates the type of the command to execute (e.g., Text, StoredProcedure). Default is <see cref="CommandType.Text"/>.</param>
    /// <param name="throwDBException">Specifies whether to throw database-related exceptions. Default is true.</param>
    /// <param name="throwGenericException">Specifies whether to throw generic exceptions. Default is true.</param>
    /// <param name="throwSystemException">Specifies whether to throw system-level exceptions. Default is true.</param>
    /// <returns>A task representing the asynchronous operation, containing an <see cref="IDataReader"/> object to read the result set.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Executes a SQL command asynchronously and returns an <see cref="IDataReader"/> object for reading the result set.
    /// </summary>
    /// <param name="sql">The SQL command or stored procedure to execute.</param>
    /// <param name="parameters">An array of SQL parameters to pass to the command.</param>
    /// <param name="commandType">The type of the command (e.g., Text, StoredProcedure). Default is <see cref="CommandType.Text"/>.</param>
    /// <param name="throwDBException">Specifies whether to throw database-related exceptions. Default is true.</param>
    /// <param name="throwGenericException">Specifies whether to throw generic exceptions. Default is true.</param>
    /// <param name="throwSystemException">Specifies whether to throw system-level exceptions. Default is true.</param>
    /// <returns>An <see cref="IDataReader"/> object to read the result set.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    [Obsolete("Use ExecuteReaderAsync(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true) instead",
        false)]
    public Task<IDataReader> ExecuteReaderAsync(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Executes a SQL command asynchronously and retrieves an <see cref="IDataReader"/> object for reading the result set.
    /// </summary>
    /// <param name="sql">The SQL command or stored procedure to execute.</param>
    /// <param name="parameters">An array of input parameters for the SQL command.</param>
    /// <param name="commandType">The type of the command, such as Text or StoredProcedure. Default is <see cref="CommandType.Text"/>.</param>
    /// <param name="throwDBException">Indicates whether database-related exceptions should be thrown. Default is true.</param>
    /// <param name="throwGenericException">Indicates whether generic exceptions should be thrown. Default is true.</param>
    /// <param name="throwSystemException">Indicates whether system-level exceptions should be thrown. Default is true.</param>
    /// <returns>A task representing the asynchronous operation. The task result contains an <see cref="IDataReader"/> object for reading the query results.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when an SQL execution exception occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during the operation.</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

}

