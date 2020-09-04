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
    public class PostCommentService : IPostCommentService
    {
        private readonly FoguerAppDbContext _context;
        private readonly IPostCommentRepository _repository;
        private readonly IMapper _mapper;
        public PostCommentService(FoguerAppDbContext context, IPostCommentRepository postCommentRepository, IMapper mapper) 
        {
            _context = context;
            _repository = postCommentRepository ?? throw new ArgumentNullException(nameof(postCommentRepository));
            _mapper = mapper;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public DtoPostComment Create(DtoPostComment dto)
        {
            PostComment comentario = _mapper.Map<PostComment>(dto);

            comentario.CreationDate = DateTime.Now;

            _repository.Create(comentario);

            DtoPostComment salida = _mapper.Map<DtoPostComment>(comentario);

            return salida;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoPostComment> Update(DtoPostComment dto, int id)
        {
            PostComment dtoComentario = await _repository.GetOne(id);
            PostComment dtoEntrada = _mapper.Map<PostComment>(dto);
            dtoEntrada.UpdateDate = DateTime.Now;

            PostComment query = await _repository.Update(dtoComentario, dtoEntrada);
            DtoPostComment anuncio = _mapper.Map<DtoPostComment>(query);
            return anuncio;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Delete(int id)
        {
            PostComment dtoAnuncio = await _repository.GetOne(id);
            _repository.Delete(dtoAnuncio);
            return true;
        }
    }
}
