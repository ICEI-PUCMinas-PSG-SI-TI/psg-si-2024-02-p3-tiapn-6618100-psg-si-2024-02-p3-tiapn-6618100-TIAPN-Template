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
            return await _context.FatoEmprestimos.ToListAsync();
        }

        // GET: api/Emprestimo/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FatoEmprestimo>> GetEmprestimo(int id)
        {
            var emprestimo = await _context.FatoEmprestimos.FindAsync(id);

            if (emprestimo == null)
            {
                return NotFound();
            }

            return emprestimo;
        }

        // PUT: api/Emprestimo/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEmprestimo(int id, FatoEmprestimo emprestimo)
        {
            if (id != emprestimo.codigo_emprestimo)
            {
                return BadRequest();
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
                    return NotFound();
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
                return NotFound();
            }

            _context.FatoEmprestimos.Remove(emprestimo);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EmprestimoExists(int id)
        {
            return _context.FatoEmprestimos.Any(e => e.codigo_emprestimo == id);
        }
    }
}
