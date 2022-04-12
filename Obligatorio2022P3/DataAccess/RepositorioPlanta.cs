using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace DataAccess
{
    public class RepositorioPlanta : IRepositorioPlanta
    {
        IDbConnection _conn = null;
        public RepositorioPlanta(IDbConnection connection)
        {
            _conn = connection;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable Get()
        {
            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _conn.CreateCommand();
            command.CommandText = "Select * From dbo.Planta";

            try
            {
                _conn.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    Planta planta = null;
                    while (reader.Read())
                    {
                        planta = new Planta();
                        planta.miTipo = (Tipo)reader["Tipo"];
                        planta.nombreCientifico = (string)reader["NombreCientifico"];
                        planta.misNombresVulgares = (List<string>)reader["MisNombresVulgares"];
                        planta.descripcion = (string)reader["Descripcion"];
                        planta.ambiente = (string)reader["Ambiente"];/*********************************************************************************************/
                        planta.alturaMaxima = (double)reader["AlturaMaxima"];
                        planta.fotoUrl = (string)reader["FotoUrl"];
                        planta.miFichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                        result.Add(planta);
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
        public IEnumerable GetMasBajasQueXCentimetros(double miAlturaMaxima)
        {
            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _conn.CreateCommand();
            command.CommandText = $"Select * From dbo.Planta Where Altura < {miAlturaMaxima}";

            try
            {
                _conn.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    Planta planta = null;
                    while (reader.Read())
                    {
                        planta = new Planta();
                        planta.miTipo = (Tipo)reader["Tipo"];
                        planta.nombreCientifico = (string)reader["NombreCientifico"];
                        planta.misNombresVulgares = (List<string>)reader["MisNombresVulgares"];
                        planta.descripcion = (string)reader["Descripcion"];
                        planta.ambiente = (string)reader["Ambiente"];/*********************************************************************************************/
                        planta.alturaMaxima = (double)reader["AlturaMaxima"];
                        planta.fotoUrl = (string)reader["FotoUrl"];
                        planta.miFichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                        result.Add(planta);
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
        public Planta GetById(int id)
        {
            throw new NotImplementedException();
        }

        public void Insert(Planta obj)
        {
            throw new NotImplementedException();
        }

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Planta obj)
        {
            throw new NotImplementedException();
        }
    }
}
