using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[Table("dim_administrador")]
public class DimAdministrador
{
    [Key] public int codigo_administrador { get; set; }
    public string nome { get; set; }
    public string contato { get; set; }
    public string tipo { get; set; }
}