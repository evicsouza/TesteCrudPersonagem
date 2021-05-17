using Microsoft.EntityFrameworkCore;

namespace personagemAPI.Model
{
    public class personagemContext:DbContext
    {
        public personagemContext(DbContextOptions<personagemContext> options):base(options)
        {

        }

        public DbSet<personagem> personagens { get; set; }
    }
}
