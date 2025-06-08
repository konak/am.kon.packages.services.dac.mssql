using System.Data;
using am.kon.packages.dac.mssql;
using am.kon.packages.dac.primitives;
using am.kon.packages.dac.primitives.Exceptions;
using Microsoft.Data.SqlClient;

namespace am.kon.packages.services.dac.mssql;

public partial class DatabaseConnectionService
{
    /// <summary>
    /// Retrieves a new DataTable based on the specified SQL command and parameters.
    /// </summary>
    /// <param name="sql">The SQL command text to be executed.</param>
    /// <param name="parameters">The parameters to be used in the SQL command.</param>
    /// <param name="commandType">Specifies how the SQL command should be interpreted (e.g., Text, StoredProcedure).</param>
    /// <param name="throwDBException">Determines whether SQL execution exceptions should be thrown or suppressed.</param>
    /// <param name="throwGenericException">Determines whether generic exceptions should be thrown or suppressed.</param>
    /// <param name="throwSystemException">Determines whether system exceptions should be thrown or suppressed.</param>
    /// <param name="startRecord">The zero-based record number to start retrieving from.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve.</param>
    /// <returns>A new DataTable containing the results of the SQL command.</returns>
    public DataTable GetDataTable(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0,
        int maxRecords = 0)
    {
        return _defaultDatabase.GetDataTable(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Retrieves a DataTable based on the specified SQL command and parameters.
    /// </summary>
    /// <param name="sql">The SQL query or command to be executed.</param>
    /// <param name="parameters">An array of SQL parameters to be used in the command.</param>
    /// <param name="commandType">Specifies how the SQL command should be interpreted (e.g., Text or StoredProcedure).</param>
    /// <param name="throwDBException">Indicates whether to throw exceptions related to database operations.</param>
    /// <param name="throwGenericException">Indicates whether to throw generic exceptions during execution.</param>
    /// <param name="throwSystemException">Indicates whether to throw system-level exceptions during execution.</param>
    /// <param name="startRecord">The zero-based index of the first record to retrieve.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve.</param>
    /// <returns>A DataTable containing the results of the executed query or command.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public DataTable GetDataTable(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0,
        int maxRecords = 0)
    {
        return _defaultDatabase.GetDataTable(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Retrieves a DataTable containing results from the executed SQL command.
    /// </summary>
    /// <param name="sql">The SQL command text to be executed.</param>
    /// <param name="parameters">The parameters to be used in the SQL command.</param>
    /// <param name="commandType">Indicates how the SQL command should be interpreted (e.g., Text or StoredProcedure).</param>
    /// <param name="throwDBException">Determines whether exceptions related to database operations should be thrown.</param>
    /// <param name="throwGenericException">Determines whether non-database exceptions should be thrown.</param>
    /// <param name="throwSystemException">Determines whether system-level exceptions should be thrown.</param>
    /// <param name="startRecord">The zero-based index of the first record to retrieve.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. Use 0 to retrieve all.</param>
    /// <returns>A DataTable containing the results of the SQL command execution.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    [Obsolete(
        "Use GetDataTable(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0) insted.",
        false)]
    public DataTable GetDataTable(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        return _defaultDatabase.GetDataTable(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Retrieves a DataTable based on the provided SQL query and parameters.
    /// </summary>
    /// <param name="sql">The SQL query to execute.</param>
    /// <param name="parameters">The parameters to apply to the SQL query.</param>
    /// <param name="commandType">Indicates how the SQL command should be interpreted (e.g., Text, StoredProcedure).</param>
    /// <param name="throwDBException">Specifies whether exceptions related to database execution should be thrown.</param>
    /// <param name="throwGenericException">Specifies whether generic exceptions should be thrown.</param>
    /// <param name="throwSystemException">Specifies whether system-level exceptions should be thrown.</param>
    /// <param name="startRecord">The zero-based index of the starting record to retrieve.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve.</param>
    /// <returns>A DataTable containing the results of the executed SQL query.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public DataTable GetDataTable(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0,
        int maxRecords = 0)
    {
        return _defaultDatabase.GetDataTable(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

}

