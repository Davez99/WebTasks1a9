using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WbEx1a9.Models;

namespace WbEx1a9.Controllers
{
    public class Ex06Controller : Controller
    {
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Index(Ex06ViewModel ex06viewmodel)
        {
            ModelState.Clear();
            /* Criado uma variavel "texto" para a propriedade "EntradaTexto" que vem da Model Ex06
             * Na sequência feito um Array char com tamanho 200 e identificando ele como "letra"
             * Atribuindo para "letra" o "texto" no formato array
             * Feito o primeiro loop com "for" para ler e fragmentar a palavra em caracteres
             * Dentro do for feito mais um loop com while para que fosse identificado entre os caracteres o "a"
             * Com a substituição do "a" para "&" retornando para o "letra"
             * Finalizando com a transformação da "letra" que é um array para uma nova string, possibilitando levar as informações na tela através de um tipo.
             */

            var texto = ex06viewmodel.EntradaTexto;

            char[] letra = new char[200];
            letra = texto.ToCharArray();


            for (int i = 0; i < letra.Length; i++)
            {
                while (letra[i] == 'a')
                {
                    letra[i] = '&';
                }
            }

            String letraModificada = new string(letra);

            ex06viewmodel.SaidaTexto = letraModificada;

            return View(ex06viewmodel);
        }
    }
}
