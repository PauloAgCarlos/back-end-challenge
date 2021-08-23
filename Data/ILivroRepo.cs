using System.Collections.Generic;
using DrCashApp.Models;

namespace DrCashApp.Data
{
    public interface ILivroRepo
    {
        bool SaveChanges();

        IEnumerable<Livro> GetAllLivros();
        Livro GetLivroById(int id); 
        void CreateLivro(Livro cmd);
        void UpdateLivro(Livro cmd);
        void DeleteLivro(Livro cmd);

    }
}