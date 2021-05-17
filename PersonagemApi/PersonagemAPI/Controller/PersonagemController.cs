using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using personagemAPI.Model;
using AutoMapper;

namespace personagemAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class personagemController : ControllerBase
    {
        private readonly personagemContext _context;
        private readonly IMapper _mapper;  

        public personagemController(personagemContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        // GET: api/personagem
        [HttpGet]
        public async Task<ActionResult<IEnumerable<personagem>>> Getpersonagems()
        {
            return await _context.personagens.ToListAsync();
        }

        // GET: api/personagem/5
        [HttpGet("{id}")]
        public async Task<ActionResult<personagem>> Getpersonagem(int id)
        {
            var personagem = await _context.personagens.FindAsync(id);

            if (personagem == null)
            {
                return NotFound();
            }

            return personagem;
        }

        // PUT: api/personagem/5
        [HttpPut("{id}")]
        public async Task<IActionResult> Putpersonagem(int id, personagem personagem)
        {
            if (id != personagem.personagemId)
            {
                return BadRequest();
            }

            _context.Entry(personagem).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!personagemExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/personagem
        [HttpPost]
        public async Task<ActionResult<personagem>> Postpersonagem(personagem personagem)
        {
            _context.personagens.Add(personagem);
            await _context.SaveChangesAsync();

            return CreatedAtAction("Getpersonagem", new { id = personagem.personagemId }, personagem);
        }

        // DELETE: api/personagem/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Deletepersonagem(int id)
        {
            var personagem = await _context.personagens.FindAsync(id);
            if (personagem == null)
            {
                return NotFound();
            }

            _context.personagens.Remove(personagem);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool personagemExists(int id)
        {
            return _context.personagens.Any(e => e.personagemId == id);
        }
    }
}
