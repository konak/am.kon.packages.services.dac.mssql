using System.Data;
using am.kon.packages.dac.primitives;

namespace am.kon.packages.services.dac.mssql;

public partial class DatabaseConnectionService
{
    /// <summary>
    /// Execute SQL command or stored procedure and fill resultinng data into the dataOut object
    /// </summary>
    /// <typeparam name="T">A generic type of the object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></typeparam>
    /// <param name="dataOut">Object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></param>
    /// <param name="sql">SQL query, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <param name="throwDBException">Throw SQL execution exceptions or suspend them</param>
    /// <param name="throwGenericException">Throw Generic exceptions or suspend them</param>
    /// <param name="throwSystemException">Throw System exceptions or suspend them</param>
    /// <param name="startRecord">The zero based record number to start with</param>
    /// <param name="maxRecords">The maximum number of records to retrive</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillData<T>(T dataOut, string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Execute SQL command or stored procedure and fill resultinng data into the dataOut object
    /// </summary>
    /// <typeparam name="T">A generic type of the object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></typeparam>
    /// <param name="dataOut">Object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></param>
    /// <param name="sql">SQL query, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <param name="throwDBException">Throw SQL execution exceptions or suspend them</param>
    /// <param name="throwGenericException">Throw Generic exceptions or suspend them</param>
    /// <param name="throwSystemException">Throw System exceptions or suspend them</param>
    /// <param name="startRecord">The zero based record number to start with</param>
    /// <param name="maxRecords">The maximum number of records to retrive</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillData<T>(T dataOut, string sql, List<KeyValuePair<string, object>> parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Execute SQL command or stored procedure and fill resultinng data into the dataOut object
    /// </summary>
    /// <typeparam name="T">A generic type of the object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></typeparam>
    /// <param name="dataOut">Object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></param>
    /// <param name="sql">SQL query, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <param name="throwDBException">Throw SQL execution exceptions or suspend them</param>
    /// <param name="throwGenericException">Throw Generic exceptions or suspend them</param>
    /// <param name="throwSystemException">Throw System exceptions or suspend them</param>
    /// <param name="startRecord">The zero based record number to start with</param>
    /// <param name="maxRecords">The maximum number of records to retrive</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillData<T>(T dataOut, string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Execute SQL command or stored procedure and fill resultinng data into the dataOut object
    /// </summary>
    /// <typeparam name="T">A generic type of the object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></typeparam>
    /// <param name="dataOut">Object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></param>
    /// <param name="sql">SQL query, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <param name="throwDBException">Throw SQL execution exceptions or suspend them</param>
    /// <param name="throwGenericException">Throw Generic exceptions or suspend them</param>
    /// <param name="throwSystemException">Throw System exceptions or suspend them</param>
    /// <param name="startRecord">The zero based record number to start with</param>
    /// <param name="maxRecords">The maximum number of records to retrive</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillData<T>(T dataOut, string sql, dynamic parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Execute SQL command or stored procedure and fill resultinng data into the dataOut object
    /// </summary>
    /// <typeparam name="T">A generic type of the object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></typeparam>
    /// <param name="dataOut">Object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></param>
    /// <param name="sql">SQL query, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <param name="throwDBException">Throw SQL execution exceptions or suspend them</param>
    /// <param name="throwGenericException">Throw Generic exceptions or suspend them</param>
    /// <param name="throwSystemException">Throw System exceptions or suspend them</param>
    /// <param name="startRecord">The zero based record number to start with</param>
    /// <param name="maxRecords">The maximum number of records to retrive</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillData<T, TParam>(T dataOut, string sql, TParam parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }

    /// <summary>
    /// Execute SQL command or stored procedure and fill resultinng data into the dataOut object
    /// </summary>
    /// <typeparam name="T">A generic type of the object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></typeparam>
    /// <param name="dataOut">Object that will be filled with values. Type of objects that can be passed: <list type="bullet"><item><description>DataTable</description></item><item><description>DataSet</description></item></list></param>
    /// <param name="sql">SQL query, stored procedure or table name</param>
    /// <param name="commandType">SQL command type to execute</param>
    /// <param name="parameters">Parameters of the SQL command</param>
    /// <param name="throwDBException">Throw SQL execution exceptions or suspend them</param>
    /// <param name="throwGenericException">Throw Generic exceptions or suspend them</param>
    /// <param name="throwSystemException">Throw System exceptions or suspend them</param>
    /// <param name="startRecord">The zero based record number to start with</param>
    /// <param name="maxRecords">The maximum number of records to retrive</param>
    /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
    /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
    /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
    public void FillData<T>(T dataOut, string sql, KeyValuePair<string, object>[] parameters, CommandType commandType = CommandType.Text, bool throwDBException = true, bool throwGenericException = true, bool throwSystemException = true, int startRecord = 0, int maxRecords = 0)
    {
        _defaultDatabase.FillData<T>(dataOut, sql, parameters, commandType, throwDBException, throwGenericException, throwSystemException, startRecord, maxRecords);
    }
}

