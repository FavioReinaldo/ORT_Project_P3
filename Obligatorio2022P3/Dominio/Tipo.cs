using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Tipo
    {
        #region Atributos    
        public string miNombre { get; set; }
        public string miDescripcion { get; set; }
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE TIPO ***************
        public Tipo(string miNombre, string miDescripcion)
        {
            this.miNombre = miNombre;
            this.miDescripcion = miDescripcion;
        }
        #endregion

        #region Metodo ModificarTipo
        //*************** METODO MODIFICAR TIPO ***************
        public bool ModificarTipo(string miDescripcion)
        {
            bool resultado = false;
            if (miDescripcion != null && miDescripcion != "")
            {
                this.miDescripcion = miDescripcion;
                resultado = true;
            }
            return resultado;
        }
        public bool ValidarTipo(string nombre, string descripcion)
        {
            bool exito = false;
            if (nombre != null && descripcion != null)
            {
                exito = true;
            }
            return exito;
        }
        #endregion
        //public override bool Equals(object obj)
        //{
        //    Tipo unT = obj as Tipo;
        //    return obj != null && miNombre == unT.miNombre;

        //}

    }
}
