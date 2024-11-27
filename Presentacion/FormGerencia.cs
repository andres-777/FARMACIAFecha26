using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentacion
{
    public partial class FormGerencia : Form
    {
        Servicio_Ciente servicio_Ciente = new Servicio_Ciente(ConfigConnection.ConnectionString);
        ServicioFinanzas servicio_finanzas = new ServicioFinanzas(ConfigConnection.ConnectionString);
        ServicioProducto servicio_producto = new ServicioProducto(ConfigConnection.ConnectionString);
        public FormGerencia()
        {
            InitializeComponent();
            Cargar_Tabla();
            Contadores();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
        }
        private void Cargar_Tabla()
        {          
            Dtv_Clientes.DataSource = servicio_Ciente.GetClientes();
            Dtv_Finanzas.DataSource = servicio_finanzas.GetFinanzas();
            //Dtv_ComprasRealizadas.DataSource = servicio_Finanzas();
        }
        public void Imprimir()
           
        {
            
        }
        public void Contadores()
        {
            Lbl_Total_Ingresos.Text = servicio_finanzas.Total_Ingresos();
        }

        private void Btn_Clientes_Click(object sender, EventArgs e)
        { 
            Pnl_Finanzas.Visible = false;
        }

        private void Btn_Finanzas_Click(object sender, EventArgs e)
        {
            Pnl_Finanzas.Visible = true;
        }

        private void Dtv_Clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            servicio_Ciente.Buscar_Tablas(Txt_ID, Dtv_Clientes, "Documento", e);
            Dtv_ComprasRealizadas.DataSource = servicio_finanzas.GetAllProductos_Cliente(Txt_ID.Text);
        }

        private void Btn_GenerarPDF_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Borrar_Click(object sender, EventArgs e)
        {

        }
          
    }
}
