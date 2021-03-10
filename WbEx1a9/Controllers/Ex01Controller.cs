using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex01Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex01ViewModel ex01viewmodel)
        {
            ModelState.Clear();

            int x = ex01viewmodel.ReceberNumero;

            if (x % 2 == 0)
            {
                ex01viewmodel.Resposta = "Seu número é *** PAR ***";
            }
            else
            {
                ex01viewmodel.Resposta = "Seu número é *** IMPAR ***";
            }
            return View(ex01viewmodel);
        }
    }
}
