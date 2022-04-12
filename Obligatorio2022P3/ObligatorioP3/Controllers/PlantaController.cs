using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Dominio;
using DataAccess;

namespace ObligatorioP3.Controllers
{
    public class PlantaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        IRepositorio<Planta> repositorio = new RepositorioPlanta(new Connection());
        public IActionResult ListarPlanta()
        {

            return View(repositorio.Get());
        }

        public IActionResult ListarPlantaMasBajaQueXCentimetros(double miAlturaMaxima)
        {
            if(miAlturaMaxima > 0)
            {
            return View("ListarPlanta", repositorio.GetMasBajasQueXCentimetros(miAlturaMaxima));//Ver si sobreescribe sino crear una vista nueva             

            }
            return View();
        }


    }
}
