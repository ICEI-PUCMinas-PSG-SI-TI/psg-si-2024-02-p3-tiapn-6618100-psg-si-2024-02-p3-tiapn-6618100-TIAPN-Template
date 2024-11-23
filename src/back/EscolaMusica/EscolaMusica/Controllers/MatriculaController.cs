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
    public class MatriculaController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public MatriculaController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Matricula
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FatoMatricula>>> GetMatriculas()
        {
            return await _context.FatoMatriculas
                .Include(m => m.aluno)
                .Include(m => m.turma)
                .Include(m => m.pagamento)
                .Include(m => m.administrador)
                .ToListAsync();
        }

        // GET: api/Matricula/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FatoMatricula>> GetMatricula(int id)
        {
            var matricula = await _context.FatoMatriculas
                .Include(m => m.aluno)
                .Include(m => m.turma)
                .Include(m => m.pagamento)
                .Include(m => m.administrador)
                .FirstOrDefaultAsync(m => m.codigo_matricula == id);

            if (matricula == null)
            {
                return NotFound();
            }

            return matricula;
        }

        // PUT: api/Matricula/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutMatricula(int id, FatoMatricula matricula)
        {
            if (id != matricula.codigo_matricula)
            {
                return BadRequest();
            }

            _context.Entry(matricula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MatriculaExists(id))
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

        // POST: api/Matricula
        [HttpPost]
        public async Task<ActionResult<FatoMatricula>> PostMatricula(FatoMatricula matricula)
        {
            _context.FatoMatriculas.Add(matricula);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetMatricula), new { id = matricula.codigo_matricula }, matricula);
        }

        // DELETE: api/Matricula/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMatricula(int id)
        {
            var matricula = await _context.FatoMatriculas.FindAsync(id);
            if (matricula == null)
            {
                return NotFound();
            }

            _context.FatoMatriculas.Remove(matricula);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MatriculaExists(int id)
        {
            return _context.FatoMatriculas.Any(e => e.codigo_matricula == id);
        }
    }
}
