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
    public class EmprestimoController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public EmprestimoController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Emprestimo
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FatoEmprestimo>>> GetEmprestimos()
        {
            return await _context.FatoEmprestimos
                .Include(e => e.instrumento)
                .Include(e => e.aluno)
                .Include(e => e.tempoEmprestimo)
                .Include(e => e.tempoDevolucao)
                .Include(e => e.administrador) 
                .AsNoTracking()
                .ToListAsync();
        }

        // GET: api/Emprestimo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FatoEmprestimo>> GetEmprestimo(int id)
        {
            var emprestimo = await _context.FatoEmprestimos
                .Include(e => e.instrumento)
                .Include(e => e.aluno)
                .Include(e => e.tempoEmprestimo)
                .Include(e => e.tempoDevolucao)
                .Include(e => e.administrador)
                .AsNoTracking()
                .FirstOrDefaultAsync(e => e.codigo_emprestimo == id);

            if (emprestimo == null)
            {
                return NotFound(new { message = $"Empréstimo com ID {id} não encontrado." });
            }

            return emprestimo;
        }

        // PUT: api/Emprestimo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmprestimo(int id, FatoEmprestimo emprestimo)
        {
            if (id != emprestimo.codigo_emprestimo)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do empréstimo." });
            }

            // Verifica se as entidades relacionadas existem
            if (!await InstrumentoExists(emprestimo.codigo_instrumento) ||
                !await AlunoExists(emprestimo.codigo_aluno) ||
                !await TempoExists(emprestimo.codigo_tempo_emprestimo))
            {
                return BadRequest(new { message = "Instrumento, Aluno ou Tempo de Empréstimo inválido." });
            }

            _context.Entry(emprestimo).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EmprestimoExists(id))
                {
                    return NotFound(new { message = $"Empréstimo com ID {id} não encontrado para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Emprestimo
        [HttpPost]
        public async Task<ActionResult<FatoEmprestimo>> PostEmprestimo(FatoEmprestimo emprestimo)
        {
            // Validações adicionais para evitar dados inválidos
            if (emprestimo.codigo_instrumento <= 0 || emprestimo.codigo_aluno <= 0 || emprestimo.codigo_tempo_emprestimo <= 0)
            {
                return BadRequest(new { message = "Os campos de Instrumento, Aluno e Tempo de Empréstimo são obrigatórios e devem ser válidos." });
            }

            // Verifica se as entidades relacionadas existem
            if (!await InstrumentoExists(emprestimo.codigo_instrumento) ||
                !await AlunoExists(emprestimo.codigo_aluno) ||
                !await TempoExists(emprestimo.codigo_tempo_emprestimo))
            {
                return BadRequest(new { message = "Instrumento, Aluno ou Tempo de Empréstimo inválido." });
            }

            _context.FatoEmprestimos.Add(emprestimo);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEmprestimo), new { id = emprestimo.codigo_emprestimo }, emprestimo);
        }

        // DELETE: api/Emprestimo/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEmprestimo(int id)
        {
            var emprestimo = await _context.FatoEmprestimos.FindAsync(id);
            if (emprestimo == null)
            {
                return NotFound(new { message = $"Empréstimo com ID {id} não encontrado para exclusão." });
            }

            _context.FatoEmprestimos.Remove(emprestimo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Verifica se um empréstimo existe
        private bool EmprestimoExists(int id)
        {
            return _context.FatoEmprestimos.Any(e => e.codigo_emprestimo == id);
        }

        // Verifica se um instrumento existe
        private async Task<bool> InstrumentoExists(int id)
        {
            return await _context.DimInstrumentos.AnyAsync(i => i.codigo_instrumento == id);
        }

        // Verifica se um aluno existe
        private async Task<bool> AlunoExists(int id)
        {
            return await _context.DimAlunos.AnyAsync(a => a.codigo_aluno == id);
        }

        // Verifica se um tempo existe
        private async Task<bool> TempoExists(int id)
        {
            return await _context.DimTempos.AnyAsync(t => t.codigo_tempo == id);
        }
    }
}
