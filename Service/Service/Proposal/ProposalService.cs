using AutoMapper;
using Database.General.Context;
using Database.General.Models;
using Database.Repository.Interfaces;
using Microsoft.EntityFrameworkCore;
using Service.DTO;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Service.Service
{
    public class ProposalService : IProposalService
    {
        private readonly FoguerAppDbContext _context;
        private readonly IProposalRepository _repository;
        private readonly IMapper _mapper;
        public ProposalService(FoguerAppDbContext context, IProposalRepository proposalRepository, IMapper mapper) 
        {
            _context = context;
            _repository = proposalRepository ?? throw new ArgumentNullException(nameof(proposalRepository));
            _mapper = mapper;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoProposal>> GetAll()
        {
            List<Proposal> query = await _repository.GetAll().ToListAsync();
            List<DtoProposal> propuestas = _mapper.Map<List<DtoProposal>>(query);
            //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
            //.ToListAsync();
            return propuestas;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoProposal> GetOne(int id) //Hacer lo mismo que en PostService
        {
            Proposal query = await _repository.GetOne(id);
            DtoProposal propuesta = _mapper.Map<DtoProposal>(query);
            //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
            //.ToListAsync();
            return propuesta;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoProposalComment>> GetComentarios(int id)
        {
            List<ProposalComment> query = await _repository.GetComentarios(id).ToListAsync();
            List<DtoProposalComment> propuestas = _mapper.Map<List<DtoProposalComment>>(query);
            //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
            //.ToListAsync();
            return propuestas;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<List<DtoProposalOptionVoters>> GetOpciones(int id)
        {
            List<ProposalOption> query = await _repository.GetOpciones(id).ToListAsync();
            List<DtoProposalOptionVoters> propuestas = _mapper.Map<List<DtoProposalOptionVoters>>(query);
            //.ProjectTo<DtoUsuario>(_mapper.ConfigurationProvider)
            //.ToListAsync();
            return propuestas;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public DtoProposal Create(DtoProposal dto)
        {
            Proposal propuesta = _mapper.Map<Proposal>(dto);

            propuesta.CreationDate = DateTime.Now;

            _repository.Create(propuesta);

            DtoProposal salida = _mapper.Map<DtoProposal>(propuesta);

            return salida;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoProposal> Update(DtoProposal dto, int id)
        {
            Proposal dtoPropuesta = await _repository.GetOne(id);
            Proposal dtoEntrada = _mapper.Map<Proposal>(dto);

            Proposal query = await _repository.Update(dtoPropuesta, dtoEntrada);
            DtoProposal propuesta = _mapper.Map<DtoProposal>(query);
            return propuesta;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<bool> Delete(int id)
        {
            Proposal dtoPropuesta = await _repository.GetOne(id);
            _repository.Delete(dtoPropuesta);
            return true;
        }

        /// <summary>
        /// Get this instance Users
        /// </summary>
        /// <returns></returns>
        public async Task<DtoOptionUser> Vote(DtoOptionUser dto, int id)
        {
            List<ProposalOption> query = await _repository.GetOpciones(id).ToListAsync();
            List<DtoProposalOptionVoters> opciones = _mapper.Map<List<DtoProposalOptionVoters>>(query);

            DtoOptionUser encontrado = null;

            foreach (DtoProposalOptionVoters opcion in opciones)
            {
                var esta = opcion.Voters.Find(x => x.UserId == dto.UserId);
                if (esta != null) encontrado = esta;
            }

            if (encontrado != null)
            {
                //BORRAR
                OptionUser deletionVote = _mapper.Map<OptionUser>(encontrado);
                _repository.DeleteVote(deletionVote);
            }

            //CREAR
            OptionUser vote = _mapper.Map<OptionUser>(dto);
            _repository.CreateVote(vote);

            return dto;
        }
    }
}