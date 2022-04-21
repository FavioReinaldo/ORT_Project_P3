using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{

    public class Planta
    {
        #region Atributos
        public string  NombreTipo { get; set; }
        public string NombreCientifico { get; set; }
        public List<string> NombresVulgares { get; set; }
        public string Descripcion { get; set; }
        public List<String> Ambiente { get; }
        public double AlturaMaxima { get; set; }
        public string FotoUrl { get; set; }
        public FichaCuidados FichaCuidados { get; set; }
        #endregion


        
        public Planta(string NombreTipo, string NombreCientifico, string Descripcion, string Unambiente, double AlturaMaxima, string FotoUrl) 
        {
            this.NombreTipo = NombreTipo;
            this.NombreCientifico = NombreCientifico;
            this.Descripcion = Descripcion;
            this.Ambiente.Add(Unambiente);
            this.AlturaMaxima = AlturaMaxima;
            this.FotoUrl = FotoUrl;
        }
        public Planta()
        {
            //Constructor por defecto
        }
        public bool ValidarPlanta(string NombreCientifico)
        {
            bool retorno = false;
            //falta validaciones (solo alfabeticos)
            if (NombreCientifico != null)
            {
                NombreCientifico.Trim();
                retorno = true;
            }




            return retorno;
        }


        public bool ValidarDescripcion(string miDescripcion)
        {
            bool retorno = false;

            if (miDescripcion.Length < 500 && miDescripcion.Length > 10)
            {
                retorno = true;
            }

            return retorno;
        }
        //public override bool Equals(object obj)
        //{
        //    Planta unaP = obj as Planta;
        //    return obj != null && nombreCientifico == unaP.NombreCientifico;

        //}

        public bool IsValid()
        {
            return !string.IsNullOrEmpty(Nombre);
        }

    }
}
