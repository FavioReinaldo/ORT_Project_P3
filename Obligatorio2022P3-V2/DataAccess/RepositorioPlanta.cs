﻿using Dominio;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
            command.CommandText = "Select * From Planta";

            try
            {
                _conn.Open();
                using IDataReader reader = command.ExecuteReader();
                Planta planta = null;
                
                while (reader.Read())
                {
                    Planta unaPlanta = new Planta();
                    planta = unaPlanta;
                    planta.NombreTipo= (string)reader["NombreTipo"];
                    planta.NombreCientifico = (string)reader["NombreCientifico"];
                    planta.NombresVulgares = (string)reader["NombresVulgares"];
                    planta.Descripcion = (string)reader["Descripcion"];
                    planta.Ambiente = (string)reader["Ambiente"];/*********************************************************************************************/
                    planta.AlturaMaxima = (int)reader["AlturaMaxima"];
                    planta.FotoPlanta = (string)reader["FotoPlanta"];
                    //planta.FichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                    result.Add(planta);
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
            IDbCommand command = _conn.CreateCommand();
            command.CommandText = @"INSERT INTO Planta(NombreTipo, NombresVulgares, NombreCientifico, Descripcion, Ambiente, AlturaMaxima, FotoPlanta) VALUES(@NombreTipo, @NombresVulgares, @NombreCientifico, @Descripcion, @Ambiente, @AlturaMaxima, @FotoPlanta)";
            command.Parameters.Add(new SqlParameter("@NombreTipo", obj.NombreTipo));
            command.Parameters.Add(new SqlParameter("@NombresVulgares", obj.NombresVulgares));
            command.Parameters.Add(new SqlParameter("@NombreCientifico", obj.NombreCientifico));
            command.Parameters.Add(new SqlParameter("@Descripcion", obj.Descripcion));
            command.Parameters.Add(new SqlParameter("@Ambiente", obj.Ambiente));
            command.Parameters.Add(new SqlParameter("@AlturaMaxima", obj.AlturaMaxima));
            command.Parameters.Add(new SqlParameter("@FotoPlanta", obj.FotoPlanta));




            try
            {
                _conn.Open();
                int filasAfectadas = command.ExecuteNonQuery();
                if (filasAfectadas == 0)
                    throw new Exception();
            }
            catch (Exception e)
            {
                throw;
            }
            finally
            {
                _conn.Close();
                _conn.Dispose();
                command.Dispose();
            }
        }

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
                using IDataReader reader = command.ExecuteReader();
                Planta planta = null;
                
                while (reader.Read())
                {
                    Planta unaPlanta = new Planta();
                    planta = unaPlanta;
                    planta.NombreTipo = (string)reader["NombreTipo"];
                    planta.NombreCientifico = (string)reader["NombreCientifico"];
                    planta.NombresVulgares = (string)reader["NombresVulgares"];
                    planta.Descripcion = (string)reader["Descripcion"];
                    planta.Ambiente = (string)reader["Ambiente"];/*********************************************************************************************/
                    planta.AlturaMaxima = (int)reader["AlturaMaxima"];
                    planta.FotoPlanta = (string)reader["FotoPlanta"];
                    //planta.FichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                    result.Add(planta);
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
                using IDataReader reader = command.ExecuteReader();
                Planta planta = null;
                
                while (reader.Read())
                {
                    Planta unaPlanta = new Planta();
                    planta = unaPlanta;
                    planta.NombreTipo = (string)reader["NombreTipo"];
                    planta.NombreCientifico = (string)reader["NombreCientifico"];
                    planta.NombresVulgares = (string)reader["NombresVulgares"];
                    planta.Descripcion = (string)reader["Descripcion"];
                    planta.Ambiente = (string)reader["Ambiente"];/*********************************************************************************************/
                    planta.AlturaMaxima = (int)reader["AlturaMaxima"];
                    planta.FotoPlanta = (string)reader["FotoPlanta"];
                    //planta.FichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                    result.Add(planta);
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
                using IDataReader reader = command.ExecuteReader();
                Planta planta = null;
                
                while (reader.Read())
                {
                    Planta unaPlanta = new Planta();
                    planta = unaPlanta;
                    planta.NombreTipo = (string)reader["NombreTipo"];
                    planta.NombreCientifico = (string)reader["NombreCientifico"];
                    planta.NombresVulgares = (string)reader["NombresVulgares"];
                    planta.Descripcion = (string)reader["Descripcion"];
                    planta.Ambiente = (string)reader["Ambiente"];/*********************************************************************************************/
                    planta.AlturaMaxima = (int)reader["AlturaMaxima"];
                    planta.FotoPlanta = (string)reader["FotoPlanta"];
                    //planta.FichaCuidados = (FichaCuidados)reader["FichaCuidados"];
                    result.Add(planta);
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

        object IRepositorio<Planta>.GetMasBajasQueXCentimetros(double miAlturaMaxima)
        {
            throw new NotImplementedException();
        }

        object IRepositorio<Planta>.GetDeXCentimetrosOMas(double miAlturaMinima)
        {
            throw new NotImplementedException();
        }

        public object GetPorAmbiente(string miAmbiente)
        {
            throw new NotImplementedException();
        }

        public Planta GetByName(string nombre)
        {
            throw new NotImplementedException();
        }

        public void Delete(string nombre)
        {
            throw new NotImplementedException();
        }
    }
}
