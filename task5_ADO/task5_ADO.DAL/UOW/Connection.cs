using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace task5_ADO.DAL.UOW
{
    public class Connection : IConnection 
    {

        public IDbTransaction _transaction { get; set; }

        public IDbConnection _connection { get; set; }

        public Connection()
        {
            string connString = ConfigurationManager.ConnectionStrings["ProdConection"].ConnectionString;
            var connection = new SqlConnection(connString);
            connection.Open();
            _connection = connection;           
            _transaction = connection.BeginTransaction();
        }

        
        public IDbCommand CreateCommand()
        {
            var command = _connection.CreateCommand();
            command.Transaction = _transaction;
            return command;
        }

        //public void SaveChanges()
        //{
        //    if (_transaction == null)
        //    {
        //        throw new InvalidOperationException(
        //            "Transaction already committed");
        //    }

        //    _transaction.Commit();
        //    _transaction = null;
        //}

        //Закрываем соединение,  если транзакция еще используется - откат. 
        public void Dispose()
        {
            if (_transaction != null)
            {
                _transaction.Rollback();
                _transaction = null;
            }

            if (_connection != null )
            {
                _connection.Close();
                _connection = null;
            }
        }
    }
}
