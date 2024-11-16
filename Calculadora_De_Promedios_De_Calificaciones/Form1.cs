using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_De_Promedios_De_Calificaciones
{
    public partial class CalculadoraDePromediosForm : Form
    {
        public CalculadoraDePromediosForm()
        {
            InitializeComponent();
        }

        List<double> calificaciones = new List<double>();

        private void agregarBTN_Click(object sender, EventArgs e)
        {
            double nota;
            bool esValido = double.TryParse(notasTXT.Text, out nota);

            if (string.IsNullOrWhiteSpace(notasTXT.Text) || (!esValido))
            {
                MessageBox.Show("Por favor, ingrese una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((nota > 100) || (nota < 0))
            {
                MessageBox.Show("Por favor, ingrese una nota mayor a 0 y menor a 100", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            calificaciones.Add(nota);
            notasLISTB.Items.Add(nota);
            notasTXT.Clear();
            
        }

        private void calcularBTN_Click(object sender, EventArgs e)
        {
            double promedio = calificaciones.Average();
            double maximo = calificaciones.Max();
            double min = calificaciones.Min();

            if (calificaciones.Count == 0)
            {
                MessageBox.Show("Por favor, ingrese al menos una nota", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            promedioLBL.Text = ("Promedio: " + promedio);
            altoLBL.Text = ("Calificación más alta: " + maximo);
            bajoLBL.Text = ("Calificación más baja: " + min);
            
        }
    }
}
