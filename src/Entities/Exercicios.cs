using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace BodyShape_TI.Entities
{
    public class Exercicios
    {
        [Required(ErrorMessage = "O nome do exercício é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "NomeExercicio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo repetições é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Repeticoes")]
        public string Repeticoes { get; set; }

        [Required(ErrorMessage = "O campo intervalo é obrigatório", AllowEmptyStrings = false)]
        [Display(Name = "Intervalo")]
        public string Intervalo { get; set; }

        public Exercicios() { }

        public Exercicios(string Nome, string Repeticoes, string Intervalo)
        {
            this.Nome = Nome;
            this.Repeticoes = Repeticoes;
            this.Intervalo = Intervalo;
        }
    }
}
