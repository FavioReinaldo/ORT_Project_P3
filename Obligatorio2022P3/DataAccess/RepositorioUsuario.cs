using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess
{
    public class RepositorioUsuario : IRepositorioUsuario
    {

        IDbConnection _conn = null;
        public RepositorioUsuario(IDbConnection connection)
        {
            _conn = connection;
        }
        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get()
        {
            throw new NotImplementedException();
        }

        public IEnumerable GetUsuario(string mail, string password)
        {
            ICollection<Usuario> result = new List<Usuario>();
            IDbCommand command = _conn.CreateCommand();
            command.CommandText = $"Select * From dbo.Usuario where Mail = {mail} AND Password = {password}";

            try
            {
                _conn.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    Usuario usuario = null;
                    while (reader.Read())
                    {
                        usuario = new Usuario();
                        usuario.mail = (string)reader["Mail"];
                        usuario.password = (string)reader["Password"];                        
                        result.Add(usuario);
                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
            finally
            {

                if (_conn != null)
                {
                    _conn.Close();
                    _conn.Dispose();
                }

            }
            return result;
        }

        public Usuario GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Usuario obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Usuario obj)
        {
            throw new NotImplementedException();
        }
    }
}
