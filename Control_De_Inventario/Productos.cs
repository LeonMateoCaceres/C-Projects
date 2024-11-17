using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Control_De_Inventario
{
    public class Productos
    {
        string Nombre { get; set; }
        decimal Precio { get; set; }
        int Cantidad { get; set; }
        decimal Total {  get; set; }

        public Productos (string nombre, decimal precio, int cantidad, decimal total)
        {
            Nombre = nombre;
            Precio = precio;
            Cantidad = cantidad;
            Total = total;
        }
    }
}
