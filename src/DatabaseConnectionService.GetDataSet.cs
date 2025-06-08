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
    /// Retrieves a DataSet by executing the specified SQL command or stored procedure.
    /// </summary>
    /// <param name="sql">The SQL command text, stored procedure, or table name to execute.</param>
    /// <param name="parameters">The parameters to use with the SQL command.</param>
    /// <param name="commandType">The type of SQL command to execute, such as Text or StoredProcedure.</param>
    /// <param name="throwDBException">If true, throws database-related exceptions during SQL execution.</param>
    /// <param name="throwGenericException">If true, throws generic exceptions during execution.</param>
    /// <param name="throwSystemException">If true, throws system exceptions during execution.</param>
    /// <param name="startRecord">The zero-based record number to start retrieving data from.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve.</param>
    /// <returns>A DataSet object containing the results of the SQL command execution.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown if an SQL execution-related exception occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown if the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown if a generic exception occurs.</exception>
    public DataSet GetDataSet(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0,
        int maxRecords = 0)
    {
        return GetDataSet(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Executes a SQL command or stored procedure to retrieve a DataSet.
    /// </summary>
    /// <param name="sql">The SQL command text, stored procedure, or table name to execute.</param>
    /// <param name="parameters">An array of SQL parameters to pass with the command.</param>
    /// <param name="commandType">The type of SQL command to execute, such as Text or StoredProcedure.</param>
    /// <param name="throwDBException">Specifies whether to throw exceptions related to database errors.</param>
    /// <param name="throwGenericException">Specifies whether to throw generic exceptions during execution.</param>
    /// <param name="throwSystemException">Specifies whether to throw general system exceptions during execution.</param>
    /// <param name="startRecord">The zero-based index of the starting record to retrieve.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve.</param>
    /// <returns>A DataSet containing the results of the SQL command execution.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown when a database-related error occurs during execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL command or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during execution.</exception>
    public DataSet GetDataSet(string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0,
        int maxRecords = 0)
    {
        return GetDataSet(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Retrieves a DataSet by executing the specified SQL command or stored procedure.
    /// </summary>
    /// <param name="sql">The SQL command text, stored procedure, or table name to execute.</param>
    /// <param name="parameters">The parameters to use with the SQL command.</param>
    /// <param name="commandType">The type of SQL command to execute, such as Text or StoredProcedure.</param>
    /// <param name="throwDBException">If true, throws database-related exceptions during SQL execution.</param>
    /// <param name="throwGenericException">If true, throws generic exceptions during execution.</param>
    /// <param name="throwSystemException">If true, throws system exceptions during execution.</param>
    /// <param name="startRecord">The zero-based record number to start retrieving data from.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve.</param>
    /// <returns>A DataSet object containing the results of the SQL command execution.</returns>
    /// <exception cref="DacSqlExecutionException">Thrown if an SQL execution-related exception occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown if the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown if a generic exception occurs.</exception>
    [Obsolete(
        "Use GetDataSet(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0) instead.",
        false)]
    public DataSet GetDataSet(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        return GetDataSet(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Retrieves a DataSet by executing the specified SQL command or stored procedure with the given parameters.
    /// </summary>
    /// <param name="sql">The SQL command text, stored procedure, or table name to execute.</param>
    /// <param name="parameters">The parameters to use with the SQL command.</param>
    /// <param name="commandType">The type of SQL command to execute, such as Text or StoredProcedure. Default is Text.</param>
    /// <param name="throwDBException">Indicates whether to throw database-related exceptions during SQL execution. Default is true.</param>
    /// <param name="throwGenericException">Indicates whether to throw generic exceptions during execution. Default is true.</param>
    /// <param name="throwSystemException">Indicates whether to throw system exceptions during execution. Default is true.</param>
    /// <param name="startRecord">The zero-based record number to start retrieving data from. Default is 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. Default is 0 for no limit.</param>
    /// <returns>A DataSet object containing the results of the SQL command execution.</returns>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public DataSet GetDataSet(string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0,
        int maxRecords = 0)
    {
        return GetDataSet(sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }
}

