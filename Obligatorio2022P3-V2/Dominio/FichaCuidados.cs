using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class FichaCuidados
    {
        #region Atributos
        public string FrecuenciaRiego { get; set; }
        public string Milluminacion { get; set; }
        public double Temperatura { get; set; }
        #endregion

        #region Constructor
        public FichaCuidados()
        {

        }
        #endregion
    }
}
