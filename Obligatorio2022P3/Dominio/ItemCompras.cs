using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class ItemCompras
    {
        
        #region Atributos
        public Planta PlantaComprada { get; set; }
        public int Cantidad { get; set; }
        public decimal PrecioCompraUnidad { get; set; }
        #endregion

  

        #region Constructor
        public ItemCompras(int cantidad, decimal precioCompraUnidad)
        {
            this.Cantidad = cantidad;
            this.PrecioCompraUnidad = precioCompraUnidad;
        }
        #endregion
        //ToString

    }
}
