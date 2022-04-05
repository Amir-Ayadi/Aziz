#nullable disable
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Aziz.Models;

namespace Aziz.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContratsController : ControllerBase
    {
        private readonly ProjectContext _context;

        public ContratsController(ProjectContext context)
        {
            _context = context;
        }

        // GET: api/Contrats
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Contrat>>> GetContrats()
        {
            return await _context.Contrats.ToListAsync();
        }

        // GET: api/Contrats/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Contrat>> GetContrat(int id)
        {
            var contrat = await _context.Contrats.FindAsync(id);

            if (contrat == null)
            {
                return NotFound();
            }

            return contrat;
        }

        // PUT: api/Contrats/5
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPut("{id}")]
        public async Task<IActionResult> PutContrat(int id, Contrat contrat)
        {
            if (id != contrat.ContratId)
            {
                return BadRequest();
            }

            _context.Entry(contrat).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ContratExists(id))
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

        // POST: api/Contrats
        // To protect from overposting attacks, see https://go.microsoft.com/fwlink/?linkid=2123754
        [HttpPost]
        public async Task<ActionResult<Contrat>> PostContrat(Contrat contrat)
        {
            _context.Contrats.Add(contrat);
            await _context.SaveChangesAsync();

            return CreatedAtAction("GetContrat", new { id = contrat.ContratId }, contrat);
        }

        // DELETE: api/Contrats/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContrat(int id)
        {
            var contrat = await _context.Contrats.FindAsync(id);
            if (contrat == null)
            {
                return NotFound();
            }

            _context.Contrats.Remove(contrat);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool ContratExists(int id)
        {
            return _context.Contrats.Any(e => e.ContratId == id);
        }
    }
}
