using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex02Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex02viewmodel ex02viewmodel)
        {
            ModelState.Clear();

            var x = ex02viewmodel.Pergunta;

            ex02viewmodel.RespostaEx2 = $"Seu nome é: {x}";

            return View(ex02viewmodel);
        }
    }
}
