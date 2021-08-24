using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Models
{
    public class Autor
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(250)]
        public string Nome {get;set;}

        [Required]
        public string Morada {get;set;}

        [Required]
        public string Telefone {get;set;}


        
    }
}