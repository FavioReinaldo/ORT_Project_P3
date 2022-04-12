using System;
using System.Collections.Generic;
using System.Text;

using System.Data;
using System.Data.SqlClient;

namespace DataAccess
{
    public class Connection : IDbConnection
    {

        SqlConnection conn = null;

        private string connectionString = "data source=FR\\; database=p3db; integrated security=true; TrustServerCertificate=True";
        public string ConnectionString { get => connectionString; set => connectionString = value; }

        public int ConnectionTimeout => conn.ConnectionTimeout;

        public Connection()
        {
            conn = new SqlConnection(connectionString);
        }
        public string Database => conn.Database;

        public ConnectionState State => conn.State;

        public IDbTransaction BeginTransaction()
        {
            throw new NotImplementedException();
        }

        public IDbTransaction BeginTransaction(IsolationLevel il)
        {
            throw new NotImplementedException();
        }

        public void ChangeDatabase(string databaseName)
        {
            throw new NotImplementedException();
        }

        public void Close()
        {
            conn.Close();
        }

        public IDbCommand CreateCommand()
        {
            return conn.CreateCommand();
        }

        public void Dispose()
        {
            conn.Dispose();
        }

        public void Open()
        {
            conn.Open();
        }
    }
}
