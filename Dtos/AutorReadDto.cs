using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class AutorReadDto
    {
        
        public int Id {get;set;}
       
        public string Titulo {get;set;}

    
        public string Autor {get;set;}
        public string Genero {get;set;}
        public string QuantCopias {get;set;}

    
        
    }
}