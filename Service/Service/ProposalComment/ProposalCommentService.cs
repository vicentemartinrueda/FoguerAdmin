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
    public class ProposalCommentService : IProposalCommentService
    {
        private readonly FoguerAppDbContext _context;
        private readonly IProposalCommentRepository _repository;
        private readonly IMapper _mapper;
        public ProposalCommentService(FoguerAppDbContext context, IProposalCommentRepository proposalCommentRepository, IMapper mapper) 
        {
            _context = context;
            _repository = proposalCommentRepository ?? throw new ArgumentNullException(nameof(proposalCommentRepository));
            _mapper = mapper;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public DtoProposalComment Create(DtoProposalComment dto)
        {
            ProposalComment comentario = _mapper.Map<ProposalComment>(dto);

            comentario.CreationDate = DateTime.Now;

            _repository.Create(comentario);

            DtoProposalComment salida = _mapper.Map<DtoProposalComment>(comentario);

            return salida;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoProposalComment> Update(DtoProposalComment dto, int id)
        {
            ProposalComment dtoComentario = await _repository.GetOne(id);
            ProposalComment dtoEntrada = _mapper.Map<ProposalComment>(dto);
            dtoEntrada.UpdateDate = DateTime.Now;

            ProposalComment query = await _repository.Update(dtoComentario, dtoEntrada);
            DtoProposalComment anuncio = _mapper.Map<DtoProposalComment>(query);
            return anuncio;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Delete(int id)
        {
            ProposalComment dtoAnuncio = await _repository.GetOne(id);
            _repository.Delete(dtoAnuncio);
            return true;
        }
    }
}
