using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class GeneroUpdateDto
    {
        [Required]
        [MaxLength(250)]
        public string Nome {get;set;}
 
    }
}