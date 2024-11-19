using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda_De_Contactos
{
    public partial class frmAgenda : Form
    {
        List<Contactos> BD = new List<Contactos>();
        public frmAgenda()
        {
            
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            int telefono = 0;
            string correo = txtCorreo.Text;
            bool esValidoNumero = int.TryParse(txtTelefono.Text, out telefono);

            if (string.IsNullOrWhiteSpace(txtNombre.Text)
                || string.IsNullOrWhiteSpace(txtTelefono.Text)
                || string.IsNullOrWhiteSpace(correo))
            {
                MessageBox.Show("Debe rellenar todos los campos con sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!esValidoNumero)
            {
                MessageBox.Show("El teléfono debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!correo.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un '@'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Contactos contacto = new Contactos(
                    txtNombre.Text,
                    telefono,
                    correo
                );

                if (BD.Exists(u => u.Telefono == contacto.Telefono))
                {
                    MessageBox.Show("El Teléfono ya está registrado.");
                    return;
                }

                // Agrega el nuevo contacto a la lista y al ListBox
                BD.Add(contacto);
                lbAgenda.Items.Add($"{contacto.Nombre}, {contacto.Telefono}, {contacto.Correo}");

                // Limpia los campos
                txtNombre.Clear();
                txtTelefono.Clear();
                txtCorreo.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (lbAgenda.SelectedIndex != -1) // Verificar si hay un elemento seleccionado
            {
                int selectedIndex = lbAgenda.SelectedIndex;

                //cuadro de confirmación antes de eliminar
                DialogResult confirmacion = MessageBox.Show(
                    "¿Estás seguro de que deseas eliminar este contacto?",
                    "Confirmar eliminación",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning
                );

                if (confirmacion == DialogResult.Yes)
                {
                    // Eliminar de la lista de datos
                    BD.RemoveAt(selectedIndex);

                    // Eliminar del ListBox
                    lbAgenda.Items.RemoveAt(selectedIndex);

                    MessageBox.Show("Contacto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                // Mensaje si no hay selección
                MessageBox.Show("Por favor, selecciona un contacto para eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
