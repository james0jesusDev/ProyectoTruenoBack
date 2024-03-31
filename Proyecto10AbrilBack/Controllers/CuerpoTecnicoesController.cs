using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Proyecto10AbrilBack.Data;
using ProyectoCore10AbrilBack.Models;

namespace Proyecto10AbrilBack.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CuerpoTecnicoesController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public CuerpoTecnicoesController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: api/CuerpoTecnicoes
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CuerpoTecnico>>> GetCuerpoTecnicos()
        {
            return await _context.CuerpoTecnicos.ToListAsync();
        }

        // GET: api/CuerpoTecnicoes/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CuerpoTecnico>> GetCuerpoTecnico(int id)
        {
            var cuerpoTecnico = await _context.CuerpoTecnicos.FindAsync(id);

            if (cuerpoTecnico == null)
            {
                return NotFound();
            }

            return cuerpoTecnico;
        }

        // PUT: api/CuerpoTecnicoes/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCuerpoTecnico(int id, CuerpoTecnico cuerpoTecnico)
        {
            if (id != cuerpoTecnico.CuerpoTecnicoId)
            {
                return BadRequest();
            }

            _context.Entry(cuerpoTecnico).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CuerpoTecnicoExists(id))
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

        // POST: api/CuerpoTecnicoes
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<CuerpoTecnico>> PostCuerpoTecnico(CuerpoTecnico cuerpoTecnico)
        {
            _context.CuerpoTecnicos.Add(cuerpoTecnico);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCuerpoTecnico", new { id = cuerpoTecnico.CuerpoTecnicoId }, cuerpoTecnico);
        }

        // DELETE: api/CuerpoTecnicoes/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteCuerpoTecnico(int id)
        {
            var cuerpoTecnico = await _context.CuerpoTecnicos.FindAsync(id);
            if (cuerpoTecnico == null)
            {
                return NotFound();
            }

            _context.CuerpoTecnicos.Remove(cuerpoTecnico);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool CuerpoTecnicoExists(int id)
        {
            return _context.CuerpoTecnicos.Any(e => e.CuerpoTecnicoId == id);
        }
    }
}
