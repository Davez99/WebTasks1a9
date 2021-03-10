using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WbEx1a9.Models
{
    public class Ex07ViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Escreva o seu salário")]
        [Required(ErrorMessage ="Campo obrigatório")]
        public float SalarioUser { get; set; }

        public string Reajuste { get; set; }
    }
}
