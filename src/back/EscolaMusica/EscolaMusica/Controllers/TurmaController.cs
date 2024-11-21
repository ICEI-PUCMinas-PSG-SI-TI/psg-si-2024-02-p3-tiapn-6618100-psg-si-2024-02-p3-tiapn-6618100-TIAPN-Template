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
    public class TurmaController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public TurmaController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Turma
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimTurma>>> GetTurmas()
        {
            return await _context.DimTurmas.ToListAsync();
        }

        // GET: api/Turma/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimTurma>> GetTurma(int id)
        {
            var turma = await _context.DimTurmas.FindAsync(id);

            if (turma == null)
            {
                return NotFound();
            }

            return turma;
        }

        // PUT: api/Turma/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTurma(int id, DimTurma turma)
        {
            if (id != turma.codigo_turma)
            {
                return BadRequest();
            }

            _context.Entry(turma).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!TurmaExists(id))
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

        // POST: api/Turma
        [HttpPost]
        public async Task<ActionResult<DimTurma>> PostTurma(DimTurma turma)
        {
            _context.DimTurmas.Add(turma);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetTurma), new { id = turma.codigo_turma }, turma);
        }

        // DELETE: api/Turma/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteTurma(int id)
        {
            var turma = await _context.DimTurmas.FindAsync(id);
            if (turma == null)
            {
                return NotFound();
            }

            _context.DimTurmas.Remove(turma);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool TurmaExists(int id)
        {
            return _context.DimTurmas.Any(e => e.codigo_turma == id);
        }
    }
}
