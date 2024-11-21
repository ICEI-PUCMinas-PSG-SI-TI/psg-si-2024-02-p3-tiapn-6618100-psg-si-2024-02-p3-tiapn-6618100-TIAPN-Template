using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("dim_turma")]
public class DimTurma
{
    [Key]
    public int codigo_turma { get; set; }
    public string nome { get; set; }
    public int sala { get; set; }
    public TimeSpan horario { get; set; }
}