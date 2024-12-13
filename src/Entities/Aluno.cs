using System;
using System.ComponentModel.DataAnnotations;

public class Aluno
{
    [Required(ErrorMessage = "O ID é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "ID")]
    public int Id { get; set; }

    [Required(ErrorMessage = "O nome é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Nome")]
    public string Nome { get; set; }

    [Required(ErrorMessage = "A data de nascimento é obrigatória", AllowEmptyStrings = false)]
    [Display(Name = "DataNascimento")]
    public DateTime DataNascimento { get; set; }

    [Required(ErrorMessage = "O sexo é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Sexo")]
    public char Sexo { get; set; }

    [Required(ErrorMessage = "O logradouro é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Logradouro")]
    public string Logradouro { get; set; }

    [Required(ErrorMessage = "O número é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Numero")]
    public int Numero { get; set; }

    [Display(Name = "Complemento")]
    public string Complemento { get; set; }

    [Required(ErrorMessage = "O bairro é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Bairro")]
    public string Bairro { get; set; }

    [Required(ErrorMessage = "A cidade é obrigatória", AllowEmptyStrings = false)]
    [Display(Name = "Cidade")]
    public string Cidade { get; set; }

    [Required(ErrorMessage = "O estado é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Estado")]
    public string Estado { get; set; }

    [Required(ErrorMessage = "O telefone é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "Telefone")]
    public string Telefone { get; set; }

    [Required(ErrorMessage = "O ID do atendente é obrigatório", AllowEmptyStrings = false)]
    [Display(Name = "AtendenteFuncionarioId")]
    public int AtendenteFuncionarioId { get; set; }

    public Aluno() { }

    public Aluno(int id, string nome, DateTime dataNascimento, char sexo, string logradouro, int numero,
        string complemento, string bairro, string cidade, string estado, string telefone, int atendenteFuncionarioId)
    {
        Id = id;
        Nome = nome;
        DataNascimento = dataNascimento;
        Sexo = sexo;
        Logradouro = logradouro;
        Numero = numero;
        Complemento = complemento;
        Bairro = bairro;
        Cidade = cidade;
        Estado = estado;
        Telefone = telefone;
        AtendenteFuncionarioId = atendenteFuncionarioId;
    }
}
