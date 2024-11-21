using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("fato_agendamentoaula")]
public class FatoAgendamentoAula
{
    [Key]
    public int codigo_agendamento { get; set; }
    public int codigo_turma { get; set; }
    public int codigo_professor { get; set; }
    public int codigo_tempo { get; set; }
    public int codigo_administrador { get; set; }
    public string tipo_administrador { get; set; }
    public string descricao { get; set; }
}