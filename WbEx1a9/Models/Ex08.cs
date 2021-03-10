using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WbEx1a9.Models
{
    public class Ex08ViewModel
    {
        public int Id { get; set; }

        [Display(Name = "Nome")]
        public string ReceberNome { get; set; }

        [Display(Name = "E-mail")]
        public string ReceberEmail { get; set; }

        [Display(Name = "RG ou CPF")]
        public string ReceberRG { get; set; }

        [Display(Name = "Documento")]
        public string ResponderAoUser { get; set; }

        [Display(Name = "Conteúdo no documento")]
        public string MostrarAoUser { get; set; }

    }
}
