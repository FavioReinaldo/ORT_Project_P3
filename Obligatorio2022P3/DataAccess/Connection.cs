using System;
using System.Collections.Generic;
using System.Text;
<<<<<<< Updated upstream
<<<<<<< Updated upstream

using System.Data;
using System.Data.SqlClient;

=======
using System.Data;
using System.Data.SqlClient;


>>>>>>> Stashed changes
=======
using System.Data;
using System.Data.SqlClient;


>>>>>>> Stashed changes
namespace DataAccess
{
    public class Connection : IDbConnection
    {
<<<<<<< Updated upstream
<<<<<<< Updated upstream

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
=======
=======
>>>>>>> Stashed changes
        SqlConnection con = null;
        //Cada uno en su maquina modifique data source
        private string connectionString = @"data source=DESKTOP-MJ8GCR2; database=Obligatori_P3; integrated security=true";

        public string ConnectionString { get => connectionString; set => connectionString = value; }
        public int ConnectionTimeout => con.ConnectionTimeout;

        public Connection()
        {
            con = new SqlConnection(connectionString);
        }

        public string Database => con.Database;

        public ConnectionState State => con.State;

        public IDbTransaction BeginTransaction()
        {
            return con.BeginTransaction();
<<<<<<< Updated upstream
>>>>>>> Stashed changes
=======
>>>>>>> Stashed changes
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
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            conn.Close();
=======
            con.Close();
>>>>>>> Stashed changes
=======
            con.Close();
>>>>>>> Stashed changes
        }

        public IDbCommand CreateCommand()
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            return conn.CreateCommand();
=======
            return con.CreateCommand();
>>>>>>> Stashed changes
=======
            return con.CreateCommand();
>>>>>>> Stashed changes
        }

        public void Dispose()
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            conn.Dispose();
=======
            con.Dispose();
>>>>>>> Stashed changes
=======
            con.Dispose();
>>>>>>> Stashed changes
        }

        public void Open()
        {
<<<<<<< Updated upstream
<<<<<<< Updated upstream
            conn.Open();
=======
            con.Open();
>>>>>>> Stashed changes
=======
            con.Open();
>>>>>>> Stashed changes
        }
    }
}
