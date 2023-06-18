using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace calculo
{
    public partial class Circulo : System.Web.UI.Page
    {
        protected void CalcularArea_Click(object sender, EventArgs e)
        {
            // Validar que el campo no esté vacío
            if (string.IsNullOrWhiteSpace(radioInput.Text))
            {
                resultadoTexto.InnerText = "El campo de radio está vacío.";
                return;
            }

            // Obtener el valor del área
            double radio;
            if (!double.TryParse(radioInput.Text, out radio))
            {
                resultadoTexto.InnerText = "El valor ingresado no es válido.";
                return;
            }

            // Validar que el valor esté entre 1 y 2600
            if (radio < 1 || radio > 2600)
            {
                resultadoTexto.InnerText = "El valor de los grados debe estar entre 1 y 2600.";
                return;
            }

            // Calcular el área del círculo
            double resultado = Math.PI * Math.Pow(radio, 2);
            // Mostrar el resultado
            resultadoTexto.InnerText = $"El área del circulo con el radio {radio} es {resultado}";

        }
    }
}