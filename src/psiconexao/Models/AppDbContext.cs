using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using psiconexao.Models;

namespace psiconexao.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Psicologo> Psicologos { get; set; }
        public DbSet<Disponibilidade> Disponibilidades { get; set; }
        public DbSet<Paciente> Pacientes { get; set; }
        public DbSet<Consulta> Consultas { get; set; }

        //Para executar tabelas de herança separadas (TPT ao invés de TPH)
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Usuario>().ToTable("Usuarios");
            modelBuilder.Entity<Psicologo>().ToTable("Psicologos");

            //Config para que as Fk do modelo Consultas não cause múltiplos caminhos de cascata

            modelBuilder.Entity<Consulta>()
               .HasOne(c => c.Psicologo)
               .WithMany(p => p.Consultas)
               .HasForeignKey(c => c.PsicologoId)
               .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Consulta>()
                .HasOne(c => c.Paciente)
                .WithMany(p => p.Consultas)
                .HasForeignKey(c => c.PacienteId)
                .OnDelete(DeleteBehavior.Cascade);
        }

    }

}