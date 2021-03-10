using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WbEx1a9.Models
{
    public class Ex06ViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Escreva uma frase:")]
        public string EntradaTexto { get; set; }

        [Display(Name = "Resultado")]
        public string SaidaTexto { get; set; }

    }
}
