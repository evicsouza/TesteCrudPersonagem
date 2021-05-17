using AutoMapper;
using personagemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personagemAPI.Model
{
    public class PersonagemProfile : Profile
    {

        public PersonagemProfile()
        {
            CreateMap<personagem, PersonagemModel>()
                .ForMember(dest =>
                   dest.nome,
                    opt => opt.MapFrom(src => src.nome + " "));
        }
    }
}
