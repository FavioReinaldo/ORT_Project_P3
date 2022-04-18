using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Dominio;
using System.Data.SqlClient;

namespace DataAccess
{
    public class RepositorioTipo : IRepositorioTipo
    {
        private IDbConnection _con;

        
        public RepositorioTipo(IDbConnection connection)
        {
            this._con = connection;
        }

        public IEnumerable Get()
        {
            ICollection<Tipo> result = new List<Tipo>();

            IDbCommand command = _con.CreateCommand();
            command.CommandText = "Select * FROM dbo.Tipo";
            try
            {
                _con.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    Tipo unTipo = null;
                    while (reader.Read())
                    {
                        unTipo = new Tipo();
                        unTipo.Nombre = (string)reader["Nombre"];
                        unTipo.Descripcion = (string)reader["Descripcion"];
                        
                        result.Add(unTipo);
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _con.Close();
                _con.Dispose();
            }
            return result;
        }
        public void Insert(Tipo obj)
        {
            

            IDbCommand command = _con.CreateCommand();
            command.CommandText = @"Insert into dbo.Tipo(Nombre, Descripcion) values(@Nombre, @Descripcion)";
            command.Parameters.Add(new SqlParameter("@Nombre", obj.Nombre));
            command.Parameters.Add(new SqlParameter("@Descripcion", obj.Descripcion));
            try
            {
                _con.Open();
                using IDataReader reader = command.ExecuteReader(); ;



            }
            catch (Exception)
            {
                throw;
            }
            finally
            {
                _con.Close();
                _con.Dispose();
            }
            
        }

       
    }
}
