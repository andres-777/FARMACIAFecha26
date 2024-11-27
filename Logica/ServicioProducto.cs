using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Logica
{
    public class ServicioProducto 
    {
        Datos.RepositorioProductos repositorioProductos;
        public ServicioProducto(string connectionString)
        {
            repositorioProductos = new Datos.RepositorioProductos(connectionString);
        }
        public void Insertar(Productos productos)
        {
            repositorioProductos.Insert(productos);
        }

        public void Cerrar_Celda(Label nombre_producto, Label precio_producto, PictureBox imagen_producto, Panel celda, Label nombre_celda, Label precio_celda, PictureBox imagen_celda, Label estado_celda1, Label estado_celda2, Label estado_celda3, Label estado_celda4, Label estado_celda5)
        {
            celda.Visible = false;
            nombre_celda.Text = nombre_producto.Text;
            precio_celda.Text = precio_producto.Text;
            imagen_celda = imagen_producto;
            estado_celda1.Text = "Disponible";
            //Mover_Celdas(nombre_producto, precio_producto, imagen_producto, celda, nombre_celda, precio_celda, imagen_celda, estado_celda1, estado_celda2, estado_celda3, estado_celda4, estado_celda5);

        }
        public void Mover_Celdas(Label nombre_producto, Label precio_producto, PictureBox imagen_producto, Panel celda, Label nombre_celda, Label precio_celda, PictureBox imagen_celda, Label estado_celda, Label estado_celda2, Label estado_celda3, Label estado_celda4, Label estado_celda5)
        {
            if (estado_celda.Text == "Disponible")
            {

            }
            else if (estado_celda2.Text == "Disponible")
            {

            }
            else if (estado_celda3.Text == "Disponible")
            {

            }
            else if (estado_celda4.Text == "Disponible")
            {

            }
            else if (estado_celda5.Text == "Disponible")
            {

            }
        }
        public int ObtenerTotal(int producto1, int producto2, int producto3, int producto4, int producto5)
        {
            int Total=0;
            Total = producto1 + producto2 + producto3 + producto4 + producto5;
            return Total;          
        }
        public DataTable GetClientes()
        {
            return repositorioProductos.GetAllTabla();
        }
    }
}
