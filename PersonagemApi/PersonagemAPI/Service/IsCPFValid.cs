using DomainValidation.Interfaces.Specification;
using personagemAPI.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personagemAPI.Service
{
    public class IsCpfValid : ISpecification<PersonagemModel>
    {
        public bool IsSatisfiedBy(PersonagemModel entity)
        {
            return entity.cpf.Length == 11 && long.TryParse(entity.cpf, out long i);
        }
    }
}
