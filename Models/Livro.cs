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

        public Autor Autor { get; set; }

        [Required]
        public int AutorId { get; set; }

        public Genero Genero { get; set; }

        [Required]
        public int GeneroId { get; set; }


        [Required]
        public string QuantCopias {get;set;}


        
    }
}