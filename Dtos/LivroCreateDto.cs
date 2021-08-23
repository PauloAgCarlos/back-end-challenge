using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class LivroCreateDto
    {
        [Required]
        [MaxLength(250)]
        public string Produto {get;set;}

        [Required]
        public string Quantidade {get;set;}

        [Required]
        public string Fornecedor {get;set;}

         
    }
}