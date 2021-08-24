using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Models
{
    public class Genero
    {
        [Key]
        public int Id {get;set;}
        [Required]
        [MaxLength(250)]
        public string Nome {get;set;}
 
    }
}