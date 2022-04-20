using Dominio;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioP3.Models;

namespace ObligatorioP3.Controllers
{
    public class PlantaController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Alta()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alta(Planta unaPlanta)
        {
            if (unaPlanta.IsValid())
            {
                try
                {
                    repositorio.Insert(unaPlanta);
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    return View("Error", new ErrorViewModel());
                }
            }
            else
            {
                return View(new Models.ErrorViewModel());
            }


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


    }
}
