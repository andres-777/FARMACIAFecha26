using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Productos : Login
    { 
        public Productos() { }
        public string Nombre_Producto { get; set; }
        public int Precio_Total { get; set; }

        public Productos(string documento,string nombre_Producto, int precio_total)
        {
            Documento = documento;  
            Nombre_Producto = nombre_Producto;
            Precio_Total = precio_total;
        }
    }
}
