using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Dominio;

namespace DataAccess
{
    interface IRepositorioUsuario:IRepositorio<Usuario>
    {
        IEnumerable GetUsuario(string mail, string usuario);
    }
}
