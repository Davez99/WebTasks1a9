using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex03Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex03ViewModel ex03viewmodel)
        {
            ModelState.Clear();

            switch (ex03viewmodel.Operador)
            {
                case "+":
                    ex03viewmodel.Resultado = ex03viewmodel.Num1 + ex03viewmodel.Num2;
                    break;
                case "-":
                    ex03viewmodel.Resultado = ex03viewmodel.Num1 - ex03viewmodel.Num2;
                    break;
                case "*":
                    ex03viewmodel.Resultado = ex03viewmodel.Num1 * ex03viewmodel.Num2;
                    break;
                case "/":
                    ex03viewmodel.Resultado = ex03viewmodel.Num1 / ex03viewmodel.Num2;
                    break;
                default:
                    break;
            }

            return View(ex03viewmodel);
        }
    }
}
