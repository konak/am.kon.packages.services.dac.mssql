using System.Data;
using System.Data.SqlClient;
using am.kon.packages.dac.primitives;
using am.kon.packages.dac.primitives.Exceptions;

namespace am.kon.packages.services.dac.mssql;

public partial class DatabaseConnectionService
{
    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, KeyValuePair<string, object>[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, List<KeyValuePair<string, object>> parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync(string sql, dynamic parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }

    /// <summary>
    /// Execute SQL command asyncronously and return <see cref="SqlDataReader"/> SqlDataReader object to read data
    /// </summary>
    /// <param name="sql">SQL command, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <returns>Data reader object to read data</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public Task<IDataReader> ExecuteReaderAsync<T>(string sql, T parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true)
    {
        return _defaultDatabase.ExecuteReaderAsync(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException);
    }
}

