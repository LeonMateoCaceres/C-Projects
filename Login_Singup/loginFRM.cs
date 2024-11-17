using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login_Singup;

namespace Login_Singup
{
    public partial class loginFRM : Form
    {
        public loginFRM()
        {
            InitializeComponent();
        }

        
        private void registrarseBTN_Click(object sender, EventArgs e)
        {
            registroFRM registro = new registroFRM();
            registro.Show();
        }

        private void ingresarBTN_Click(object sender, EventArgs e)
        {
            string nombre = nombreUsuarioLoginTXT.Text;
            string password = passwordLoginTXT.Text;

            if(string.IsNullOrWhiteSpace(nombreUsuarioLoginTXT.Text) || (string.IsNullOrWhiteSpace(passwordLoginTXT.Text)))
            {
                MessageBox.Show("Ingrese nombre de usuario o contraseña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Usuarios usuarioEncontrado = Data.BD.Find(u => u.NombreUser == nombre && u.Pass == password);

            if (usuarioEncontrado != null)
            {
                MessageBox.Show($"¡Bienvenido, {usuarioEncontrado.Nombre}!");
                nombreUsuarioLoginTXT.Clear();
                passwordLoginTXT.Clear();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrectos.");
            }
        }

        private void passwordCB_CheckedChanged(object sender, EventArgs e)
        {
            if (passwordCB.Checked)
            {
                passwordLoginTXT.PasswordChar = '\0';
            }
            else
            {
                passwordLoginTXT.PasswordChar = '*';
            }
        }
    }
}
