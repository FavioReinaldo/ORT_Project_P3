using System;
using System.Collections.Generic;

namespace Dominio
{
    public abstract class Compra
    {
        
        #region Atributos
        private DateTime fecha;
        private List<ItemCompras> compras = new List<ItemCompras>();
        #endregion
        
        #region Propiedades
        public DateTime Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }
        public List<ItemCompras> Compras
        {
            get { return compras; }
        }
        #endregion
        
        #region Constructor
        public Compra(DateTime fecha)
        {
            this.fecha = fecha;
            
        }
        #endregion

    }
}
