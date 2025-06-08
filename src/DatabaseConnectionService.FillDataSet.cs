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
    /// Populates the specified DataSet with the results of the executed SQL command.
    /// </summary>
    /// <param name="ds">The DataSet instance to be filled with the query result data.</param>
    /// <param name="sql">The SQL query or command text to execute.</param>
    /// <param name="parameters">An array of parameters associated with the SQL query or command.</param>
    /// <param name="commandType">Specifies the type of SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <param name="throwDBException">Indicates whether database-specific exceptions should be thrown if an error occurs during execution.</param>
    /// <param name="throwGenericException">Indicates whether generic exceptions should be thrown if an error occurs during execution.</param>
    /// <param name="throwSystemException">Indicates whether system-level exceptions should be thrown if an error occurs during execution.</param>
    /// <param name="startRecord">The zero-based index of the first record to retrieve from the query results.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve from the query results.</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillDataSet(DataSet ds, string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataSet(ds, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Populates the provided DataSet with data from the specified SQL query or command.
    /// </summary>
    /// <param name="ds">The DataSet instance to be populated with the query result data.</param>
    /// <param name="sql">The SQL query or command text to execute for data retrieval.</param>
    /// <param name="parameters">An array of parameters to be used with the SQL query or command.</param>
    /// <param name="commandType">Specifies the type of the SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <param name="throwDBException">Determines whether to throw database-specific exceptions when an error occurs.</param>
    /// <param name="throwGenericException">Determines whether to throw generic exceptions when an error occurs.</param>
    /// <param name="throwSystemException">Indicates whether to throw system-level exceptions when an error occurs.</param>
    /// <param name="startRecord">The zero-based starting index of records to retrieve from the result set.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve from the result set.</param>
    /// <exception cref="DacSqlExecutionException">Thrown when a SQL-specific execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a general system or application error occurs during execution.</exception>
    public void FillDataSet(DataSet ds, string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataSet(ds, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Populates the specified DataSet with the results of the executed SQL command.
    /// </summary>
    /// <param name="ds">The DataSet instance to be populated with the query results.</param>
    /// <param name="sql">The SQL query or command text to execute.</param>
    /// <param name="parameters">An array of parameters associated with the SQL query or command.</param>
    /// <param name="commandType">Specifies the type of SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <param name="throwDBException">Indicates whether database-specific exceptions should be thrown in case of an error.</param>
    /// <param name="throwGenericException">Indicates whether generic exceptions should be thrown in case of an error.</param>
    /// <param name="throwSystemException">Indicates whether system-level exceptions should be thrown in case of an error.</param>
    /// <param name="startRecord">The zero-based index of the first record to retrieve from the query results.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve from the query results.</param>
    /// <exception cref="DacSqlExecutionException">Thrown when a SQL exception occurs during execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during execution.</exception>
    [Obsolete(
        "Use FillDataSet(DataSet ds, string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0) instead.")]
    public void FillDataSet(DataSet ds, string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataSet(ds, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Populates the specified DataSet with the results of the executed SQL command.
    /// </summary>
    /// <param name="ds">The DataSet instance to be populated with the query result data.</param>
    /// <param name="sql">The SQL query or command text to execute.</param>
    /// <param name="parameters">The collection of parameters to use with the SQL command.</param>
    /// <param name="commandType">Specifies the type of SQL command (Text, StoredProcedure, or TableDirect).</param>
    /// <param name="throwDBException">Determines whether a database-specific exception should be thrown upon an error.</param>
    /// <param name="throwGenericException">Determines whether a generic exception should be thrown upon an error.</param>
    /// <param name="throwSystemException">Determines whether a system-level exception should be thrown upon an error.</param>
    /// <param name="startRecord">The zero-based index of the first record to retrieve from the query result set.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve from the query result set.</param>
    /// <exception cref="DacSqlExecutionException">Thrown when a database-specific SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic execution error occurs.</exception>
    public void FillDataSet(DataSet ds, string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataSet(ds, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

}

