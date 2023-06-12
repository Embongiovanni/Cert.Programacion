using ASP_.NET_MVC.Models;
using Microsoft.EntityFrameworkCore;

namespace ASP_.NET_MVC.Data
{
    public class InstitutoDbContext : DbContext
    {
        public InstitutoDbContext(DbContextOptions options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Institucion> Instituciones { get; set; }

    }
}
