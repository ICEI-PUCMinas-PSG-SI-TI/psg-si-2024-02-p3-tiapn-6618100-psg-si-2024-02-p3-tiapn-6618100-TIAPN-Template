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
    public class PagamentoController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public PagamentoController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/Pagamento
        [HttpGet]
        public async Task<ActionResult<IEnumerable<DimPagamento>>> GetPagamentos()
        {
            return await _context.DimPagamentos.ToListAsync();
        }

        // GET: api/Pagamento/5
        [HttpGet("{id}")]
        public async Task<ActionResult<DimPagamento>> GetPagamento(int id)
        {
            var pagamento = await _context.DimPagamentos.FindAsync(id);

            if (pagamento == null)
            {
                return NotFound(new { message = $"Pagamento com ID {id} não encontrado." });
            }

            return pagamento;
        }

        // PUT: api/Pagamento/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutPagamento(int id, DimPagamento pagamento)
        {
            if (id != pagamento.codigo_pagamento)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do pagamento." });
            }

            _context.Entry(pagamento).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!PagamentoExists(id))
                {
                    return NotFound(new { message = $"Pagamento com ID {id} não encontrado para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/Pagamento
        [HttpPost]
        public async Task<ActionResult<DimPagamento>> PostPagamento(DimPagamento pagamento)
        {
            // Validações adicionais
            if (string.IsNullOrWhiteSpace(pagamento.tipo))
            {
                return BadRequest(new { message = "O campo 'tipo' é obrigatório." });
            }

            _context.DimPagamentos.Add(pagamento);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetPagamento), new { id = pagamento.codigo_pagamento }, pagamento);
        }

        // DELETE: api/Pagamento/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeletePagamento(int id)
        {
            var pagamento = await _context.DimPagamentos.FindAsync(id);
            if (pagamento == null)
            {
                return NotFound(new { message = $"Pagamento com ID {id} não encontrado para exclusão." });
            }

            _context.DimPagamentos.Remove(pagamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        // Método auxiliar para verificar existência
        private bool PagamentoExists(int id)
        {
            return _context.DimPagamentos.Any(e => e.codigo_pagamento == id);
        }
    }
}
