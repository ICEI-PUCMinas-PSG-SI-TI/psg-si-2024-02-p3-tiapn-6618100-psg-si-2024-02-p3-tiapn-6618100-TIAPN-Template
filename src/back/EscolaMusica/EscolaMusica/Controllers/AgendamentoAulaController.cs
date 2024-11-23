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
    public class AgendamentoAulaController : ControllerBase
    {
        private readonly EscolaDbContext _context;

        public AgendamentoAulaController(EscolaDbContext context)
        {
            _context = context;
        }

        // GET: api/AgendamentoAula
        [HttpGet]
        public async Task<ActionResult<IEnumerable<FatoAgendamentoAula>>> GetAgendamentosAula()
        {
            return await _context.FatoAgendamentosAula
                .Include(a => a.turma) 
                .Include(a => a.professor) 
                .Include(a => a.horario) 
                .Include(a => a.administrador) 
                .AsNoTracking()
                .ToListAsync();
        }

        // GET: api/AgendamentoAula/5
        [HttpGet("{id}")]
        public async Task<ActionResult<FatoAgendamentoAula>> GetAgendamentoAula(int id)
        {
            var agendamento = await _context.FatoAgendamentosAula
                .Include(a => a.turma)
                .Include(a => a.professor)
                .Include(a => a.horario)
                .Include(a => a.administrador)
                .AsNoTracking()
                .FirstOrDefaultAsync(a => a.codigo_agendamento == id);

            if (agendamento == null)
            {
                return NotFound(new { message = $"Agendamento com ID {id} não encontrado." });
            }

            return agendamento;
        }

        // PUT: api/AgendamentoAula/5
        [HttpPut("{id}")]
        public async Task<IActionResult> PutAgendamentoAula(int id, FatoAgendamentoAula agendamentoAula)
        {
            if (id != agendamentoAula.codigo_agendamento)
            {
                return BadRequest(new { message = "O ID fornecido não corresponde ao ID do agendamento." });
            }

            _context.Entry(agendamentoAula).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!AgendamentoAulaExists(id))
                {
                    return NotFound(new { message = $"Agendamento com ID {id} não encontrado para atualização." });
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: api/AgendamentoAula
        [HttpPost]
        public async Task<ActionResult<FatoAgendamentoAula>> PostAgendamentoAula(FatoAgendamentoAula agendamentoAula)
        {
            // Validações adicionais podem ser inseridas aqui
            if (agendamentoAula.codigo_turma <= 0 || agendamentoAula.codigo_professor <= 0 || agendamentoAula.codigo_horario <= 0)
            {
                return BadRequest(new { message = "Os campos de Turma, Professor e Tempo são obrigatórios." });
            }

            _context.FatoAgendamentosAula.Add(agendamentoAula);
            await _context.SaveChangesAsync();

            return CreatedAtAction(nameof(GetAgendamentoAula), new { id = agendamentoAula.codigo_agendamento }, agendamentoAula);
        }

        // DELETE: api/AgendamentoAula/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAgendamentoAula(int id)
        {
            var agendamento = await _context.FatoAgendamentosAula.FindAsync(id);
            if (agendamento == null)
            {
                return NotFound(new { message = $"Agendamento com ID {id} não encontrado para exclusão." });
            }

            _context.FatoAgendamentosAula.Remove(agendamento);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool AgendamentoAulaExists(int id)
        {
            return _context.FatoAgendamentosAula.Any(e => e.codigo_agendamento == id);
        }
    }
}
