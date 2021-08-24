using System.Collections.Generic;
using DrCashApp.Models;
using System.Linq;
using System;

namespace DrCashApp.Data
{
    public class SqlGeneroRepo : IGeneroRepo
    {

        private readonly LivroContext _context;
        public SqlGeneroRepo(LivroContext context)
        {
            _context = context;
        }

        public void CreateGenero(Genero cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Generos.Add(cmd);
        }

        public void DeleteGenero(Genero cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Generos.Remove(cmd);
        }

        public IEnumerable <Genero> GetAllGeneros()
        {
            return _context.Generos.ToList();
        }

        public Genero GetGeneroById(int id)
        {
            return _context.Generos.FirstOrDefault(p => p.Id == id);
        }
 
        public bool SaveChanges()
        {
           return (_context.SaveChanges() >=0);
        }

        public void UpdateGenero(Genero cmd)
        {
            

        }
    }
}