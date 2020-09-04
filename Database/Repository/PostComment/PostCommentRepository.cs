using System;
using System.Linq;
using System.Threading.Tasks;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository
{
    public class PostCommentRepository : IPostCommentRepository
    {
        private readonly FoguerAppDbContext _context;

        public PostCommentRepository(FoguerAppDbContext context)
        {
            _context = context;
        }

        public Task<PostComment> GetOne(int id)
        {
            return _context.PostComment.Where(p => p.Id == id)
                .AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public void Create(PostComment entrada)
        {
            _context.PostComment.Add(entrada);
            _context.SaveChanges();
        }

        public Task<PostComment> Update(PostComment comentario, PostComment dto)
        {
            comentario.Text = dto.Text;
            comentario.UpdateDate = dto.UpdateDate;
            _context.Update(comentario);
            _context.SaveChanges();

            return _context.PostComment.Where(p => p.Id == comentario.Id).AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public void Delete(PostComment comentario)
        {
            _context.Remove(comentario);
            _context.SaveChanges();
        }
    }
}
