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
                 new Genero { Id = 0, Titulo = "generos", Autor="Autor", Genero="Genero", QuantCopias="Genero"},
                 new Genero { Id = 1, Titulo = "generos 1", Autor="Autor 1", Genero="Genero 1", QuantCopias="Genero"},
                 new Genero { Id = 2, Titulo = "generos", Autor="Autor 2", Genero="Genero 2", QuantCopias="Genero"} 

            };

            return generos;
        }

       
        public Genero GetGeneroById(int id)
        {
            return new Genero { Id = 0, Titulo = "NomeGenero", Autor="Autor", Genero="Genero", QuantCopias="Genero"}; 
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