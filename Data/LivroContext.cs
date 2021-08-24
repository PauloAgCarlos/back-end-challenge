using Microsoft.EntityFrameworkCore;
using DrCashApp.Models;

namespace DrCashApp.Data
{
    public class LivroContext : DbContext
    {
        public LivroContext(DbContextOptions<LivroContext> opt) : base(opt)
        {
            
        }

        public DbSet<Livro> Livros {get;set;}
        public DbSet<Genero> Generos {get;set;}
        public DbSet<Autor> Autores {get;set;}
    }
}