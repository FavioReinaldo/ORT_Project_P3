using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Plaza : Compra
    {
        //Atributos
        private double iva;
        private double flete;
        //Propiedades
        public double Iva
        {
            get { return iva; }
            set { iva = value; }
        }
        public double Flete
        {
            get { return flete; }
            set { flete = value; }
        }

        //constructor
        public Plaza(DateTime fecha, double iva, double flete) : base(fecha)
        {
            this.iva = iva;
            this.flete = flete;
        }
        

    }
}
