using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using Dominio;
using DataAccess;

namespace ObligatorioP3.Controllers
{
    public class TipoController : Controller  
    {
        RepositorioTipo repositorio = new RepositorioTipo(new Connection());
        Sistema unS = Sistema.Instancia;
        

        public string Nombre { get; private set; }

        public IActionResult Index()
        {
            return View(repositorio.Get());
        }
        public IActionResult Alta()
        {
            return View(new Tipo());
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Alta(Tipo unTipo)
        {
            
            
                Tipo unTipo = new Tipo();
                unTipo.Nombre = collection["Nombre"];
                unTipo.Descripcion = collection["Descripcion"];
                
              repositorio.Insert(unTipo);
                
            
            return View();

        }
        public IActionResult Eliminar(string nombre)
        {
            return View();
        }

    }
}
