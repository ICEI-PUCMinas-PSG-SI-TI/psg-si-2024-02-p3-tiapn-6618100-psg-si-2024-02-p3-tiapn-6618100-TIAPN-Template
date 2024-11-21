using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using EscolaMusica.Data;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EscolaMusica.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TempoController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public TempoController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Tempo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimTempo>>> GetTempos()
        {
            return await _context.DimTempos.ToListAsync();
        }

        // GET: api/Tempo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimTempo>> GetTempo(int id)
        {
            var tempo = await _context.DimTempos.FindAsync(id);

            if (tempo == null)
            {
                return NotFound();
            }

            return tempo;
        }

        // PUT: api/Tempo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTempo(int id, DimTempo tempo)
        {
            if (id != tempo.codigo_tempo)
            {
                return BadRequest();
            }

            _context.Entry(tempo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TempoExists(id))
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

        // POST: api/Tempo
        [HttpPost]
        public async Task<ActionResult<DimTempo>> PostTempo(DimTempo tempo)
        {
            _context.DimTempos.Add(tempo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTempo), new { id = tempo.codigo_tempo }, tempo);
        }

        // DELETE: api/Tempo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTempo(int id)
        {
            var tempo = await _context.DimTempos.FindAsync(id);
            if (tempo == null)
            {
                return NotFound();
            }

            _context.DimTempos.Remove(tempo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TempoExists(int id)
        {
            return _context.DimTempos.Any(e => e.codigo_tempo == id);
        }
    }
}
