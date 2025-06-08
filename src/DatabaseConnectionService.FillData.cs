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
    /// Executes an SQL query, stored procedure, or table query and populates the provided data container with the results.
    /// </summary>
    /// <typeparam name="T">Defines the type of the data container that will be populated. Supported types include DataTable and DataSet.</typeparam>
    /// <param name="dataOut">The data container that will be populated with the results of the query.</param>
    /// <param name="sql">The SQL query, stored procedure, or table name to execute.</param>
    /// <param name="parameters">The parameters required for the SQL query or stored procedure execution.</param>
    /// <param name="commandType">Specifies the type of SQL command to execute. Default value is CommandType.Text.</param>
    /// <param name="throwDBException">Determines whether SQL execution exceptions should be thrown. Default value is true.</param>
    /// <param name="throwGenericException">Determines whether generic exceptions should be thrown. Default value is true.</param>
    /// <param name="throwSystemException">Determines whether system exceptions should be thrown. Default value is true.</param>
    /// <param name="startRecord">The starting record index for the query results. Default value is 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. Default value is 0, meaning no limit.</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SQL execution-related exception occurs during query execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if a generic exception occurs during execution.</exception>
    public void FillData<T>(T dataOut, string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Executes an SQL query, stored procedure, or table query and populates the provided data container with the results.
    /// </summary>
    /// <typeparam name="T">Defines the type of the data container that will be populated. Supported types include DataTable and DataSet.</typeparam>
    /// <param name="dataOut">The data container that will be populated with the results of the query.</param>
    /// <param name="sql">The SQL query, stored procedure, or table name to execute.</param>
    /// <param name="parameters">The parameters required for the SQL query or stored procedure execution.</param>
    /// <param name="commandType">Specifies the type of SQL command to execute. Default value is CommandType.Text.</param>
    /// <param name="throwDBException">Determines whether SQL execution exceptions should be thrown. Default value is true.</param>
    /// <param name="throwGenericException">Determines whether generic exceptions should be thrown. Default value is true.</param>
    /// <param name="throwSystemException">Determines whether system exceptions should be thrown. Default value is true.</param>
    /// <param name="startRecord">The starting record index for the query results. Default value is 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. Default value is 0, meaning no limit.</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SQL execution-related exception occurs during query execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if a generic exception occurs during execution.</exception>
    public void FillData<T>(T dataOut, string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Executes an SQL query, stored procedure, or table query and populates the provided data container with the results.
    /// </summary>
    /// <typeparam name="T">The type of the data container to be filled with the query results. Typically, DataTable or DataSet.</typeparam>
    /// <param name="dataOut">The data container that will hold the results of the query.</param>
    /// <param name="sql">The SQL query, stored procedure, or table name to execute.</param>
    /// <param name="parameters">The parameters required for the SQL query or stored procedure execution.</param>
    /// <param name="commandType">The type of SQL command to execute. Defaults to CommandType.Text.</param>
    /// <param name="throwDBException">Indicates whether SQL-specific exceptions should be thrown. Defaults to true.</param>
    /// <param name="throwGenericException">Indicates whether generic exceptions should be thrown. Defaults to true.</param>
    /// <param name="throwSystemException">Indicates whether system-level exceptions should be thrown. Defaults to true.</param>
    /// <param name="startRecord">The zero-based index of the first record to retrieve. Defaults to 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. Defaults to 0, which means no limit.</param>
    /// <exception cref="DacSqlExecutionException">Thrown if a SQL-specific execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown if the SQL query or procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown if a generic exception occurs during execution.</exception>
    [Obsolete(
        "Use FillData<T>(T dataOut, string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0) instead.",
        false)]
    public void FillData<T>(T dataOut, string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Executes a SQL query, stored procedure, or table query and populates the specified data container with the results.
    /// </summary>
    /// <typeparam name="T">The type of the data container to populate, such as DataTable or DataSet.</typeparam>
    /// <param name="dataOut">The data container that will hold the query results.</param>
    /// <param name="sql">The SQL query, stored procedure name, or table name to execute.</param>
    /// <param name="parameters">The collection of parameters required for the query or stored procedure.</param>
    /// <param name="commandType">Specifies the type of SQL command to execute. The default value is CommandType.Text.</param>
    /// <param name="throwDBException">Indicates whether to throw exceptions specific to database execution issues. The default value is true.</param>
    /// <param name="throwGenericException">Indicates whether to throw generic exceptions during execution. The default value is true.</param>
    /// <param name="throwSystemException">Indicates whether to throw system-level exceptions. The default value is true.</param>
    /// <param name="startRecord">The zero-based index of the starting record in the query results. The default value is 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. A value of 0 means no limit. The default value is 0.</param>
    /// <exception cref="DacSqlExecutionException">Thrown when there is an error during the SQL execution process.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the query or stored procedure execution returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during the operation.</exception>
    public void FillData<T>(T dataOut, string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }
}

