using System.Collections.Generic;
using DrCashApp.Models;
using System.Linq;
using System;

namespace DrCashApp.Data
{
    public class SqlAutorRepo : IAutorRepo
    {

        private readonly LivroContext _context;
        public SqlAutorRepo(LivroContext context)
        {
            _context = context;
        }

        public void CreateAutor(Autor cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Autores.Add(cmd);
        }

        public void DeleteAutor(Autor cmd)
        {
            if(cmd == null)
            {
                throw new ArgumentNullException(nameof(cmd));
            }

            _context.Autores.Remove(cmd);
        }

        public IEnumerable <Autor> GetAllAutores()
        {
            return _context.Autores.ToList();
        }

        public Autor GetAutorById(int id)
        {
            return _context.Autores.FirstOrDefault(p => p.Id == id);
        }
 
        public bool SaveChanges()
        {
           return (_context.SaveChanges() >=0);
        }

        public void UpdateAutor(Autor cmd)
        {
            

        }
    }
}