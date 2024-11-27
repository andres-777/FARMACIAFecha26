using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Login
    {
        
        public Login() { }
        public string Documento { get; set; }
        public string Nombre_Completo { get; set; }
        public DateTime Fecha_Nacimineto { get; set; }
        public string Usuario { get; set; }
        public string Contraseña { get; set; }
        public string Telefono { get; set; }

        public Login(string documento, string nombre_Completo, DateTime fecha_Nacimineto, string usuario, string contraseña, string telefono)
        {
            Documento = documento;
            Nombre_Completo = nombre_Completo;
            Fecha_Nacimineto = fecha_Nacimineto;
            Usuario = usuario;
            Contraseña = contraseña;
            Telefono = telefono;
        }

    }
}
