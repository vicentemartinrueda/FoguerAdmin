using System.Linq;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace Database.Repository
{
    public class UsuarioRepository : IUsuarioRepository
    {
        private readonly FoguerAppDbContext _context;

        public UsuarioRepository(FoguerAppDbContext context)
        {
            _context = context;
        }

        public IQueryable<User> Get()
        {
            return _context.User
                .Include(u => u.Role)
                .Include(u => u.Posts)
                .AsNoTracking();
        }
        public IQueryable<Role> Get1()
        {
            return _context.Role
                .Include(u => u.Users)
                .AsNoTracking();
        }


    }
}
