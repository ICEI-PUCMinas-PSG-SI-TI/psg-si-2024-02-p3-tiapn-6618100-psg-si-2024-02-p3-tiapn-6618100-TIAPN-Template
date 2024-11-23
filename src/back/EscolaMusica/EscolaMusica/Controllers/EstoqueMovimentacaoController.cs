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
    public class EstoqueMovimentacaoController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public EstoqueMovimentacaoController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/EstoqueMovimentacao
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FatoEstoqueMovimentacao>>> GetEstoqueMovimentacoes()
        {
            return await _context.FatoEstoquesMovimentacao
                .Include(f => f.estoque) // DimEstoque
                .Include(f => f.tempo) // DimTempo
                .Include(f => f.administrador) // DimAdministrador
                .AsNoTracking()
                .ToListAsync();
        }

        // GET: api/EstoqueMovimentacao/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FatoEstoqueMovimentacao>> GetEstoqueMovimentacao(int id)
        {
            var movimentacao = await _context.FatoEstoquesMovimentacao
                .Include(m => m.estoque)
                .Include(m => m.tempo)
                .Include(m => m.administrador)
                .AsNoTracking()
                .FirstOrDefaultAsync(m => m.codigo_movimentacao == id);

            if (movimentacao == null)
            {
                return NotFound(new { message = $"Movimentação com ID {id} não encontrada." });
            }

            return movimentacao;
        }

        // PUT: api/EstoqueMovimentacao/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutEstoqueMovimentacao(int id, FatoEstoqueMovimentacao movimentacao)
        {
            if (id != movimentacao.codigo_movimentacao)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID da movimentação." });
            }

            _context.Entry(movimentacao).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!EstoqueMovimentacaoExists(id))
                {
                    return NotFound(new { message = $"Movimentação com ID {id} não encontrada para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/EstoqueMovimentacao
        [HttpPost]
        public async Task<ActionResult<FatoEstoqueMovimentacao>> PostEstoqueMovimentacao(FatoEstoqueMovimentacao movimentacao)
        {
            // Validação adicional
            if (movimentacao.codigo_estoque <= 0 || movimentacao.codigo_tempo <= 0 || movimentacao.quantidade <= 0)
            {
                return BadRequest(new { message = "Os campos de Estoque, Tempo e Quantidade são obrigatórios e devem ser válidos." });
            }

            _context.FatoEstoquesMovimentacao.Add(movimentacao);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetEstoqueMovimentacao), new { id = movimentacao.codigo_movimentacao }, movimentacao);
        }

        // DELETE: api/EstoqueMovimentacao/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteEstoqueMovimentacao(int id)
        {
            var movimentacao = await _context.FatoEstoquesMovimentacao.FindAsync(id);
            if (movimentacao == null)
            {
                return NotFound(new { message = $"Movimentação com ID {id} não encontrada para exclusão." });
            }

            _context.FatoEstoquesMovimentacao.Remove(movimentacao);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar existência
        private bool EstoqueMovimentacaoExists(int id)
        {
            return _context.FatoEstoquesMovimentacao.Any(e => e.codigo_movimentacao == id);
        }
    }
}
