using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Login_Singup
{
    public partial class registroFRM : Form
    {
        public registroFRM()
        {
            InitializeComponent();
        }

        
        private void signupBTN_Click(object sender, EventArgs e)
        {
            double edad;
            bool esValido = double.TryParse(edadTXT.Text, out edad);
            string mail = mailTXT.Text;

            if (string.IsNullOrWhiteSpace(nombreUsuarioSignupTXT.Text)
                || string.IsNullOrWhiteSpace(nombreTXT.Text)
                || string.IsNullOrWhiteSpace(mailTXT.Text)
                || string.IsNullOrWhiteSpace(edadTXT.Text)
                || string.IsNullOrWhiteSpace(telefonoTXT.Text)
                || string.IsNullOrWhiteSpace(passwordTXT.Text)
                )
            {
                MessageBox.Show("Debe rellenar todos los campos con sus datos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!esValido)
            {
                MessageBox.Show("La edad debe ser un número", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (!mail.Contains("@"))
            {
                MessageBox.Show("El correo debe contener un '@'.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Usuarios nuevoUsuario = new Usuarios(
                    nombreUsuarioSignupTXT.Text,
                    nombreTXT.Text,
                    mailTXT.Text,
                    int.Parse(edadTXT.Text),
                    telefonoTXT.Text,
                    passwordTXT.Text
                );

                if (Data.BD.Exists(u => u.NombreUser == nuevoUsuario.NombreUser))
                {
                    MessageBox.Show("El nombre de usuario ya está registrado.");
                    return;
                }

                Data.BD.Add(nuevoUsuario);
                MessageBox.Show("¡Usuario registrado exitosamente!", "Exitoso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                nombreUsuarioSignupTXT.Clear();
                nombreTXT.Clear();
                mailTXT.Clear();
                edadTXT.Clear();
                telefonoTXT.Clear();
                passwordTXT.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }

        }

        private void iniciarSesionBTN_Click(object sender, EventArgs e)
        {
            loginFRM login = new loginFRM();
            login.Show();
        }

        private void passwordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCB.Checked)
            {
                passwordTXT.PasswordChar = '\0'; // Mostrar texto plano
            }
            else
            {
                passwordTXT.PasswordChar = '*'; // Enmascarar con asteriscos
            }
        }
    }
}
