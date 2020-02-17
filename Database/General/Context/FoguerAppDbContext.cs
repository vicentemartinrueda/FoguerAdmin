using System;
using Database.General.Models;
using Database.General.Configuration;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database.General.Context
{
    public partial class FoguerAppDbContext : DbContext
    {
        public FoguerAppDbContext()
        {
        }

        public FoguerAppDbContext(DbContextOptions<FoguerAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Usuario> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
         
            modelBuilder.ApplyConfiguration(new UsuarioConfiguration());
           
        }
    }
}
