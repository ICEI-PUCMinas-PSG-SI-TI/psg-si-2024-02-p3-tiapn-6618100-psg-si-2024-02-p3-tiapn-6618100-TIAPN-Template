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
    public class AlunoController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public AlunoController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Aluno
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimAluno>>> GetAlunos()
        {
            return await _context.DimAlunos.AsNoTracking().ToListAsync();
        }

        // GET: api/Aluno/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimAluno>> GetAluno(int id)
        {
            var aluno = await _context.DimAlunos.AsNoTracking().FirstOrDefaultAsync(a => a.codigo_aluno == id);

            if (aluno == null)
            {
                return NotFound(new { message = $"Aluno com ID {id} não encontrado." });
            }

            return aluno;
        }

        // PUT: api/Aluno/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAluno(int id, DimAluno aluno)
        {
            if (id != aluno.codigo_aluno)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do aluno." });
            }

            _context.Entry(aluno).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AlunoExists(id))
                {
                    return NotFound(new { message = $"Aluno com ID {id} não encontrado para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Aluno
        [HttpPost]
        public async Task<ActionResult<DimAluno>> PostAluno(DimAluno aluno)
        {
            // Validações adicionais antes de salvar
            if (string.IsNullOrEmpty(aluno.nome) || string.IsNullOrEmpty(aluno.matricula))
            {
                return BadRequest(new { message = "Os campos 'Nome' e 'Matrícula' são obrigatórios." });
            }

            _context.DimAlunos.Add(aluno);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAluno), new { id = aluno.codigo_aluno }, aluno);
        }

        // DELETE: api/Aluno/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAluno(int id)
        {
            var aluno = await _context.DimAlunos.FindAsync(id);
            if (aluno == null)
            {
                return NotFound(new { message = $"Aluno com ID {id} não encontrado para exclusão." });
            }

            _context.DimAlunos.Remove(aluno);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar existência
        private bool AlunoExists(int id)
        {
            return _context.DimAlunos.Any(e => e.codigo_aluno == id);
        }
    }
}
