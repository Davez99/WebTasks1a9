using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex05Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex05ViewModel ex05viewmodel)
        {

            ex05viewmodel.SaidaUser = RetornoNomeUser(ex05viewmodel.EntradaUser);
            
            return View(ex05viewmodel);
        }

        private static string RetornoNomeUser(string nome)
        {
            nome = $"Olá meu nome é  {nome}"; 
            return nome;
        }
    }
}
