using log4net;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BalajiTrader.DataAccess
{
    public class BaseDAO
    {
        #region
        private static readonly ILog log = LogManager.GetLogger(System.Reflection.MethodBase.GetCurrentMethod().DeclaringType);
        private IDbConnection _connection;
        public static readonly int Large_TimeOut = Convert.ToInt32(ConfigurationManager.AppSettings["DatabaseTimeOut"]);
        #endregion

        #region derivable method
        protected IDbConnection OpenConnection()
        {
            try
            {
                _connection = new SqlConnection(ConfigSetting.ConnectionString);
                //_connection = new SqlConnection(ConfigSetting.Decrypt_ConString());
                if (_connection.State == ConnectionState.Closed)
                    _connection.Open();
            }
            catch (Exception ex) { }
            return _connection;
        }
        #endregion

        #region Execute Dataset
        protected DataSet ExecuteDataset(string storeProcedure, SqlParameter[] parameters)
        {
            log.Info("ExecuteDataset");
            using (IDbCommand command = CreateCommand(null, storeProcedure, CommandType.StoredProcedure, parameters))
            {
                log.Info("Executing Dataset...!");
                CheckConnection(command.Connection);
                return FillDataset(command);
            }
        }
        #endregion

        #region Execute NonQuery
        protected void ExecuteNonQuery(string storeProcedure, SqlParameter[] parameters)
        {
            log.Info("ExecuteNonQuery");
            using (IDbCommand command = CreateCommand(null, storeProcedure, CommandType.StoredProcedure, parameters))
            {
                log.Info("Executing Query...!");
                command.ExecuteNonQuery();
            }
        }

        protected void ExecuteNonQuery(IDbTransaction transaction, string storeProcedure, SqlParameter[] parameters)
        {
            log.Info("ExecuteNonQuery");
            using (IDbCommand command = CreateCommand(transaction, storeProcedure, CommandType.StoredProcedure, parameters))
            {
                log.Info("Executing Query...!");
                command.ExecuteNonQuery();
            }
        }

        protected void ExecuteNonQuery(IDbTransaction transaction, string storeProcedure, SqlParameter[] parameters, int timeOut)
        {
            log.Info("ExecuteNonQuery");
            using (IDbCommand command = CreateCommand(transaction, storeProcedure, CommandType.StoredProcedure, parameters))
            {
                log.Info("Executing Query...!");
                command.CommandTimeout = timeOut;
                command.ExecuteNonQuery();
            }
        }
        #endregion

        #region Create Command object
        private IDbCommand CreateCommand(IDbTransaction transaction, string commandText, CommandType commandType, SqlParameter[] parameters)
        {
            string tranString = transaction == null ? "Null" : transaction.ToString();
            log.Info("Create Command object: " + DateTime.Now + "; Target: " + commandText + "; Transaction string: " + tranString);
            IDbCommand command = new SqlCommand();
            if (transaction == null)
            {
                OpenConnection();
                command.Connection = _connection;
            }
            else
            {
                if (transaction.Connection.State == ConnectionState.Closed || transaction.Connection.State == ConnectionState.Broken)
                {
                    transaction.Connection.Open();
                    log.Info("Re-Opened Tranction Connection :" + DateTime.Now);
                }
                command.Connection = transaction.Connection;
            }
            command.Transaction = transaction;
            command.CommandText = commandText;
            command.CommandTimeout = Large_TimeOut;
            command.CommandType = commandType;

            if (parameters != null && parameters.Length > 0)
            {
                foreach (SqlParameter parameter in parameters)
                {
                    command.Parameters.Add(parameter);
                }
            }
            return command;
        }

        private static void CheckConnection(IDbConnection connection)
        {
            switch (connection.State)
            {
                case ConnectionState.Closed:
                case ConnectionState.Broken:
                    connection.Open();
                    break;
                case ConnectionState.Connecting:
                case ConnectionState.Executing:
                case ConnectionState.Fetching:
                    Thread.Sleep(100);
                    break;
            }
        }
        #endregion

        #region Private worker method
        private DataSet FillDataset(IDbCommand command)
        {
            using (SqlDataAdapter da = new SqlDataAdapter((SqlCommand)command))
            {
                DataSet ds = new DataSet();
                da.Fill(ds);
                command.Parameters.Clear();
                return ds;
            }
        }
        #endregion

        #region  Transaction
        /// <summary>
        /// Create a new connection and associate the new transaction with the object.
        /// The transaction is returned in the method.
        /// </summary>
        /// <returns>Transaction object</returns>
        public IDbTransaction BeginTransaction()
        {
            _connection = OpenConnection();
            return _connection.BeginTransaction(IsolationLevel.ReadCommitted);
        }

        /// <summary>
        /// Commit the transaction from the associated database.
        /// </summary>
        /// <param name="transaction">Transaction object</param>
        public void CommitTransaction(IDbTransaction transaction)
        {
            transaction.Commit();
        }

        /// <summary>
        /// Rollback the transaction from the associated database.
        /// </summary>
        /// <param name="transaction">Transaction object</param>
        public void RollbackTransaction(IDbTransaction transaction)
        {
            transaction.Rollback();
        }
        #endregion
    }
}
