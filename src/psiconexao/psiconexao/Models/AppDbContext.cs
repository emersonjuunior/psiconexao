using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace psiconexao.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Psicologo> Psicologos { get; set; }

        //Para executar tabelas de herança separadas (TPT ao invés de TPH)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Psicologo>().ToTable("Psicologos");
        }

    }

}