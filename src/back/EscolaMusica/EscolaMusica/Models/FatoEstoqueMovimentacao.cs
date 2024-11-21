using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("fato_estoquemovimentacao")]
public class FatoEstoqueMovimentacao
{
    [Key]
    public int codigo_movimentacao { get; set; }
    public int codigo_estoque { get; set; }
    public int codigo_tempo { get; set; }
    public int codigo_administrador { get; set; }
    public string tipo_administrador { get; set; }
    public string tipo_movimentacao { get; set; }
    public int quantidade { get; set; }
}