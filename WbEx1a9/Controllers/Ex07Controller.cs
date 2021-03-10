using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex07Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Ex07ViewModel ex07viewmodel)
        {
            ModelState.Clear();

            float x, y, z;

            x = ex07viewmodel.SalarioUser;

            if (x >= 1700)
            {
                y = x + 200;
                ex07viewmodel.Reajuste = $"Seu reajuste ficou em {y}";
                
            }
            else if (x <= 1699)
            {
                z = x + 300;
                ex07viewmodel.Reajuste = $"Seu reajuste ficou em {z}";
            }

            return View(ex07viewmodel);
        }
    }
}
