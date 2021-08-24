using System.Collections.Generic;
using DrCashApp.Models;
using DrCashApp.Data;
using System;

namespace DrCashApp.Data
{
    public class MockLivroRepo : ILivroRepo
    {

        public void CreateLivro(Livro cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteLivro(Livro cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Livro> GetAllLivros()
        {
            var livros = new List<Livro>
            {
                //  new Livro { Id = 0, Titulo = "Livro", Autor="Autor", Genero="Genero", QuantCopias="Genero"},
                //  new Livro { Id = 1, Titulo = "Livro 1", Autor="Autor 1", Genero="Genero 1", QuantCopias="Genero"},
                //  new Livro { Id = 2, Titulo = "Livro", Autor="Autor 2", Genero="Genero 2", QuantCopias="Genero"} 

            };

            return livros;
        }

       
        public Livro GetLivroById(int id)
        {
            return new Livro { Id = 0, Titulo = "NomeLivro", AutorId=1, GeneroId=1, QuantCopias="Genero"}; 
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

       
        public void UpdateLivro(Livro cmd)
        {
            throw new NotImplementedException();
        }
    }
}