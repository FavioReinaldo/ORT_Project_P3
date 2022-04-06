using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{

    public class Planta
    {
        #region Atributos
        public Tipo miTipo { get; set; }
        public string nombreCientifico { get; set; }
        public List<string> misNombresVulgares { get; set; }
        public string descripcion { get; set; }
        public string ambiente { get; }
        public double alturaMaxima { get; set; }
        public string fotoUrl { get; set; }
        public FichaCuidados miFichaCuidados { get; set; }
        #endregion


        public enum AmbienteEnum { Interior , Exterior , Mixta};
        public Planta(string nombreCientifico, string descripcion, AmbienteEnum unambiente, double alturaMaxima, string fotoUrl) 
        {
            this.nombreCientifico = nombreCientifico;
            this.descripcion = descripcion;
            ambiente = (string)unambiente;
            this.alturaMaxima = alturaMaxima;
            this.fotoUrl = fotoUrl;
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

    }
}
