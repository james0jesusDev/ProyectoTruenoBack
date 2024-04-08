using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto10AbrilBack.Data;
using Proyecto10AbrilBack.Models;

namespace Proyecto10AbrilBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class PartidoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public PartidoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/Partidoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Partido>>> GetPartido()
        {
            return await _context.Partido.ToListAsync();
        }

        // GET: api/Partidoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Partido>> GetPartido(int id)
        {
            var partido = await _context.Partido.FindAsync(id);

            if (partido == null)
            {
                return NotFound();
            }

            return partido;
        }

        // PUT: api/Partidoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPartido(int id, Partido partido)
        {
            if (id != partido.ID)
            {
                return BadRequest();
            }

            _context.Entry(partido).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PartidoExists(id))
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

        // POST: api/Partidoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Partido>> PostPartido(Partido partido)
        {
            _context.Partido.Add(partido);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetPartido", new { id = partido.ID }, partido);
        }

        // DELETE: api/Partidoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePartido(int id)
        {
            var partido = await _context.Partido.FindAsync(id);
            if (partido == null)
            {
                return NotFound();
            }

            _context.Partido.Remove(partido);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool PartidoExists(int id)
        {
            return _context.Partido.Any(e => e.ID == id);
        }
    }
}
