using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ContadorBasquete.Models;
using ContadorBasquete.Repositorios;

namespace ContadorBasquete.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult LancarPontos(LancarPontos lancarPontos)
        {
            if (ModelState.IsValid && lancarPontos.Pontos != 0)
            {
                var repositorio = new Repositorio();
                repositorio.Lancar(lancarPontos);
                return RedirectToAction(nameof(Relatorio));
            }
            else
            {
                return View(lancarPontos);
            }
            
        }
        public IActionResult Relatorio()
        {
            var repositorio = new Repositorio();
            var lista = repositorio.ListarPontos();
            return View(lista);
        }

        public IActionResult Todos()
        {
            var repositorio = new Repositorio();
            var lista = repositorio.ListarPontos();
            return View(lista);
        }

        public IActionResult Index()
        {

            return View();
        }
    }
}
