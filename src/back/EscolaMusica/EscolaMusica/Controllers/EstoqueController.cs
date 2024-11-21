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
    public class EstoqueController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public EstoqueController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Estoque
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimEstoque>>> GetEstoques()
        {
            return await _context.DimEstoques.ToListAsync();
        }

        // GET: api/Estoque/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimEstoque>> GetEstoque(int id)
        {
            var estoque = await _context.DimEstoques.FindAsync(id);

            if (estoque == null)
            {
                return NotFound();
            }

            return estoque;
        }

        // PUT: api/Estoque/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstoque(int id, DimEstoque estoque)
        {
            if (id != estoque.codigo_estoque)
            {
                return BadRequest();
            }

            _context.Entry(estoque).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstoqueExists(id))
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

        // POST: api/Estoque
        [HttpPost]
        public async Task<ActionResult<DimEstoque>> PostEstoque(DimEstoque estoque)
        {
            _context.DimEstoques.Add(estoque);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEstoque), new { id = estoque.codigo_estoque }, estoque);
        }

        // DELETE: api/Estoque/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstoque(int id)
        {
            var estoque = await _context.DimEstoques.FindAsync(id);
            if (estoque == null)
            {
                return NotFound();
            }

            _context.DimEstoques.Remove(estoque);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool EstoqueExists(int id)
        {
            return _context.DimEstoques.Any(e => e.codigo_estoque == id);
        }
    }
}
