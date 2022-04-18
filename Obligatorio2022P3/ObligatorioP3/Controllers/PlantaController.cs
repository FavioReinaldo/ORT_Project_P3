using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

<<<<<<< Updated upstream
using Dominio;
using DataAccess;

=======
>>>>>>> Stashed changes
namespace ObligatorioP3.Controllers
{
    public class PlantaController : Controller
    {
<<<<<<< Updated upstream
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
            return View(repositorio.GetMasBajasQueXCentimetros(miAlturaMaxima));             

            }
            ViewBag.Mensaje = "Los datos ingresados no son correctos";
            return View("ListarPlanta");
        }

        public IActionResult ListarPlantaDeXCentimetrosOMas(double miAlturaMinima)
        {
            if (miAlturaMinima > 0)
            {
                return View(repositorio.GetDeXCentimetrosOMas(miAlturaMinima));

            }
            ViewBag.Mensaje = "Los datos ingresados no son correctos";
            return View("ListarPlanta");
        }

        public IActionResult ListarPlantaPorAmbiente(string miAmbiente)
        {
            if (miAmbiente != null && miAmbiente != "")
            {
                return View(repositorio.GetPorAmbiente(miAmbiente));

            }
            ViewBag.Mensaje = "Los datos ingresados no son correctos";
            return View("ListarPlanta");
        }


=======
        RepositorioPlanta repositorio = new RepositorioPlanta(new Connection());
        public IActionResult Index()
        {
            return View(repositorio.Get());
        }
>>>>>>> Stashed changes
    }
}
