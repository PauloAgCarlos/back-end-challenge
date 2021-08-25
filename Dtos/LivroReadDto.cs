using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class LivroReadDto
    {
        
        public int Id {get;set;}
       
        public string Titulo {get;set;}

    
        public int AutorId {get;set;}
        public int GeneroId {get;set;}
        public string QuantCopias {get;set;}

    
        
    }
}