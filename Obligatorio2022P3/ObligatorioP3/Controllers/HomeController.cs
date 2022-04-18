using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ObligatorioP3.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.AspNetCore.Http;
using Dominio;
using DataAccess;

namespace ObligatorioP3.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        public IActionResult Login()
        {
            return View(); 
        }


        IRepositorio<Usuario> repositorio = new RepositorioUsuario(new Connection());


        public IActionResult VerificacionLogin(string mail, string password)
        {
            if (mail != null && password != null && mail != "" && password != "" && Sistema.Instancia.ValidarLogIn(mail, password))
            {
                    //repositorio.GetUsuario(mail, password);       //No se como guardar y validar de aca el mail y el password en variables para trabajar con ellos
                    HttpContext.Session.SetString("Mail", mail);   
                    return RedirectToAction("Index", "Home");
            }
            else
            {
                ViewBag.Mensaje = "Los datos ingresados no son correctos";
            }
            return View("Login");
        }

        public IActionResult CerrarSesion()
        {
            HttpContext.Session.Remove("Mail");            
            return View("Login");
        }
    }
}
