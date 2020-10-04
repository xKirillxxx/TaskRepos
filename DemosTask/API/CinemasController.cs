﻿using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using DemosTask.Models;

namespace DemosTask.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class CinemasController : ControllerBase
    {
        private readonly CinemaContext _context;

        public CinemasController(CinemaContext context)
        {
            _context = context;
        }

        // GET: api/Cinemas
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Cinema>>> GetCinemas()
        {
            return await _context.Cinemas.ToListAsync();
        }

        // GET: api/Cinemas/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Cinema>> GetCinema(int id)
        {
            var cinema = await _context.Cinemas.FindAsync(id);

            if (cinema == null)
            {
                return NotFound();
            }

            return cinema;
        }

        // PUT: api/Cinemas/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutCinema(int id, Cinema cinema)
        {
            if (id != cinema.Id)
            {
                return BadRequest();
            }

            _context.Entry(cinema).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!CinemaExists(id))
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

        // POST: api/Cinemas
        [HttpPost]
        public async Task<ActionResult<Cinema>> PostCinema(Cinema cinema)
        {
            _context.Cinemas.Add(cinema);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetCinema", new { id = cinema.Id }, cinema);
        }

        // DELETE: api/Cinemas/5
        [HttpDelete("{id}")]
        public async Task<ActionResult<Cinema>> DeleteCinema(int id)
        {
            var cinema = await _context.Cinemas.FindAsync(id);
            if (cinema == null)
            {
                return NotFound();
            }

            _context.Cinemas.Remove(cinema);
            await _context.SaveChangesAsync();

            return cinema;
        }

        private bool CinemaExists(int id)
        {
            return _context.Cinemas.Any(e => e.Id == id);
        }
    }
}
