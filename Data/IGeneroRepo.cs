using System.Collections.Generic;
using DrCashApp.Models;

namespace DrCashApp.Data
{
    public interface IGeneroRepo
    {
        bool SaveChanges();

        IEnumerable<Genero> GetAllGeneros();
        Genero GetGeneroById(int id); 
        void CreateGenero(Genero cmd);
        void UpdateGenero(Genero cmd);
        void DeleteGenero(Genero cmd);

    }
}