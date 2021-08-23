using System.Collections.Generic;
using DrCashApp.Models;
using System.Linq;
using System;

namespace DrCashApp.Data
{
    public class SqlLivroRepo : ILivroRepo
    {

        private readonly LivroContext _context;
        public SqlLivroRepo(LivroContext context)
        {
            _context = context;
        }

        public void CreateLivro(Livro cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Livros.Add(cmd);
        }

        public void DeleteLivro(Livro cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Livros.Remove(cmd);
        }

        public IEnumerable <Livro> GetAllLivros()
        {
            return _context.Livros.ToList();
        }

        public Livro GetLivroById(int id)
        {
            return _context.Livros.FirstOrDefault(p => p.Id == id);
        }
 
        public bool SaveChanges()
        {
           return (_context.SaveChanges() >=0);
        }

        public void UpdateLivro(Livro cmd)
        {
            

        }
    }
}