<<<<<<< Updated upstream
﻿using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Text;
=======
﻿using System;
using System.Collections.Generic;
using System.Collections;
using System.Data;
using Dominio;
using System.Data.SqlClient;
>>>>>>> Stashed changes

namespace DataAccess
{
    public class RepositorioPlanta : IRepositorioPlanta
    {
<<<<<<< Updated upstream
        IDbConnection _conn = null;
        public RepositorioPlanta(IDbConnection connection)
        {
            _conn = connection;
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
=======
        private IDbConnection _con;

        public RepositorioPlanta(IDbConnection connection)
        {
            this._con = connection;
>>>>>>> Stashed changes
        }

        public IEnumerable Get()
        {
            ICollection<Planta> result = new List<Planta>();
<<<<<<< Updated upstream
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
                        planta.ambiente[0] = (string)reader["Ambiente"];/*********************************************************************************************/
                        planta.alturaMaxima = (double)reader["AlturaMaxima"];
                        planta.fotoUrl = (string)reader["FotoUrl"];
                        planta.miFichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                        result.Add(planta);
=======

            IDbCommand command = _con.CreateCommand();
            command.CommandText = "Select * FROM dbo.Planta";
            try
            {
                _con.Open();
                using (IDataReader reader = command.ExecuteReader())
                {
                    Planta unaPlanta = null;
                    while (reader.Read())
                    {
                        unaPlanta = new Planta();
                        unaPlanta.nombreCientifico = (string)reader["NombreCientifico"];
                        unaPlanta.descripcion = (string)reader["Descripcion"];

                        result.Add(unaPlanta);
>>>>>>> Stashed changes
                    }
                }
            }
            catch (Exception)
            {
<<<<<<< Updated upstream

=======
>>>>>>> Stashed changes
                throw;
            }
            finally
            {
<<<<<<< Updated upstream

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
=======
                _con.Close();
                _con.Dispose();
            }
            return result;
        }
>>>>>>> Stashed changes

        public void Insert(Planta obj)
        {
            throw new NotImplementedException();
        }
<<<<<<< Updated upstream

        public void Save()
        {
            throw new NotImplementedException();
        }

        public void Update(Planta obj)
        {
            throw new NotImplementedException();
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
                        planta.ambiente[0] = (string)reader["Ambiente"];/*********************************************************************************************/
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
            return result; ;
        }

        public IEnumerable GetDeXCentimetrosOMas(double miAlturaMinima)
        {
            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _conn.CreateCommand();
            command.CommandText = $"Select * From dbo.Planta Where Altura >= {miAlturaMinima}";

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
                        planta.ambiente[0] = (string)reader["Ambiente"];/*********************************************************************************************/
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
            return result; ;
        }

        public IEnumerable GetPorAmbiente(double miAmbiente)
        {
            ICollection<Planta> result = new List<Planta>();
            IDbCommand command = _conn.CreateCommand();
            command.CommandText = $"Select * From dbo.Planta Where Ambiente = {miAmbiente}";

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
                        planta.ambiente[0] = (string)reader["Ambiente"];/*********************************************************************************************/
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
            return result; ;
        }
=======
>>>>>>> Stashed changes
    }
}
