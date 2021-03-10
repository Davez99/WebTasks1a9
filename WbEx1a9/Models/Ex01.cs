using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WbEx1a9.Models
{
    public class Ex01ViewModel 
    {
        public int Id { get; set; }

        // Interação com o usuário 
        [Required(ErrorMessage = "Esse campo é obrigatório.")]
        [Display(Name="Escreva um número")]
        public int ReceberNumero { get; set; }
        
        // Resposta para o Usuário 
        public string Resposta { get; set; }
    }
}
