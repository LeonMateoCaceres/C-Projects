using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Control_De_Inventario
{
    public partial class frmStock : Form
    {
        public frmStock()
        {
            InitializeComponent();
        }
        private void frmStock_Load(object sender, EventArgs e)
        {
            dgvInventario.ColumnCount = 4; // Número de columnas
            dgvInventario.Columns[0].Name = "Producto";
            dgvInventario.Columns[1].Name = "Precio";
            dgvInventario.Columns[2].Name = "Cantidad";
            dgvInventario.Columns[3].Name = "Total";

            dgvInventario.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvInventario.AllowUserToAddRows = false; // Desactiva la fila extra al final
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            decimal precio = 0;
            int cantidad = 0;
            bool esPrecioValido = decimal.TryParse(txtPrecio.Text, out precio);
            bool esCantidadValida = int.TryParse(txtCantidad.Text, out cantidad);

            if (string.IsNullOrWhiteSpace(txtNombre.Text) || 
                string.IsNullOrWhiteSpace(txtPrecio.Text) || 
                string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Todos los campos son obligatorios", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!esCantidadValida) || (cantidad < 0))
            {
                MessageBox.Show("Los precios y las cantidades deben ser números y no pueden valer cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if ((!esPrecioValido) || (precio < 0))
            {
                MessageBox.Show("Los precios y las cantidades deben ser números y no pueden valer cero", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            decimal total = 0;

            total = precio * cantidad;

            dgvInventario.Rows.Add(nombre, precio, cantidad, total);

            txtNombre.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvInventario.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvInventario.SelectedRows)
                {
                    dgvInventario.Rows.Remove(row);
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una fila para eliminar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            decimal totalInventario = 0;

            foreach (DataGridViewRow row in dgvInventario.Rows)
            {
                if (row.Cells[3].Value != null)
                {
                    totalInventario += Convert.ToDecimal(row.Cells[3].Value);
                }
            }

            lblTotal.Text = ("Precio total del inventario: " + totalInventario);
        }
    }
}
