using System.Text.Json;

namespace BodyShape_TI.Entities
{
    public static class CEP
    {
        #region ATRIBUTOS
        private static readonly HttpClient httpClient = new HttpClient();
        #endregion

        #region MÉTODOS
        public static Endereco BuscarCEP(string cep)
        {
            try
            {
                if (!Validacao.validarCEP(cep))
                {
                    throw new ArgumentException("CEP inválido.");
                }

                HttpResponseMessage httpResponse = httpClient.GetAsync($"https://viacep.com.br/ws/{cep}/json/").Result;

                if (!httpResponse.IsSuccessStatusCode)
                {
                    throw new HttpRequestException($"Erro ao consultar CEP: {httpResponse.StatusCode}");
                }

                string jsonResponse = httpResponse.Content.ReadAsStringAsync().Result;

                var dados = JsonSerializer.Deserialize<Endereco>(jsonResponse, new JsonSerializerOptions
                {
                    PropertyNameCaseInsensitive = true 
                });

                if (dados == null || string.IsNullOrEmpty(dados.Cep))
                {
                    throw new Exception("CEP não encontrado.");
                }

                return dados;
            }
            catch (Exception ex)
            {
                throw new Exception("Erro ao consultar CEP: " + ex.Message, ex);
            }
        }
        #endregion
    }
}
