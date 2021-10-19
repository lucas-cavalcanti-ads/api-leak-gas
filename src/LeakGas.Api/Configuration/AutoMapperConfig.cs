using AutoMapper;
using LeakGas.Api.DTO;
using LeakGas.Business.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LeakGas.Api.Configuration
{
    public class AutoMapperConfig : Profile
    {
        public AutoMapperConfig()
        {

            CreateMap<Condominio, CondominioDTO>().ReverseMap();
            CreateMap<Usuario, UsuarioDTO>().ReverseMap();
            CreateMap<ViewUsuario, UsuarioDadosDTO>().ReverseMap();

            CreateMap<ViewAlarme, OcorrenciasDTO>().ForMember(dest => dest.Ativo, opt => opt.MapFrom(src => src.DescricaoStatus != null && src.DescricaoStatus != "FECHADO" ? true : false)).ReverseMap();
        }
    }
}
