using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("dim_estoque")]
public class DimEstoque
{
    [Key]
    public int codigo_estoque { get; set; }
    public string localizacao { get; set; }
    public int quantidade { get; set; }
}