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
    public class PostService : IPostService
    {
        private readonly FoguerAppDbContext _context;
        private readonly IPostRepository _repository;
        private readonly IMapper _mapper;
        public PostService(FoguerAppDbContext context, IPostRepository postRepository, IMapper mapper) 
        {
            _context = context;
            _repository = postRepository ?? throw new ArgumentNullException(nameof(postRepository));
            _mapper = mapper;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoPost>> GetAll() 
        {
            List<Post> query = await _repository.GetAll().ToListAsync();
            List<DtoPost> anuncios = _mapper.Map<List<DtoPost>>(query);
                //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
                //.ToListAsync();
            return anuncios;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoPost> GetOne(int id)
        {
            Post query = await _repository.GetOne(id);
            DtoPost anuncio = _mapper.Map<DtoPost>(query);
            return anuncio;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoPostComment>> GetComentarios(int id)
        {
            List<PostComment> query = await _repository.GetComentarios(id).ToListAsync();
            List<DtoPostComment> anuncios = _mapper.Map<List<DtoPostComment>>(query);
            //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
            //.ToListAsync();
            return anuncios;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public DtoPost Create(DtoPost dto)
        {
            Post anuncio = _mapper.Map<Post>(dto);

            anuncio.CreationDate = DateTime.Now;

            _repository.Create(anuncio);

            DtoPost salida = _mapper.Map<DtoPost>(anuncio);

            return salida;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoPost> Update(DtoPost dto, int id)
        {
            Post dtoAnuncio = await _repository.GetOne(id);
            Post dtoEntrada = _mapper.Map<Post>(dto);

            Post query = await _repository.Update(dtoAnuncio, dtoEntrada);
            DtoPost anuncio = _mapper.Map<DtoPost>(query);
            return anuncio;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Delete(int id)
        {
            Post dtoAnuncio = await _repository.GetOne(id);
            _repository.Delete(dtoAnuncio);
            return true;
        }
    }
}
