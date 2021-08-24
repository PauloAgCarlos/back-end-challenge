using System.Collections.Generic;
using DrCashApp.Models;
using DrCashApp.Data;
using System;

namespace DrCashApp.Data
{
    public class MockAutorRepo : IAutorRepo
    {

        public void CreateAutor(Autor cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteAutor(Autor cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Autor> GetAllAutores()
        {
            var autores = new List<Autor>
            {
                 new Autor { Id = 0, Titulo = "Autor", Autor="Autor", Genero="Genero", QuantCopias="Genero"},
                 new Autor { Id = 1, Titulo = "Autor 1", Autor="Autor 1", Genero="Genero 1", QuantCopias="Genero"},
                 new Autor { Id = 2, Titulo = "Autor", Autor="Autor 2", Genero="Genero 2", QuantCopias="Genero"} 

            };

            return autores;
        }

       
        public Autor GetAutorById(int id)
        {
            return new Autor { Id = 0, Titulo = "NomeAutor", Autor="Autor", Genero="Genero", QuantCopias="Genero"}; 
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

       
        public void UpdateAutor(Autor cmd)
        {
            throw new NotImplementedException();
        }
    }
}