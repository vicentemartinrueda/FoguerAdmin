using System;
using AutoMapper;

namespace FoguerAppApi.Assets
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            //CreateMap<VMUsuarioAdd, Usuario>()
            //   .ForMember(dest => dest.UserName, opt => opt.MapFrom(c => c.UserName))
            //   .ForMember(dest => dest.TipoUsuarioId, opt => opt.MapFrom(c => c.TipoUsuarioId))
            //   .ForMember(dest => dest.Notificaciones, opt => opt.MapFrom(c => c.NotificacionesId))
            //   .ForMember(dest => dest.EstadosId, opt => opt.MapFrom(c => c.EstadosId))
            //   .ForMember(dest => dest.IdiomasId, opt => opt.MapFrom(c => c.IdiomasId))
            //   .ForMember(dest => dest.Premium, opt => opt.MapFrom(c => c.PremiumId))
            //   .ForMember(dest => dest.Password, opt => opt.MapFrom(c => c.Password));
        }
    }
}