using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace BodyShape_TI.Entities
{
    public static class Util
    {
        #region ATRIBUTOS
        #endregion

        #region MÉTODOS
        public static bool validarCEP(string cep)
        {
            var regex = new Regex(@"^\d{8}");
            return regex.IsMatch(cep);
        }

        public static string ConverterParaDecimal(string campoAConverter)
        {
            if (string.IsNullOrWhiteSpace(campoAConverter))
                return "0.00"; 
            try
            {
                string campoNormalizado = campoAConverter.Replace(',', '.').Trim();

                double valorDecimal = double.Parse(campoNormalizado, System.Globalization.CultureInfo.InvariantCulture);

                return valorDecimal.ToString("F2", System.Globalization.CultureInfo.InvariantCulture);
            }
            catch (FormatException)
            {
                return "0.00";
            }
            catch (OverflowException)
            {
                return "0.00";
            }
        }

        public static void PermitirSomenteNumeros(KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != ',' && e.KeyChar != '.' && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        #endregion
    }
}