using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Proyecto10AbrilBack.Models;
using ProyectoCore10AbrilBack.Models;

namespace Proyecto10AbrilBack.Data
{
    public class ApplicationDbContext : IdentityDbContext
        //
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<Abonado> Abonados { get; set; }
        public DbSet<Categoria> Categorias { get; set; }
        public DbSet<CuerpoTecnico> CuerpoTecnicos { get; set; }
        public DbSet<Gasto> Gastos { get; set; }
        public DbSet<Jugador> Jugadores { get; set; }
        public DbSet<Producto> Productos { get; set; }

        public DbSet <Partido> Partido { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
            base.OnModelCreating(modelBuilder);
        }
    }
}
