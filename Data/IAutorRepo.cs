using System.Collections.Generic;
using DrCashApp.Models;

namespace DrCashApp.Data
{
    public interface IAutorRepo
    {
        bool SaveChanges();

        IEnumerable<Autor> GetAllAutores();
        Autor GetAutorById(int id); 
        void CreateAutor(Autor cmd);
        void UpdateAutor(Autor cmd);
        void DeleteAutor(Autor cmd);

    }
}