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
                 new Autor { Id = 0, Nome = "Autor", Morada="Autor", Telefone="Genero"},
                 new Autor { Id = 1, Nome = "Autor 1", Morada="Autor 1", Telefone="Genero 1"},
                 new Autor { Id = 2, Nome = "Autor", Morada="Autor 2", Telefone="Genero 2"} 

            };

            return autores;
        }

       
        public Autor GetAutorById(int id)
        {
            return new Autor { Id = 0, Nome = "NomeAutor", Morada="Autor", Telefone="Genero"}; 
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