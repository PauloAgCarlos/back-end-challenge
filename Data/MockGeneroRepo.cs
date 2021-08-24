using System.Collections.Generic;
using DrCashApp.Models;
using DrCashApp.Data;
using System;

namespace DrCashApp.Data
{
    public class MockGeneroRepo : IGeneroRepo
    {

        public void CreateGenero(Genero cmd)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteGenero(Genero cmd)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Genero> GetAllGeneros()
        {
            var generos = new List<Genero>
            {
                 new Genero { Id = 0, Nome = "generos"},
                 new Genero { Id = 1, Nome = "generos 1"},
                 new Genero { Id = 2, Nome = "generos 2"} 

            };

            return generos;
        }

       
        public Genero GetGeneroById(int id)
        {
            return new Genero { Id = 0, Nome = "NomeGenero"}; 
        }

        public bool SaveChanges()
        {
            throw new NotImplementedException();
        }

       
        public void UpdateGenero(Genero cmd)
        {
            throw new NotImplementedException();
        }
    }
}