using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tarea_1_SumasYRestas
{
    public partial class Calculadora_Basica_Form : Form
    {
        decimal numero_1 = 0;
        decimal numero_2 = 0;
        
        public Calculadora_Basica_Form()
        {
            InitializeComponent();
        }

        private void Numero1TXT_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void SumarBTN_Click(object sender, EventArgs e)
        {
            decimal suma = 0;
            bool numeroValido1 = decimal.TryParse(Numero1TXT.Text, out numero_1);
            bool numeroValido2 = decimal.TryParse(Numero2TXT.Text, out numero_2);

            if (!numeroValido1 || !numeroValido2)
            {
                MessageBox.Show("Ingrese un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Numero1TXT.Text) || string.IsNullOrWhiteSpace(Numero2TXT.Text))
            {
                MessageBox.Show("Por favor, ingresa ambos números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            suma = numero_1 + numero_2;

            ResultadoLBL.Text = Convert.ToString(suma);
        }

        private void RestarBTN_Click(object sender, EventArgs e)
        {
            decimal resta = 0;
            bool numeroValido1 = decimal.TryParse(Numero1TXT.Text, out numero_1);
            bool numeroValido2 = decimal.TryParse(Numero2TXT.Text, out numero_2);

            if (!numeroValido1 || !numeroValido2)
            {
                MessageBox.Show("Ingrese un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (string.IsNullOrWhiteSpace(Numero1TXT.Text) || string.IsNullOrWhiteSpace(Numero2TXT.Text))
            {
                MessageBox.Show("Por favor, ingresa ambos números.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            resta = numero_1 - numero_2;

            ResultadoLBL.Text = Convert.ToString(resta);
        }

        private void ResultadoLBL_Click(object sender, EventArgs e)
        {
            
        }
    }
}
