using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
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
        [HttpPost("api/ParImpar")]
        public JsonResult ParImpar(string entrada)
        {
            var parimpar = new List<string>();

            for (int i = 1; i <= 1; i++)
            {
                try
                {
                    int x;
                    x = Convert.ToInt32(entrada);

                    const string v = "Numero é par";
                    const string z = "Numero é impar";


                    if (x % 2 == 0)
                    {
                        parimpar.Add(string.Concat(v));
                    }
                    else
                    {
                        parimpar.Add(string.Concat(z));
                    }
                }
                catch (SystemException)
                {
                    parimpar.Add(string.Concat("Somente Numeros"));
                }
                
            }

            return Json(parimpar);
        }

    }
}
