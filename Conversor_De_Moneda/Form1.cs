using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Conversor_De_Moneda
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void calcular_USD_EUR_BTN_Click(object sender, EventArgs e)
        {
            double moneda = 0;
            double valorDolar = 0;
            double valorEuro = 0;

            bool validarMoneda = double.TryParse(EUR_O_USD_TXT.Text, out moneda);

            if (!validarMoneda)
            {
                MessageBox.Show("Ingrese un valor numérico por favor", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(EUR_O_USD_TXT.Text))
            {
                MessageBox.Show("No puede dejar el campo vacío", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (USD_A_ARS_CB.Checked)
            {
                valorDolar = moneda * 1001.80;
                resultado_USD_EUR_LBL.Text = ("Resultado: " + valorDolar);
            }
            else if (EUR_A_ARS_CB.Checked)
            {
                valorEuro = moneda * 1056.44;
                resultado_USD_EUR_LBL.Text = ("Resultado: " + valorEuro);
            }
        }
    }
}
