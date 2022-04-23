﻿using Dominio;
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
        RepositorioPlanta repositorio = new RepositorioPlanta(new Connection());
        RepositorioTipo repositorio1 = new RepositorioTipo(new Connection());

        private IWebHostEnvironment _environment;
        public PlantaController(IWebHostEnvironment environment)
        {
            _environment = environment;
        }
        public IActionResult Index()
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        public IActionResult Alta()
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {
                ViewBag.Tipos = repositorio1.Get();
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alta(Planta unaPlanta, IFormFile imagen)
        {                     
            if (HttpContext.Session.GetString("Mail") != null)
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
            else
            {
                return RedirectToAction("Login", "Home");
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
            catch (Exception)
            {
                return false;
            }
        }
        public IActionResult VisualisarImagen()
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {

                return View();
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
        }

        
        public IActionResult ListarPlanta()
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {

                return View(repositorio.Get());
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }            
        }

        public IActionResult ListarPlantaMasBajaQueXCentimetros(double miAlturaMaxima)
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {

                if (miAlturaMaxima > 0)
                {
                    return View(repositorio.GetMasBajasQueXCentimetros(miAlturaMaxima));

                }
                ViewBag.Mensaje = "Los datos ingresados no son correctos";
                return View("ListarPlanta");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            
        }

        public IActionResult ListarPlantaDeXCentimetrosOMas(double miAlturaMinima)
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {

                if (miAlturaMinima > 0)
                {
                    return View(repositorio.GetDeXCentimetrosOMas(miAlturaMinima));

                }
                ViewBag.Mensaje = "Los datos ingresados no son correctos";
                return View("ListarPlanta");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
           
        }

        public IActionResult ListarPlantaPorAmbiente(string miAmbiente)
        {
            if (HttpContext.Session.GetString("Mail") != null)
            {

                if (miAmbiente != null && miAmbiente != "")
                {
                    return View(repositorio.GetPorAmbiente(miAmbiente));

                }
                ViewBag.Mensaje = "Los datos ingresados no son correctos";
                return View("ListarPlanta");
            }
            else
            {
                return RedirectToAction("Login", "Home");
            }
            
        }


    }
}
