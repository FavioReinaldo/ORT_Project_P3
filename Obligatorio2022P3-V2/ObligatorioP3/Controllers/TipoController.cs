using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataAccess;
using Dominio;
using ObligatorioP3.Models;
using Microsoft.AspNetCore.Http;

namespace ObligatorioP3.Controllers
{
    public class TipoController : Controller
    {
        RepositorioTipo repositorio = new RepositorioTipo(new Connection());
        Sistema unS = Sistema.Instancia;
        
        public ActionResult Index()
        {
            return View(repositorio.Get());
        }
        public ActionResult Alta()
        {

            return View(new Tipo());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Alta(Tipo unTipo)
        {
            if (unTipo.IsValid())
            {
                try
                {
                    repositorio.Insert(unTipo);
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
        public ActionResult Delete(string nombre)
        {
            Tipo unTipo = repositorio.GetByName(nombre);
            return View(unTipo);
            
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Tipo unTipo, IFormCollection collection)
        {
            try
            {
                repositorio.Delete(unTipo.Nombre);
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View("Error", new Models.ErrorViewModel());
            }
        }

        public ActionResult Edit(string nombre)
        {
            Tipo unTipo = repositorio.GetByName(nombre);
            return View(unTipo);
        }

        
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Tipo unTipo)
        {
            if (unTipo.IsValid())
            {
                try
                {
                    repositorio.Update(unTipo);
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


    }
}
