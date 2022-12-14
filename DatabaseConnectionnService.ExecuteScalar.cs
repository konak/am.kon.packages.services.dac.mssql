using System.Data;
using am.kon.packages.dac.primitives;

namespace am.kon.packages.services.dac.mssql
{
    public partial class DatabaseConnectionService
	{
        /// <summary>
        /// Execute SQL command and return value of first column of the first row from results
        /// </summary>
        /// <param name="sql">SQL command text to be executed</param>
        /// <param name="commandType">SQL command type to execute</param>
        /// <param name="parameters">Parameters of the SQL command</param>
        /// <returns>Value of first column of the first row</returns>
        /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
        /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
        /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
        public Task<object> ExecuteScalarAsync(string sql, IDataParameter[] parameters, CommandType commandType = CommandType.Text)
        {
            return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
        }

        /// <summary>
        /// Execute SQL command and return value of first column of the first row from results
        /// </summary>
        /// <param name="sql">SQL command text to be executed</param>
        /// <param name="commandType">SQL command type to execute</param>
        /// <param name="parameters">Parameters of the SQL command</param>
        /// <returns>Value of first column of the first row</returns>
        /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
        /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
        /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
        public Task<object> ExecuteScalarAsync(string sql, KeyValuePair<string, object>[] parameters, CommandType commandType = CommandType.Text)
        {
            return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
        }

        /// <summary>
        /// Execute SQL command and return value of first column of the first row from results
        /// </summary>
        /// <param name="sql">SQL command text to be executed</param>
        /// <param name="commandType">SQL command type to execute</param>
        /// <param name="parameters">Parameters of the SQL command</param>
        /// <returns>Value of first column of the first row</returns>
        /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
        /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
        /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
        public Task<object> ExecuteScalarAsync(string sql, List<KeyValuePair<string, object>> parameters, CommandType commandType = CommandType.Text)
        {
            return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
        }

        /// <summary>
        /// Execute SQL command and return value of first column of the first row from results
        /// </summary>
        /// <param name="sql">SQL command text to be executed</param>
        /// <param name="commandType">SQL command type to execute</param>
        /// <param name="parameters">Parameters of the SQL command</param>
        /// <returns>Value of first column of the first row</returns>
        /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
        /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
        /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
        public Task<object> ExecuteScalarAsync(string sql, DacSqlParameters parameters, CommandType commandType = CommandType.Text)
        {
            return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
        }

        /// <summary>
        /// Execute SQL command and return value of first column of the first row from results
        /// </summary>
        /// <param name="sql">SQL command text to be executed</param>
        /// <param name="commandType">SQL command type to execute</param>
        /// <param name="parameters">Parameters of the SQL command</param>
        /// <returns>Value of first column of the first row</returns>
        /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
        /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
        /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
        public Task<object> ExecuteScalarAsync(string sql, dynamic parameters, CommandType commandType = CommandType.Text)
        {
            return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
        }

        /// <summary>
        /// Execute SQL command and return value of first column of the first row from results
        /// </summary>
        /// <param name="sql">SQL command text to be executed</param>
        /// <param name="commandType">SQL command type to execute</param>
        /// <param name="parameters">Parameters of the SQL command</param>
        /// <returns>Value of first column of the first row</returns>
        /// <exception cref="DacSqlExecutionException">Throws if any SqlException has accured</exception>
        /// <exception cref="DacSqlExecutionReturnedErrorCodeException">Throws if SQL query or stored procedure has returned non zero code</exception>
        /// <exception cref="DacGenericException">Throws if any Generic exception has accured</exception>
        public Task<object> ExecuteScalarAsync<T>(string sql, T parameters, CommandType commandType = CommandType.Text)
        {
            return _defaultDatabase.ExecuteScalarAsync(sql, parameters, commandType);
        }
    }
}

