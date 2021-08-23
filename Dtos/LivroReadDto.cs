using System.ComponentModel.DataAnnotations;

namespace DrCashApp.Dtos
{
    public class LivroReadDto
    {
        
        public int Id {get;set;}
       
        public string Produto {get;set;}

    
        public string Quantidade {get;set;}
        public string Fornecedor {get;set;}

    
        
    }
}