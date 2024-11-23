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
            return await _context.DimTempos
                .AsNoTracking()
                .ToListAsync();
        }

        // GET: api/Tempo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimTempo>> GetTempo(int id)
        {
            var tempo = await _context.DimTempos
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.codigo_tempo == id);

            if (tempo == null)
            {
                return NotFound(new { message = $"Registro de tempo com ID {id} não encontrado." });
            }

            return tempo;
        }

        // PUT: api/Tempo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutTempo(int id, DimTempo tempo)
        {
            if (id != tempo.codigo_tempo)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do tempo." });
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
                    return NotFound(new { message = $"Registro de tempo com ID {id} não encontrado para atualização." });
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
            // Validação adicional
            if (tempo.data == default || tempo.ano <= 0 || tempo.mes <= 0 || tempo.dia <= 0)
            {
                return BadRequest(new { message = "Campos obrigatórios de data, ano, mês e dia devem ser preenchidos corretamente." });
            }

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
                return NotFound(new { message = $"Registro de tempo com ID {id} não encontrado para exclusão." });
            }

            _context.DimTempos.Remove(tempo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar existência
        private bool TempoExists(int id)
        {
            return _context.DimTempos.Any(e => e.codigo_tempo == id);
        }
    }
}
