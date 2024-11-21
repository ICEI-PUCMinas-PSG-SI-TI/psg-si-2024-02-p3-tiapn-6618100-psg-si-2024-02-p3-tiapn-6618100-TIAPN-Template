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
    public class AdministradorController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public AdministradorController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Administrador
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimAdministrador>>> GetDimAdministradores()
        {
            return await _context.DimAdministradores.ToListAsync();
        }

        // GET: api/Administrador/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimAdministrador>> GetDimAdministrador(int id)
        {
            var administrador = await _context.DimAdministradores.FindAsync(id);

            if (administrador == null)
            {
                return NotFound();
            }

            return administrador;
        }

        // PUT: api/Administrador/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutDimAdministrador(int id, DimAdministrador administrador)
        {
            if (id != administrador.codigo_administrador)
            {
                return BadRequest();
            }

            _context.Entry(administrador).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!DimAdministradorExists(id))
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

        // POST: api/Administrador
        [HttpPost]
        public async Task<ActionResult<DimAdministrador>> PostDimAdministrador(DimAdministrador administrador)
        {
            _context.DimAdministradores.Add(administrador);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetDimAdministrador), new { id = administrador.codigo_administrador }, administrador);
        }

        // DELETE: api/Administrador/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteDimAdministrador(int id)
        {
            var administrador = await _context.DimAdministradores.FindAsync(id);
            if (administrador == null)
            {
                return NotFound();
            }

            _context.DimAdministradores.Remove(administrador);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool DimAdministradorExists(int id)
        {
            return _context.DimAdministradores.Any(e => e.codigo_administrador == id);
        }
    }
}
