using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Models
{
    public class Livro
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(250)]
        public string Produto {get;set;}

        [Required]
        public string Quantidade {get;set;}

        [Required]
        public string Fornecedor {get;set;}
    }
}