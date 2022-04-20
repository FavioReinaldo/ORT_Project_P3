using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Dominio;


namespace DataAccess
{
    interface IRepositorioPlanta:IRepositorio<Planta>
    {
        new IEnumerable GetMasBajasQueXCentimetros(double miAlturaMaxima);
        new IEnumerable GetDeXCentimetrosOMas(double miAlturaMaxima);
        IEnumerable GetPorAmbiente(double miAmbiente);
    }
}
