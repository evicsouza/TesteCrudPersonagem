using AutoMapper;

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
