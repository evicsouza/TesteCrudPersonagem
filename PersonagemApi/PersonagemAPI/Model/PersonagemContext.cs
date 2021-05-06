using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace personagemAPI.Models
{
    public class personagemContext:DbContext
    {
        public personagemContext(DbContextOptions<personagemContext> options):base(options)
        {

        }

        public DbSet<personagem> personagens { get; set; }
    }
}
