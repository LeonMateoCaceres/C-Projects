using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_De_Temperatura
{
    public partial class conversorDeTemperaturaForm : Form
    {

        public conversorDeTemperaturaForm()
        {
            InitializeComponent();
        }

        private void convertirBTN_Click(object sender, EventArgs e)
        {
            double temperatura = 0;
            double resultado = 0;
            bool numeroValido = double.TryParse(temperaturaTXT.Text, out temperatura);

            if (string.IsNullOrWhiteSpace(temperaturaTXT.Text))
            {
                MessageBox.Show("No puede ingresar campos vacíos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!numeroValido)
            {
                MessageBox.Show("Ingrese un número válido", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (celsiusRB.Checked)
            {
                resultado = (temperatura * 9 / 5) + 32;
                resultadoLBL.Text = ("Resultado: " + resultado);
            }
            else if (fahrenheitRB.Checked)
            {
                resultado = (temperatura - 32) * 5 / 9;
                resultadoLBL.Text = ("Resultado: " + resultado);
            }
            else
            {
                MessageBox.Show("Seleccione una opción de conversión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
