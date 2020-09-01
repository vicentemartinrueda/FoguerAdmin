using Database.General.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using System.Linq;

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
        public virtual DbSet<PostComment> PostComment { get; set; }
        public virtual DbSet<Proposal> Proposal { get; set; }
        public virtual DbSet<ProposalOption> ProposalOption { get; set; }
        public virtual DbSet<ProposalComment> ProposalComment { get; set; }
        public virtual DbSet<SharedFile> SharedFile { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Seed();
        }
    }
}
