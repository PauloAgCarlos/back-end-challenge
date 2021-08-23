using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class LivroLivroCreateDto
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