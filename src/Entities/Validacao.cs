using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BodyShape_TI.Entities
{
    public static class Validacao
    {
        #region ATRIBUTOS
        #endregion

        #region MÉTODOS
        public static bool validarCEP(string cep)
        {
            var regex = new Regex(@"^\d{8}");
            return regex.IsMatch(cep);
        }
        #endregion
    }
}