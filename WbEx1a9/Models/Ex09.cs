using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WbEx1a9.Models
{
    public class Ex09ViewModel
    {
        public int Id { get; set; }

        [Display(Name ="Nome")]
        public string NomeUser { get; set; }

        [Display(Name = "Idade")]
        public int IdadeUser { get; set; }

        [Display(Name = "Peso")]
        public string PesoUser { get; set; }

        [Display(Name = "Altura")]
        public string AlturaUser { get; set; }

        [Display(Name = "Seu resultado")]
        public string SaidaUser { get; set; }

        [Display(Name = "Documento")]
        public string AvisoUser { get; set; }

        [Display(Name = "Conteúdo do documento")]
        public string ConteudoUser { get; set; }
    }
}
