using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex09Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex09ViewModel ex09viewmodel)
        {
            //Declaralçao de variáveis 
            var nome = ex09viewmodel.NomeUser;
            var idade = ex09viewmodel.IdadeUser;
            float peso = float.Parse(ex09viewmodel.PesoUser);
            float altura = float.Parse(ex09viewmodel.AlturaUser);

            //Lógica do IMC
            float imc = peso / (altura * altura);

            if (imc <= 18.5)
            {
                ex09viewmodel.SaidaUser = "Você esta abaixo do peso!";
            }
            else if ((imc <= 24.9) && (imc >= 18.5))
            {
                ex09viewmodel.SaidaUser = "Parabéns seu peso esta normal!";
            }
            else if ((imc <= 29.9) && (imc >= 25))
            {
                ex09viewmodel.SaidaUser = "Você esta acima do peso!";
            }
            else if ((imc <= 34.9) && (imc >= 30))
            {
                ex09viewmodel.SaidaUser = "Você esta com obesidade nível I !";
            }
            else if ((imc <= 39.9) && (imc >= 35))
            {
                ex09viewmodel.SaidaUser = "Você esta com obesidade nível II !";
            }
            else
            {
                ex09viewmodel.SaidaUser = "Você esta com obesidade nível III !";
            }

            //Lógica de criação de documento de texto
            StreamWriter Gravar = new StreamWriter("Exercicio9.txt");

            Gravar.WriteLine($"Nome: {nome}");
            Gravar.WriteLine($"Idade: {idade}");
            Gravar.WriteLine($"Peso: {peso}");
            Gravar.WriteLine($"Altura: {altura}");
            Gravar.WriteLine($"IMC: {imc}");

            Gravar.Close();

            //Aviso que foi criado o documento de texto
            ex09viewmodel.AvisoUser = "Documento Criado!";

            //Leitor do conteúdo que esta dentro do arquivo de texto
            string Leitura = System.IO.File.ReadAllText("..\\WbEx1a9\\Exercicio9.txt");

            ex09viewmodel.ConteudoUser = Leitura;

            return View(ex09viewmodel);
        }
    }
}
