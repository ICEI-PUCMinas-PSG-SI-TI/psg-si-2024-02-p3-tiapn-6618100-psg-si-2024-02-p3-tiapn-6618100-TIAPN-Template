using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BodyShape_TI.Entities
{
    public class Endereco
    {
        #region PROPRIEDADES
        public string Logradouro { get; set; }
        public string Complemento { get; set; }
        public string Numero { get; set; }
        public string Bairro { get; set; }
        public string Localidade { get; set; }
        public string UF { get; set; }
        public string Cep { get; set; }
        #endregion

        #region CONSTRUTORES
        public Endereco() { }

        public Endereco(string logradouro, string complemento, string numero, string bairro, string localidade, string uf, string cep)
        {
            Logradouro = logradouro;
            Complemento = complemento;
            Numero = numero;
            Bairro = bairro;
            Localidade = localidade;
            UF = uf;
            Cep = cep;
        }
        #endregion

        #region MÉTODOS
        /// <summary>
        /// Retorna a representação textual completa do endereço formatado.
        /// </summary>
        /// <returns>Uma string com os dados do endereço formatados.</returns>
        public override string ToString()
        {
            // Tratar o caso onde complemento pode estar vazio ou nulo
            string complementoInfo = string.IsNullOrWhiteSpace(Complemento) ? "" : $" - {Complemento}";
            return $"{Logradouro} - {Bairro}, {Localidade}/{UF} ({Cep})";
        }
        #endregion
    }

}
