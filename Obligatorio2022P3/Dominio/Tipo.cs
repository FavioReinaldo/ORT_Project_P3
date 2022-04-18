using System;
using System.Collections.Generic;
using System.Text;

namespace Dominio
{
    public class Tipo
    {
        #region Atributos    
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        #endregion

        #region Constructores
        //*************** METODO CONSTRUCTOR DE TIPO ***************

        public Tipo()
        {

        }
        public Tipo(string Nombre, string Descripcion)
        {
            this.Nombre = Nombre;
            this.Descripcion = Descripcion;
        }
        #endregion

        #region Metodo ModificarTipo
        //*************** METODO MODIFICAR TIPO ***************
        public bool ModificarTipo(string miDescripcion)
        {
            bool resultado = false;
            if (miDescripcion != null && miDescripcion != "")
            {
                this.Descripcion = Descripcion;
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
