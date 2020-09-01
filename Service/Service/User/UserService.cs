using AutoMapper;
using AutoMapper.QueryableExtensions;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Service.Service
{
    public class UserService : IUserService
    {
        private readonly FoguerAppDbContext _context;
        private readonly IUserRepository _repository;
        private readonly IMapper _mapper;
        public UserService(FoguerAppDbContext context, IUserRepository usuarioRepository, IMapper mapper) 
        {
            _context = context;
            _repository = usuarioRepository ?? throw new ArgumentNullException(nameof(usuarioRepository));
            _mapper = mapper;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoUser>> Get() 
        {
            List<User> query = await _repository.GetAll().ToListAsync();
            List<DtoUser> usuarios = _mapper.Map<List<DtoUser>>(query);
                //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
                //.ToListAsync();
            return usuarios;
        }
    }
}
