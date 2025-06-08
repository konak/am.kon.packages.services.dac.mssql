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
    /// Populates the specified DataTable with data retrieved from the execution of a SQL command.
    /// </summary>
    /// <param name="dt">The DataTable to populate with the results of the SQL command.</param>
    /// <param name="sql">The SQL command text to execute.</param>
    /// <param name="parameters">The collection of SQL parameters to pass to the command.</param>
    /// <param name="commandType">The type of command to execute (e.g., Text, StoredProcedure). Optional, defaults to Text.</param>
    /// <param name="throwDBException">Indicates whether to throw database-specific exceptions. Optional, defaults to true.</param>
    /// <param name="throwGenericException">Indicates whether to throw generic exceptions for non-database-specific issues. Optional, defaults to true.</param>
    /// <param name="throwSystemException">Indicates whether to throw system-level exceptions during execution. Optional, defaults to true.</param>
    /// <param name="startRecord">The zero-based record number at which to start populating records. Optional, defaults to 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve and populate. Optional, defaults to 0 for no limit.</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillDataTable(DataTable dt, string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataTable(dt, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Populates the specified DataTable with data retrieved from the execution of a SQL command.
    /// </summary>
    /// <param name="dt">The DataTable to populate with the results of the SQL command.</param>
    /// <param name="sql">The SQL command text to execute.</param>
    /// <param name="parameters">The collection of SQL parameters to pass to the command.</param>
    /// <param name="commandType">The type of command to execute (e.g., Text, StoredProcedure). Optional, defaults to Text.</param>
    /// <param name="throwDBException">Indicates whether to throw database-specific exceptions. Optional, defaults to true.</param>
    /// <param name="throwGenericException">Indicates whether to throw generic exceptions for non-database-specific issues. Optional, defaults to true.</param>
    /// <param name="throwSystemException">Indicates whether to throw system-level exceptions during execution. Optional, defaults to true.</param>
    /// <param name="startRecord">The zero-based record number at which to start populating records. Optional, defaults to 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve and populate. Optional, defaults to 0 for no limit.</param>
    /// <exception cref="DacSqlExecutionException">Thrown when an SQL execution error occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown when a generic exception occurs during execution.</exception>
    public void FillDataTable(DataTable dt, string sql, SqlParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataTable(dt, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Populates the specified DataTable with data retrieved from the execution of a SQL command.
    /// </summary>
    /// <param name="dt">The DataTable to populate with the results of the SQL command.</param>
    /// <param name="sql">The SQL command text to execute.</param>
    /// <param name="parameters">The collection of parameters to pass to the SQL command.</param>
    /// <param name="commandType">The type of command to execute (e.g., Text, StoredProcedure). Optional, defaults to Text.</param>
    /// <param name="throwDBException">Indicates whether to throw database-specific exceptions. Optional, defaults to true.</param>
    /// <param name="throwGenericException">Indicates whether to throw generic exceptions for non-database-specific issues. Optional, defaults to true.</param>
    /// <param name="throwSystemException">Indicates whether to throw system-level exceptions during execution. Optional, defaults to true.</param>
    /// <param name="startRecord">The zero-based record number at which to start populating records. Optional, defaults to 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve and populate. Optional, defaults to 0 for no limit.</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException occurs.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown when the SQL query or stored procedure returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Throws if any generic exception occurs.</exception>
    [Obsolete(
        "Use FillDataTable(DataTable dt, string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0) instead.",
        false)]
    public void FillDataTable(DataTable dt, string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataTable(dt, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Populates the specified DataTable with data retrieved from the execution of a SQL command using the provided parameters.
    /// </summary>
    /// <param name="dt">The DataTable to fill with the results of the SQL command.</param>
    /// <param name="sql">The SQL query to execute.</param>
    /// <param name="parameters">The collection of parameters to pass to the SQL command.</param>
    /// <param name="commandType">Specifies how the command string is to be interpreted. Defaults to Text.</param>
    /// <param name="throwDBException">Determines whether to throw database-specific exceptions. Defaults to true.</param>
    /// <param name="throwGenericException">Determines whether to throw general exceptions for non-database issues. Defaults to true.</param>
    /// <param name="throwSystemException">Determines whether to throw system-level exceptions during execution. Defaults to true.</param>
    /// <param name="startRecord">The record number at which to start adding rows to the DataTable. Defaults to 0.</param>
    /// <param name="maxRecords">The maximum number of records to retrieve. Use 0 for no limit. Defaults to 0.</param>
    /// <exception cref="DacSqlExecutionException">Thrown if an error occurs during SQL execution.</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Thrown if the SQL command returns a non-zero error code.</exception>
    /// <exception cref="DacGenericException">Thrown if a non-database-specific error occurs.</exception>
    public void FillDataTable(DataTable dt, string sql, DacMsSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true,
        int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillDataTable(dt, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

}

