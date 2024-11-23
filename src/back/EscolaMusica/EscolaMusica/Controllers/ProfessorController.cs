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
    public class ProfessorController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public ProfessorController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Professor
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimProfessor>>> GetProfessores()
        {
            return await _context.DimProfessores
                .AsNoTracking()
                .ToListAsync();
        }

        // GET: api/Professor/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimProfessor>> GetProfessor(int id)
        {
            var professor = await _context.DimProfessores
                .AsNoTracking()
                .FirstOrDefaultAsync(p => p.codigo_professor == id);

            if (professor == null)
            {
                return NotFound(new { message = $"Professor com ID {id} não encontrado." });
            }

            return professor;
        }

        // PUT: api/Professor/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutProfessor(int id, DimProfessor professor)
        {
            if (id != professor.codigo_professor)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do professor." });
            }

            _context.Entry(professor).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProfessorExists(id))
                {
                    return NotFound(new { message = $"Professor com ID {id} não encontrado para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Professor
        [HttpPost]
        public async Task<ActionResult<DimProfessor>> PostProfessor(DimProfessor professor)
        {
            // Validações adicionais
            if (string.IsNullOrEmpty(professor.nome) || string.IsNullOrEmpty(professor.habilidades))
            {
                return BadRequest(new { message = "Os campos 'Nome' e 'Habilidades' são obrigatórios." });
            }

            _context.DimProfessores.Add(professor);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetProfessor), new { id = professor.codigo_professor }, professor);
        }

        // DELETE: api/Professor/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteProfessor(int id)
        {
            var professor = await _context.DimProfessores.FindAsync(id);
            if (professor == null)
            {
                return NotFound(new { message = $"Professor com ID {id} não encontrado para exclusão." });
            }

            _context.DimProfessores.Remove(professor);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar existência
        private bool ProfessorExists(int id)
        {
            return _context.DimProfessores.Any(e => e.codigo_professor == id);
        }
    }
}
