using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto10AbrilBack.Data;
using ProyectoCore10AbrilBack.Models;

namespace Proyecto10AbrilBack.Controllers
{
    [EnableCors("MyPolicy")]
    [Route("api/[controller]")]
    [ApiController]

    public class AbonadosController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AbonadosController(ApplicationDbContext context)
        {
             _context = context;
        }

        // GET: api/Abonados
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Abonado>>> GetAbonados()
        {
            return await _context.Abonados.ToListAsync();
        }

        // GET: api/Abonados/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Abonado>> GetAbonado(int id)
        {
            var abonado = await _context.Abonados.FindAsync(id);

            if (abonado == null)
            {
                return NotFound();
            }

            return abonado;
        }

        // PUT: api/Abonados/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAbonado(int id, Abonado abonado)
        {
            if (id != abonado.AbonadoId)
            {
                return BadRequest();
            }

            _context.Entry(abonado).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AbonadoExists(id))
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

        // POST: api/Abonados
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Abonado>> PostAbonado(Abonado abonado)
        {
            _context.Abonados.Add(abonado);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetAbonado", new { id = abonado.AbonadoId }, abonado);
        }

        // DELETE: api/Abonados/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAbonado(int id)
        {
            var abonado = await _context.Abonados.FindAsync(id);
            if (abonado == null)
            {
                return NotFound();
            }

            _context.Abonados.Remove(abonado);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AbonadoExists(int id)
        {
            return _context.Abonados.Any(e => e.AbonadoId == id);
        }
    }
}
