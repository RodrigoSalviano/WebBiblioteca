using Microsoft.EntityFrameworkCore;

namespace WebBiblioteca.Models
{
    public class Contexto:DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options)
        {
        }
        public DbSet<Livros> Livros { get; set; }
        public DbSet<Autores> Autores { get; set; }
        public DbSet<Editora> Editora { get; set; }
    }
}
