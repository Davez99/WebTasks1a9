using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex08Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(Ex08ViewModel ex08viewmodel)
        {
            ModelState.Clear();
            //Criado variáveis para receber os dados do user
            string x, y, z;

            x = ex08viewmodel.ReceberNome;
            y = ex08viewmodel.ReceberEmail;
            z = ex08viewmodel.ReceberRG;

            //Feito uma instancia para criar um arquivo .txt, usando o System.IO
            StreamWriter maquinaDeEscrever = new StreamWriter("Exercicio8.txt");

            //Atribuindo os valores a instancia criada
            maquinaDeEscrever.WriteLine(x); 
            maquinaDeEscrever.WriteLine(y);
            maquinaDeEscrever.WriteLine(z);

            //Fechando a instancia, pois se não o fizer, não recebe os dados do user
            maquinaDeEscrever.Close();

            // Retornando um aviso para o user, informando que já foi criado o .txt
            ex08viewmodel.ResponderAoUser = "Foi criado o arquivo .txt";

            string Leitura = System.IO.File.ReadAllText("..\\WbEx1a9\\Exercicio8.txt");

            ex08viewmodel.MostrarAoUser = Leitura;

            return View(ex08viewmodel);
        }


    }
}
