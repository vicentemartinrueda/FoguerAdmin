using Database.General.Models;
using Microsoft.EntityFrameworkCore;
using System;

namespace Database.General.Context
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            Role role1 = new Role
            {
                Id = 1,
                Name = "User",
                Priority = 10,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            Role role2 = new Role
            {
                Id = 2,
                Name = "Manager",
                Priority = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<Role>().HasData(role1, role2);

            User user1 = new User
            {
                Id= 1,
                UserName = "santofrost",
                Name = "Vicente",
                Surname = "Martín Rueda",
                Nif = "53244606C",
                Activated = true,
                ReleaseDate = DateTime.Now,
                RoleId = 2,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };
            User user2 = new User
            {
                Id = 2,
                UserName = "user2",
                Name = "Felipe",
                Surname = "Del Real Gama",
                Nif = "12345678Z",
                Activated = true,
                ReleaseDate = DateTime.Now,
                RoleId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<User>().HasData(user1, user2);

            Post post1 = new Post
            {
                Id = 1,
                Title = "Título 1",
                Subtitle = "Subtítulo 1",
                Text = "Texto 1",
                CreatorId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };

            Post post2 = new Post
            {
                Id = 2,
                Title = "Título 2",
                Subtitle = "Subtítulo 2",
                Text = "Texto 2",
                CreatorId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<Post>().HasData(post1, post2);

            PostComment pc1 = new PostComment
            {
                Id = 1,
                Text = "Genial Post",
                CreatorId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };

            PostComment pc2 = new PostComment
            {
                Id = 2,
                Text = "Fantástico Post",
                CreatorId = 2,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<PostComment>().HasData(pc1, pc2);

            Proposal proposal1 = new Proposal
            {
                Id = 1,
                Title = "Color de las camisetas",
                Subtitle = "Subtítulo 1",
                Text = "Texto 1",
                CreatorId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };

            Proposal proposal2 = new Proposal
            {
                Id = 2,
                Title = "Título 2",
                Subtitle = "Subtítulo 2",
                Text = "Texto 2",
                CreatorId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<Proposal>().HasData(proposal1, proposal2);

            ProposalComment proposalComment1 = new ProposalComment
            {
                Id = 1,
                Text = "Genial Proposal",
                CreatorId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };

            ProposalComment proposalComment2 = new ProposalComment
            {
                Id = 2,
                Text = "Fantástico Proposal",
                CreatorId = 2,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<ProposalComment>().HasData(proposalComment1, proposalComment2);

            ProposalOption proposalOption1 = new ProposalOption
            {
                Id = 1,
                Text = "Rosa",
                ProposalId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now,
            };

            ProposalOption proposalOption2 = new ProposalOption
            {
                Id = 2,
                Text = "Azul",
                ProposalId = 1,
                CreationDate = DateTime.Now,
                UpdateDate = DateTime.Now
            };

            modelBuilder.Entity<ProposalOption>().HasData(proposalOption1, proposalOption2);
        }
    }
}
