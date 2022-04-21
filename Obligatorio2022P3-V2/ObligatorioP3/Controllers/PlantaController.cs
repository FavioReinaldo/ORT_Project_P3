using Dominio;
using DataAccess;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ObligatorioP3.Models;
using Microsoft.AspNetCore.Http;
using System.IO;
using Microsoft.AspNetCore.Hosting;



namespace ObligatorioP3.Controllers
{
    public class PlantaController : Controller
    {

        private IWebHostEnvironment _environment;
        public PlantaController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
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
        public ActionResult Alta(Planta unaPlanta, IFormFile imagen)
        {
            if (unaPlanta.IsValid())
            {
                try
                {
                    GuardarImagen(imagen, unaPlanta);
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

        private bool GuardarImagen(IFormFile imagen, Planta unaPlanta)
        {
            if (imagen == null || unaPlanta == null)
                return false;
            
            string rutaFisicaWwwRoot = _environment.WebRootPath;
            
            string nombreImagen = imagen.FileName;
            string rutaFisicaFoto = Path.Combine
            (rutaFisicaWwwRoot, "imagenes", "fotosPlanta", nombreImagen);
            
            try
            {
                
                using (FileStream f = new FileStream(rutaFisicaFoto, FileMode.Create))
                {
                    
                    imagen.CopyTo(f);
                }

                unaPlanta.FotoPlanta = nombreImagen;
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }
        public IActionResult VisualisarImagen()
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


    }
}
