using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login_Singup
{
    public class Usuarios
    {
        // Propiedades del usuario
        public string NombreUser { get; set; }
        public string Nombre { get; set; }
        public string Mail { get; set; }
        public int Edad { get; set; }
        public string Telefono { get; set; }
        public string Pass { get; set; }

        // Constructor
        public Usuarios(string nombreuser, string nombre, string mail, int edad, string telefono, string pass)
        {
            NombreUser = nombreuser;
            Nombre = nombre;
            Mail = mail;
            Edad = edad;
            Pass = pass;
            Telefono = telefono;
        }
    }
}

