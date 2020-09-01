using System.Linq;
using System.Threading.Tasks;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository
{
    public class PostRepository : IPostRepository
    {
        private readonly FoguerAppDbContext _context;

        public PostRepository(FoguerAppDbContext context)
        {
            _context = context;
        }

        public IQueryable<Post> GetAll()
        {
            return _context.Post
                .AsNoTracking();
        }

        public Task<Post> GetOne(int id)
        {
            return _context.Post.Where(p => p.Id == id)
                .Include(p => p.Comments)
                .AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public IQueryable<PostComment> GetComentarios(int id)
        {
            return _context.PostComment
                .Where(pc => pc.PostId == id)
                .AsNoTracking();
        }

        public void Create(Post entrada)
        {
            _context.Post.Add(entrada);
            _context.SaveChanges();
        }

        public Task<Post> Update(Post anuncio, Post dto)
        {
            anuncio.Title = dto.Title;
            anuncio.Subtitle = dto.Subtitle;
            anuncio.Text = dto.Text;
            _context.Update(anuncio);
            _context.SaveChanges();

            return _context.Post.Where(p => p.Id == anuncio.Id).AsNoTracking().FirstOrDefaultAsync(); ;
        }

        public void Delete(Post anuncio)
        {
            _context.Remove(anuncio);
            _context.SaveChanges();
        }
    }
}
