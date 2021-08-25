using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class LivroUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Titulo {get;set;}

        [Required]
        public int AutorId {get;set;}

        [Required]
        public int GeneroId {get;set;}

        [Required]
        public string QuantCopias {get;set;}
        
    }
}