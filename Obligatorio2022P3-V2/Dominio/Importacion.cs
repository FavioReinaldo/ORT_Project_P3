using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Importacion : Compra
    {

        
        #region Atributos
        private double impuestoImportacion;
        private bool esOrigenAmericaDelSur;
        private double porcentajeDescuento;
        private string medidasSanitarias;
        #endregion

        
        #region Propiedades
        public double ImpuestoImportacion
        {
            get { return impuestoImportacion; }
            set { impuestoImportacion = value; }
        }
        public bool EsOrigenAmericaDelSur
        {
            get { return esOrigenAmericaDelSur; }
            set { esOrigenAmericaDelSur = value; }
        }
        public double PorcentajeDescuento
        {
            get { return porcentajeDescuento; }
            set { porcentajeDescuento = value; }
        }
        public string MedidasSanitarias
        {
            get { return medidasSanitarias; }
            set { medidasSanitarias = value; }
        }
        #endregion
        
        #region Constructor
        public Importacion(DateTime fecha, double impuestoImportacion, bool esOrigenAmericaDelSur, double PorcentajeDescuento, string medidasSanitarias) : base(fecha)
        {
            this.impuestoImportacion = impuestoImportacion;
            this.esOrigenAmericaDelSur = esOrigenAmericaDelSur;
            this.PorcentajeDescuento = PorcentajeDescuento;
            this.medidasSanitarias = medidasSanitarias;
        }
        #endregion
    }
}
