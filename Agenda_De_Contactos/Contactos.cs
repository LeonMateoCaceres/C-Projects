using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda_De_Contactos
{
    public class Contactos
    {
        public string Nombre { get; set; }
        public int Telefono { get; set; }
        public string Correo {  get; set; }

        public Contactos (string nombre, int telefono, string correo)
        {
            Nombre = nombre;
            Telefono = telefono;
            Correo = correo;
        }
    }
}
