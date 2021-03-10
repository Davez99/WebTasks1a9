using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex04Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex04ViewModel ex04viewmodel)
        {
            ModelState.Clear();

            var x = ex04viewmodel.IdadeEntrada;
            

            if (x >= 18)
            {
                ViewBag._concedido = "Concedido";
                ex04viewmodel.IdadeSaida = "Permissão concedida!";
            }
            else
            {
                ViewBag._concedido = "Denegrido";
                ex04viewmodel.IdadeSaida = "Permissão negada!";
            }

            return View(ex04viewmodel);
        }
    }
}
