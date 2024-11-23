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
    public class InstrumentoController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public InstrumentoController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Instrumento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimInstrumento>>> GetInstrumentos()
        {
            return await _context.DimInstrumentos
                .AsNoTracking()
                .ToListAsync();
        }

        // GET: api/Instrumento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimInstrumento>> GetInstrumento(int id)
        {
            var instrumento = await _context.DimInstrumentos
                .AsNoTracking()
                .FirstOrDefaultAsync(i => i.codigo_instrumento == id);

            if (instrumento == null)
            {
                return NotFound(new { message = $"Instrumento com ID {id} não encontrado." });
            }

            return instrumento;
        }

        // PUT: api/Instrumento/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutInstrumento(int id, DimInstrumento instrumento)
        {
            if (id != instrumento.codigo_instrumento)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do instrumento." });
            }

            _context.Entry(instrumento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!InstrumentoExists(id))
                {
                    return NotFound(new { message = $"Instrumento com ID {id} não encontrado para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Instrumento
        [HttpPost]
        public async Task<ActionResult<DimInstrumento>> PostInstrumento(DimInstrumento instrumento)
        {
            // Validações adicionais
            if (string.IsNullOrEmpty(instrumento.nome) || string.IsNullOrEmpty(instrumento.tipo))
            {
                return BadRequest(new { message = "Os campos 'Nome' e 'Tipo' são obrigatórios." });
            }

            _context.DimInstrumentos.Add(instrumento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetInstrumento), new { id = instrumento.codigo_instrumento }, instrumento);
        }

        // DELETE: api/Instrumento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteInstrumento(int id)
        {
            var instrumento = await _context.DimInstrumentos.FindAsync(id);
            if (instrumento == null)
            {
                return NotFound(new { message = $"Instrumento com ID {id} não encontrado para exclusão." });
            }

            _context.DimInstrumentos.Remove(instrumento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar existência
        private bool InstrumentoExists(int id)
        {
            return _context.DimInstrumentos.Any(e => e.codigo_instrumento == id);
        }
    }
}
