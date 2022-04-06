using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class ItemCompras
    {
        
        #region Atributos
        private Planta plantaComprada;
        private int cantidad;
        private decimal precioCompraUnidad;
        #endregion

        //Propiedades
        public Planta PlantaComprada
        {
            get { return plantaComprada; }
        }
        public int Cantidad
        {
            get { return cantidad; }
            set { cantidad = value; }
        }
        public decimal PrecioCompraUnidad
        {
            get { return precioCompraUnidad; }
            set { precioCompraUnidad = value; }
        }

        #region Constructor
        public ItemCompras(int cantidad, decimal precioCompraUnidad)
        {
            this.cantidad = cantidad;
            this.precioCompraUnidad = precioCompraUnidad;
        }
        #endregion
        //ToString

    }
}
