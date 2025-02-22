﻿using System;
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
    public class JugadoresController : ControllerBase
    {
        private readonly ApplicationDbContext _context;
        private readonly IHttpContextAccessor _httpContextAccessor;

        public JugadoresController(ApplicationDbContext context, IHttpContextAccessor httpContextAccessor)
        {
            _context = context;
            _httpContextAccessor = httpContextAccessor;
        }

        // GET: api/Jugadores
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Jugador>>> GetJugadores()
        {
            // Obtener la URL base del servidor
            var baseUrl = $"{_httpContextAccessor.HttpContext.Request.Scheme}://{_httpContextAccessor.HttpContext.Request.Host}";

            // Obtener la lista de jugadores desde la base de datos
            var jugadores = await _context.Jugadores.ToListAsync();

            // Iterar sobre cada jugador y construir la URL completa de la imagen
            foreach (var jugador in jugadores)
            {
                jugador.ImageUrl = $"{baseUrl}/images/{jugador.ImageUrl}";
            }

            // Devolver la lista de jugadores con las URLs de imagen completas
            return jugadores;
        }

        // GET: api/Jugadores/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Jugador>> GetJugador(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);

            if (jugador == null)
            {
                return NotFound();
            }

            return jugador;
        }

        // PUT: api/Jugadores/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutJugador(int id, Jugador jugador)
        {
            if (id != jugador.JugadorId)
            {
                return BadRequest();
            }

            _context.Entry(jugador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!JugadorExists(id))
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

        // POST: api/Jugadores
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Jugador>> PostJugador(Jugador jugador)
        {
            _context.Jugadores.Add(jugador);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetJugador", new { id = jugador.JugadorId }, jugador);
        }

        // DELETE: api/Jugadores/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteJugador(int id)
        {
            var jugador = await _context.Jugadores.FindAsync(id);
            if (jugador == null)
            {
                return NotFound();
            }

            _context.Jugadores.Remove(jugador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool JugadorExists(int id)
        {
            return _context.Jugadores.Any(e => e.JugadorId == id);
        }
    }
}
