using GameVault.Data;
using GameVault.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options) { }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Review> Reviews { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // Configurar relacionamentos aqui (ex.: Jogo ↔ Review)
            modelBuilder.Entity<Jogo>()
                .HasOne(j => j.Review)
                .WithOne(r => r.Jogo)
                .HasForeignKey<Review>(r => r.JogoId);
        }
    }
}
