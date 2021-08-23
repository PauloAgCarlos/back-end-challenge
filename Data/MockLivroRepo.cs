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
                 new Livro { Id = 0, Produto = "Livro", Quantidade="Linha", Fornecedor="Plataforma"},
                 new Livro { Id = 1, Produto = "Livro 1", Quantidade="Linha 1", Fornecedor="Plataforma 1"},
                 new Livro { Id = 2, Produto = "Livro", Quantidade="Linha 2", Fornecedor="Plataforma 2"} 

            };

            return livros;
        }

       
        public Livro GetLivroById(int id)
        {
            return new Livro { Id = 0, Produto = "NomeLivro", Quantidade="Linha", Fornecedor="Plataforma"}; 
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