using GameVault.Data;
using GameVault.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace GameVault.Context
{
    public class AppDbContext : IdentityDbContext<IdentityUser>
    {
        public AppDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) { }

        public DbSet<Jogo> Jogos { get; set; }
        public DbSet<Review> Reviews { get; set; }
    }
}
