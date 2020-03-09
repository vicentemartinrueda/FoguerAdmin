using Database.General.Models;
using Microsoft.EntityFrameworkCore;

namespace Database.General.Context
{
    public partial class FoguerAppDbContext : DbContext
    {
        public FoguerAppDbContext(DbContextOptions<FoguerAppDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Role> Role { get; set; }
        public virtual DbSet<User> User { get; set; }
        public virtual DbSet<Post> Post { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
