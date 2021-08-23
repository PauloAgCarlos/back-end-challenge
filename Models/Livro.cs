using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Models
{
    public class Livro
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(250)]
        public string Titulo {get;set;}

        [Required]
        public string Autor {get;set;}

        [Required]
        public string Genero {get;set;}

        [Required]
        public string QuantCopias {get;set;}


        
    }
}