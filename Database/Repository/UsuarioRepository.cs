using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
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

        public IQueryable<Role> Get()
        {
            return _context.User.AsNoTracking();
        }

        
    }
}
