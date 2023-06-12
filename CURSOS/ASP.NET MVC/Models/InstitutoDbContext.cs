using System.Collections.Generic;
using System.Data.Entity;

namespace ASP_.NET_MVC.Models
{
    public class InstitutoDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Curso> Cursos { get; set; }
        public DbSet<Institucion> Instituciones { get; set; }
        // Otros DbSet para otros modelos, si los tienes

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configuraciones adicionales, si las necesitas
        }
    }
}