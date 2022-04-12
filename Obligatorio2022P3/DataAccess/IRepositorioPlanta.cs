using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Dominio;


namespace DataAccess
{
    interface IRepositorioPlanta:IRepositorio<Planta>
    {
        IEnumerable GetMasBajasQueXCentimetros(double miAlturaMaxima);
    }
}
