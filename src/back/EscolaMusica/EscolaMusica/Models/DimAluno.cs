using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("dim_aluno")]
public class DimAluno
{
    [Key]
    public int codigo_aluno { get; set; }
    public string nome { get; set; }
    public string matricula { get; set; }
    public string endereco { get; set; }
}