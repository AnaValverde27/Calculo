using System;
using System.Globalization;
using System.Web.UI;

namespace calculo
{
    public partial class Coseno : Page
    {
        protected void CalcularCoseno_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(gradosInput.Text))
            {
                resultadoTexto.InnerText = "El campo de grados está vacío.";
                return;
            }

            // Obtener el valor de los grados ingresados
            double grados;
            if (!double.TryParse(gradosInput.Text, out grados))
            {
                resultadoTexto.InnerText = "El valor ingresado no es válido.";
                return;
            }

            // Validar que el valor esté entre 0 y 360
            if (grados < 0 || grados > 360)
            {
                resultadoTexto.InnerText = "El valor de los grados debe estar entre 0 y 360.";
                return;
            }

            // Calcular el coseno del ángulo
            double resultado = Math.Cos(grados * Math.PI / 180);
            string resultadoFormateado = resultado.ToString("F", CultureInfo.InvariantCulture);
            // Mostrar el resultado
            resultadoTexto.InnerText = $"El coseno de {grados} grados es {resultadoFormateado}";

            // Llamar a la función de JavaScript y pasarle el resultado
            string script = $"generarGrafico({resultadoFormateado});";
            ScriptManager.RegisterStartupScript(this, GetType(), "GenerarGrafico", script, true);
        }

    }
}
