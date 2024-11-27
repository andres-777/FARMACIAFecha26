using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormRegistrar : Form
    {
        Servicio_Ciente servicio_Ciente = new Servicio_Ciente(ConfigConnection.ConnectionString);
        Login login = new Login();
        public FormRegistrar()
        {
            InitializeComponent();
        }
        private void Volver_Login()
        {
            FormLogin fl = new FormLogin();
            fl.Show();
            this.Close();
        }

        private void BtnVolver_Click(object sender, EventArgs e)
        {
            Volver_Login();
        }

        private void BtnRegistrar_Click(object sender, EventArgs e)
        {
            login.Documento = txtDocumento.Text;
            login.Nombre_Completo = txtNombreUsuario.Text;
            login.Fecha_Nacimineto = DateTime.Parse(Dtm_FechaN.Text);
            login.Usuario = txtUsuario.Text;
            login.Contraseña = txtContraseña.Text;
            login.Telefono = TxtTelefono.Text;
            servicio_Ciente.Insert(login);
            Volver_Login();
            Vacias_Casillas();
        }
        private void Vacias_Casillas()
        {
            login.Documento = "";
            login.Nombre_Completo = "";
            login.Fecha_Nacimineto = DateTime.Now;
            login.Usuario = "";
            login.Contraseña = "";
            login.Telefono = "";
        }
    }
}
