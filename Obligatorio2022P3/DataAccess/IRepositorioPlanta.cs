<<<<<<< Updated upstream
﻿using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

using Dominio;


namespace DataAccess
{
    interface IRepositorioPlanta:IRepositorio<Planta>
    { 
        IEnumerable GetMasBajasQueXCentimetros(double miAlturaMaxima);
        IEnumerable GetDeXCentimetrosOMas(double miAlturaMaxima);
        IEnumerable GetPorAmbiente(double miAmbiente);
=======
﻿using Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DataAccess
{
    public interface IRepositorioPlanta : IRepositorio<Planta>
    {

>>>>>>> Stashed changes
    }
}
