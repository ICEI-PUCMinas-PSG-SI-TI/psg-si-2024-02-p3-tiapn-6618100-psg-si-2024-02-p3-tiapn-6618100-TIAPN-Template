using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("fato_matricula")]
public class FatoMatricula
{
    [Key] public int codigo_matricula { get; set; }

    [Required] public int codigo_aluno { get; set; }

    [Required] public int codigo_turma { get; set; }

    [Required] public int codigo_pagamento { get; set; }

    [Required] public int codigo_administrador { get; set; }

    [Required] public DateTime data_inicio { get; set; }

    [Required] public string status { get; set; }


    [ForeignKey("codigo_aluno")] public DimAluno aluno { get; set; }

    [ForeignKey("codigo_turma")] public DimTurma turma { get; set; }

    [ForeignKey("codigo_pagamento")] public DimPagamento pagamento { get; set; }

    [ForeignKey("codigo_administrador")] public DimAdministrador administrador { get; set; }
}