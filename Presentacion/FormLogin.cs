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
    public partial class FormLogin : Form
    {
        Servicio_Ciente servicio_Ciente = new Servicio_Ciente(ConfigConnection.ConnectionString);
        Login login = new Login();
        public FormLogin()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormRegistrar fr = new FormRegistrar();
            fr.Show();
            this.Hide();
        }

        private void Btn_Ingresar_Click(object sender, EventArgs e)
        {
            FormGerencia gerencia = new FormGerencia();
            FormInicio inicio = new FormInicio();
            login.Usuario = txtUsuario.Text;
            login.Contraseña = txtContraseña.Text;
            Label nombre = inicio.EnviarNombre();
            Label documento = inicio.Documento();
            //Aquí puedo cambiar el usuario y la contraseña de administrador 
            if (txtUsuario.Text=="admin" && txtContraseña.Text=="admin")
            {
                gerencia.Show();
                this.Hide();
            }
            else
            {
                if(servicio_Ciente.IniciarSesion(inicio, login, nombre, documento) == true)
                {
                    this.Hide();
                }
            }
        }
    }
}
