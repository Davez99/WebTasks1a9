using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WbEx1a9.Models
{
    public class Ex05ViewModel
    {
        public int Id { get; set; }

        [Display(Name="Escreva o seu nome para sair na tela:")]
        public string EntradaUser { get; set; }

        [Display(Name = "Resultado:")]
        public string SaidaUser { get; set; }
    }
}
