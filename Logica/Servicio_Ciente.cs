using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class Servicio_Ciente
    {
        Datos.RepositorioLogin repositorioLogin;
        public Servicio_Ciente(string connectionString)
        {
            repositorioLogin = new Datos.RepositorioLogin(connectionString);
        }
        public void Insert(Login login)
        {
            repositorioLogin.Insert(login);
        }
        public bool IniciarSesion(Form menu,Login login,Label nombre,Label Documento)
        {
            try
            {
                if (Buscar_Cuenta(nombre, login, Documento) == true)
                {
                    menu.Show();
                    MessageBox.Show("Sesion Iniciada");
                    return true;
                }
                else
                {
                    MessageBox.Show("Usuario o Contraseña incorrecto");
                    return false;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Iniciar Sesion");
                return false;
            }
         
        }
        public void Registrarse(Login login)
        {
            try
            {
                repositorioLogin.Insert(login);
            }
            catch (Exception)
            {
                MessageBox.Show("Error al Registrar");
            }
        }
        
        public bool Buscar_Cuenta(Label nombre,Login login,Label Documento)
        {
            bool Verificar = false;
            foreach (var item in GetAll())
            {
                if (item.Usuario.Equals(login.Usuario)&&item.Contraseña.Equals(login.Contraseña))
                {
                    nombre.Text = item.Nombre_Completo;
                    Documento.Text = item.Documento;
                    Verificar = true;
                }
            }
            return Verificar;
        }
        public string Informacion_Celda(DataGridViewRow fila, string nombreColumna)
        {
            if (fila != null && fila.Cells[nombreColumna] != null)
            {
                object valorCelda = fila.Cells[nombreColumna].Value;
                return valorCelda != null ? valorCelda.ToString() : string.Empty;
            }
            return string.Empty;
        }
        public void Buscar_Tablas(TextBox text, DataGridView tabla, string dato, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                string valorCelda = Informacion_Celda(tabla.Rows[e.RowIndex], dato);
                text.Text = valorCelda;
            }
        }

        public List<Login> GetAll()
        {
            return repositorioLogin.GetAll();
        }
        public DataTable GetClientes()
        {
            return repositorioLogin.GetAllTabla();
        }
    }
}
