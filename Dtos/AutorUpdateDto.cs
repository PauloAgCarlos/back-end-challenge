using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class AutorUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Nome {get;set;}

        [Required]
        public string Morada {get;set;}

        [Required]
        public string Telefone {get;set;}
        
    }
}