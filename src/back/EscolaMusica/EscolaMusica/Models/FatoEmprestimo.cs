using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("fato_emprestimo")]
public class FatoEmprestimo
{
    [Key]
    public int codigo_emprestimo { get; set; }
    public int codigo_instrumento { get; set; }
    public int codigo_aluno { get; set; }
    public int codigo_tempo_emprestimo { get; set; }
    public int? codigo_tempo_devolucao { get; set; }
    public int codigo_administrador { get; set; }
    public string tipo_administrador { get; set; }
    public string status { get; set; }
    public string descricao { get; set; }
}