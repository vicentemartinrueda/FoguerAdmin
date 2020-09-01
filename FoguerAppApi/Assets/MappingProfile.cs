using System;
using AutoMapper;
using Database.General.Models;
using Service.DTO;

namespace FoguerAppApi.Assets
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<User, DtoUser>();
            CreateMap<DtoUser, User>();
            CreateMap<Role, DtoRole>();
            CreateMap<DtoRole, Role>();
            CreateMap<Post, DtoPost>();
            CreateMap<DtoPost, Post>();
            CreateMap<Proposal, DtoProposal>();
            CreateMap<DtoProposal, Proposal>();
            CreateMap<ProposalComment, DtoProposalComment>();
            CreateMap<DtoProposalComment, ProposalComment>();
            CreateMap<ProposalOption, DtoProposalOption>();
            CreateMap<DtoProposalOption, ProposalOption>();
            CreateMap<PostComment, DtoPostComment>();
            CreateMap<DtoPostComment, PostComment>();
        }
    }
}