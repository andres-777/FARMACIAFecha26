using Entidades;
using Logica;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class FormInicio : Form
    {
        // Conectar los servisios con la capa lógica 
        ServicioProducto servicioProducto = new ServicioProducto(ConfigConnection.ConnectionString);
        ServicioFinanzas servicioFinanzas = new ServicioFinanzas(ConfigConnection.ConnectionString);
        Manejo_Formulario mj = new Manejo_Formulario();
        Finanzas finanzas = new Finanzas();
        public FormInicio()
        {
            InitializeComponent();
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
            FormLogin fl = new FormLogin();
            fl.Show();
        }
        public Label EnviarNombre()
        {
            return lblNombre;
        }
        public Label Documento()
        {
            return lbl_Documento;
        }

        //Botones de atras y siguiente
        private void Btn_Siguiente_Click(object sender, EventArgs e)
        {
            mj.Btn_Siguiente(Pnl_Pagina2, Pnl_Pagina3, Pnl_Pagina4, Btn_Anterior, Btn_Siguiente);
        }

        private void Btn_Anterior_Click(object sender, EventArgs e)
        {
            mj.Btn_Anterior(Pnl_Pagina2, Pnl_Pagina3, Pnl_Pagina4, Btn_Anterior, Btn_Siguiente);
        }

        private void Pnl_Pagina4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label67_Click(object sender, EventArgs e)
        {

        }

        private void ImagenProducto_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Comprar2_Click(object sender, EventArgs e)
        {
        }

        //Espacio que hay disponible en el carrito 
        private void button5_Click(object sender, EventArgs e)
        {
            Btn_Siguiente.Visible = false;
            Btn_Anterior.Visible = true;
            btnCarrito1.Visible = false;
            btnCarrito2.Visible = true;
            Pnl_Pagina1.Visible = true;
            Pnl_Pagina2.Visible = true;
            Pnl_Pagina3.Visible = true;
            Pnl_Pagina4.Visible = true;
            panel2.Visible = true;
        }

        private void PrecioProducto1_Click(object sender, EventArgs e)
        {

        }

        private void btnCarrito2_Click(object sender, EventArgs e)
        {
            btnCarrito1.Visible = true;
            btnCarrito2.Visible = false;
            panel2.Visible = false;
        }
        //Botones añadir al carrito 
        private void Btn_Añadir1_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto1.Text, Precio_Producto1.Text, Imagen_producto1);
        }

        private void Btn_Añadir2_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto2.Text, Precio_Producto2.Text, Imagen_producto2);
        }

        private void Btn_Añadir3_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto3.Text, Precio_Producto3.Text, Imagen_producto3);

        }

        private void Btn_Añadir4_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto4.Text, Precio_Producto4.Text, Imagen_producto4);

        }

        private void Btn_Añadir5_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto5.Text, Precio_Producto5.Text, Imagen_producto5);

        }

        private void Btn_Añadir6_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto6.Text, Precio_Producto6.Text, Imagen_producto6);

        }

        private void Btn_Añadir7_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto7.Text, Precio_Producto7.Text, Imagen_producto7);
        }

        private void Btn_Añadir8_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(N_Producto8.Text, Precio_Producto8.Text, Imagen_producto8);
        }

        private void Btn_Añadir9_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto9.Text, Precio_producto9.Text, Imagen_producto9);
        }

        private void Btn_Añadir10_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto10.Text, Precio_producto10.Text, Imagen_producto10);
        }

        private void Btn_Añadir11_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto11.Text, Precio_producto11.Text, Imagen_producto11);
        }

        private void Btn_Añadir12_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto12.Text, Precio_producto12.Text, Imagen_producto12);
        }

        private void Btn_Añadir13_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto13.Text, Precio_producto13.Text, Imagen_producto13);
        }

        private void Btn_Añadir14_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto14.Text, Precio_producto14.Text, Imagen_producto14);
        }

        private void Btn_Añadir15_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto15.Text, Precio_producto15.Text, Imagen_producto15);
        }

        private void Btn_Añadir16_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto16.Text, Precio_producto16.Text, Imagen_producto16);
        }

        private void Btn_Añadir17_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto17.Text, Precio_producto17.Text, Imagen_producto17);
        }

        private void Btn_Añadir18_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto18.Text, Precio_producto18.Text, Imagen_producto18);
        }

        private void Btn_Añadir19_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto19.Text, Precio_producto19.Text, Imagen_producto19);
        }

        private void Btn_Añadir20_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto20.Text, Precio_producto20.Text, Imagen_producto20);
        }

        private void Btn_Añadir21_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto21.Text, Precio_producto21.Text, Imagen_producto21);
        }

        private void Btn_Añadir22_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto22.Text, Precio_producto22.Text, Imagen_producto22);
        }

        private void Btn_Añadir23_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto23.Text, Precio_producto23.Text, Imagen_producto23);
        }

        private void Btn_Añadir24_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto24.Text, Precio_producto24.Text, Imagen_producto24);
        }

        private void Btn_Añadir25_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto25.Text, Precio_producto25.Text, Imagen_producto25);
        }

        private void Btn_Añadir26_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto26.Text, Precio_producto26.Text, Imagen_producto26);
        }

        private void Btn_Añadir27_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto27.Text, Precio_producto27.Text, Imagen_producto27);
        }

        private void Btn_Añadir28_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto28.Text, Precio_producto28.Text, Imagen_producto28);
        }

        private void Btn_Añadir29_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto29.Text, Precio_producto29.Text, Imagen_producto29);
        }

        private void Btn_Añadir30_Click(object sender, EventArgs e)
        {
            Celdas_Disponibles(Nombre_producto30.Text, Precio_producto30.Text, Imagen_producto30);
        }
        // Mira si hay una celda disponible añadir un producto al carrito
        public void Celdas_Disponibles(string nombre_producto, string precio_producto, PictureBox imagen_producto)
        {
            if (lbl_Estado1.Text == "Disponible")
            {
                Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda1, ProductoN1, PrecioProducto1, ImagenProducto, lbl_Estado1);
            }
            else if (lbl_Estado2.Text == "Disponible")
            {
                Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, lbl_Estado2);
            }
            else if (lbl_Estado3.Text == "Disponible")
            {
                Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
            }
            else if (lbl_Estado4.Text == "Disponible")
            {
                Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
            }
            else if (lbl_Estado5.Text == "Disponible")
            {
                Detalles_Producto(nombre_producto, precio_producto, imagen_producto, Celda5, ProductoN5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
            }
            else
            {
                MessageBox.Show("Carrito Lleno");
            }
        }
        //Muestra imagen, nombre y precio del producto 
        public void Detalles_Producto(string nombre_producto, string precio_producto, PictureBox imagen_producto, Panel celda, Label nombre_celda, Label precio_celda, PictureBox imagen_celda, Label estado_celda)
        {
            celda.Visible = true;
            nombre_celda.Text = nombre_producto;
            precio_celda.Text = precio_producto;
            imagen_celda.Image = imagen_producto.Image;
            estado_celda.Text = "Ocupado";
            Lbl_Total.Text = Calcular_Total(PrecioProducto1, PrecioProducto2, PrecioProducto3, PrecioProducto4, PrecioProducto5).ToString();
        }

        public int Calcular_Total(Label precio_celda1, Label precio_celda2, Label precio_celda3, Label precio_celda4, Label precio_celda5)
        {
            if (precio_celda1.Text == "PrecioProducto")
            {
                precio_celda1.Text = "0";
            }
            if (precio_celda2.Text == "PrecioProducto")
            {
                precio_celda2.Text = "0";
            }
            if (precio_celda3.Text == "PrecioProducto")
            {
                precio_celda3.Text = "0";
            }
            if (precio_celda4.Text == "PrecioProducto")
            {
                precio_celda4.Text = "0";
            }
            if (precio_celda5.Text == "PrecioProducto")
            {
                precio_celda5.Text = "0";
            }
            return servicioProducto.ObtenerTotal(int.Parse(precio_celda1.Text), int.Parse(precio_celda2.Text), int.Parse(precio_celda3.Text), int.Parse(precio_celda4.Text), int.Parse(precio_celda5.Text));
        }

        private void EliminarProductoDelCarrito(Panel celda, Label nombre_celda, Label precio_celda, PictureBox imagen_celda, Label estado_celda)
        {
            celda.Visible = false;
            nombre_celda.Text = "NombreProducto";
            precio_celda.Text = "0";
            imagen_celda.Image = null;
            estado_celda.Text = "Disponible";
            Lbl_Total.Text = Calcular_Total(PrecioProducto1, PrecioProducto2, PrecioProducto3, PrecioProducto4, PrecioProducto5).ToString();
        }
        private void MoverCeldas(Panel celda1, Label nombre_celda1, Label precio_celda1, PictureBox imagen_celda1, Panel celda2, Label nombre_celda2, Label precio_celda2, PictureBox imagen_celda2, Label estado_celda)
        {
            celda1.Visible = true;
            celda2.Visible = false;
            nombre_celda1.Text = nombre_celda2.Text;
            precio_celda1.Text = precio_celda2.Text;
            imagen_celda1.Image = imagen_celda2.Image;
            Lbl_Total.Text = Calcular_Total(PrecioProducto1, PrecioProducto2, PrecioProducto3, PrecioProducto4, PrecioProducto5).ToString();
        }
        private void MoverProducto(int boton, Label estado_celda, Label estado_celda2, Label estado_celda3, Label estado_celda4, Label estado_celda5)
        {
            if (boton == 1)
            {
                if (estado_celda2.Text == "Ocupado" && estado_celda3.Text == "Ocupado" && estado_celda4.Text == "Ocupado" && estado_celda5.Text == "Ocupado")
                {
                    PrecioProducto1.Text = "0";
                    MoverCeldas(Celda1, ProductoN1, PrecioProducto1, ImagenProducto, Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, lbl_Estado2);
                    PrecioProducto2.Text = "0";
                    MoverCeldas(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
                    PrecioProducto3.Text = "0";
                    MoverCeldas(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
                    PrecioProducto4.Text = "0";
                    MoverCeldas(Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, Celda5, ProductoN5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
                    PrecioProducto5.Text = "0";
                    estado_celda5.Text = "Disponible";

                }
                else if (estado_celda2.Text == "Ocupado" && estado_celda3.Text == "Ocupado" && estado_celda4.Text == "Ocupado")
                {
                    PrecioProducto1.Text = "0";
                    MoverCeldas(Celda1, ProductoN1, PrecioProducto1, ImagenProducto, Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, lbl_Estado2);
                    PrecioProducto2.Text = "0";
                    MoverCeldas(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
                    PrecioProducto3.Text = "0";
                    MoverCeldas(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
                    PrecioProducto4.Text = "0";
                    estado_celda4.Text = "Disponible";
                }
                else if (estado_celda2.Text == "Ocupado" && estado_celda3.Text == "Ocupado")
                {
                    PrecioProducto1.Text = "0";
                    MoverCeldas(Celda1, ProductoN1, PrecioProducto1, ImagenProducto, Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, lbl_Estado2);
                    PrecioProducto2.Text = "0";
                    MoverCeldas(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
                    PrecioProducto3.Text = "0";
                    estado_celda3.Text = "Disponible";
                }
                else if (estado_celda2.Text == "Ocupado")
                {
                    PrecioProducto1.Text = "0";
                    MoverCeldas(Celda1, ProductoN1, PrecioProducto1, ImagenProducto, Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, lbl_Estado2);
                    PrecioProducto2.Text = "0";
                    estado_celda2.Text = "Disponible";
                }
            }
            else if (boton == 2)
            {
                if (estado_celda3.Text == "Ocupado" && estado_celda4.Text == "Ocupado" && estado_celda5.Text == "Ocupado")
                {
                    PrecioProducto2.Text = "0";
                    MoverCeldas(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
                    PrecioProducto3.Text = "0";
                    MoverCeldas(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
                    PrecioProducto4.Text = "0";
                    MoverCeldas(Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, Celda5, ProductoN5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
                    PrecioProducto5.Text = "0";
                    estado_celda5.Text = "Disponible";

                }
                else if (estado_celda3.Text == "Ocupado" && estado_celda4.Text == "Ocupado")
                {
                    PrecioProducto2.Text = "0";
                    MoverCeldas(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
                    PrecioProducto3.Text = "0";
                    MoverCeldas(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
                    PrecioProducto4.Text = "0";
                    estado_celda4.Text = "Disponible";

                }
                else if (estado_celda3.Text == "Ocupado")
                {
                    PrecioProducto2.Text = "0";
                    MoverCeldas(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
                    PrecioProducto3.Text = "0";
                    estado_celda3.Text = "Disponible";

                }
            }
            else if (boton == 3)
            {
                if (estado_celda4.Text == "Ocupado" && estado_celda5.Text == "Ocupado")
                {
                    PrecioProducto3.Text = "0";
                    MoverCeldas(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
                    PrecioProducto4.Text = "0";
                    MoverCeldas(Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, Celda5, ProductoN5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
                    PrecioProducto5.Text = "0";
                    estado_celda5.Text = "Disponible";

                }
                else if (estado_celda4.Text == "Ocupado")
                {
                    PrecioProducto3.Text = "0";
                    MoverCeldas(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
                    PrecioProducto4.Text = "0";
                    estado_celda4.Text = "Disponible";
                }
            }
            else if (boton == 4)
            {
                if (estado_celda5.Text == "Ocupado")
                {
                    PrecioProducto4.Text = "0";
                    MoverCeldas(Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, Celda5, ProductoN5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
                    PrecioProducto5.Text = "0";
                    estado_celda5.Text = "Disponible";

                }
            }

        }

        private void btn_x1_Click(object sender, EventArgs e)
        {
            EliminarProductoDelCarrito(Celda1, ProductoN1, PrecioProducto1, ImagenProducto, lbl_Estado1);
            MoverProducto(1, lbl_Estado1, lbl_Estado2, lbl_Estado3, lbl_Estado4, lbl_Estado5);
        }

        private void btn_x2_Click(object sender, EventArgs e)
        {
            EliminarProductoDelCarrito(Celda2, ProductoN2, PrecioProducto2, ImagenProducto2, lbl_Estado2);
            MoverProducto(2, lbl_Estado1, lbl_Estado2, lbl_Estado3, lbl_Estado4, lbl_Estado5);
        }

        private void btn_x3_Click(object sender, EventArgs e)
        {
            EliminarProductoDelCarrito(Celda3, ProductoN3, PrecioProducto3, ImagenProducto3, lbl_Estado3);
            MoverProducto(3, lbl_Estado1, lbl_Estado2, lbl_Estado3, lbl_Estado4, lbl_Estado5);
        }

        private void btn_x4_Click(object sender, EventArgs e)
        {
            EliminarProductoDelCarrito(Celda4, ProductoN4, PrecioProducto4, ImagenProducto4, lbl_Estado4);
            MoverProducto(4, lbl_Estado1, lbl_Estado2, lbl_Estado3, lbl_Estado4, lbl_Estado5);

        }
        private void btn_x5_Click(object sender, EventArgs e)
        {
            EliminarProductoDelCarrito(Celda5, ProductoN5, PrecioProducto5, ImagenProducto5, lbl_Estado5);
        }
        private int Verificar_Celdas()
        {
            int total = 0;
            if (lbl_Estado1.Text == "Ocupado")
            {
                total += 1;
            }
            if (lbl_Estado2.Text == "Ocupado")
            {
                total += 1;
            }
            if (lbl_Estado3.Text == "Ocupado")
            {
                total += 1;
            }
            if (lbl_Estado4.Text == "Ocupado")
            {
                total += 1;
            }
            if (lbl_Estado5.Text == "Ocupado")
            {
                total += 1;
            }
            return total;
        }

        private void Btn_Comprar_Click(object sender, EventArgs e)
        {
           
            int Celdas_Ocupadas = Verificar_Celdas();
            finanzas.Fecha_Compra = DateTime.Now;
            finanzas.Documento = lbl_Documento.Text;           
            if (Celdas_Ocupadas == 1)
            {
                finanzas.Nombre_Producto = ProductoN1.Text;
            }
            else if (Celdas_Ocupadas == 2)
            {
                finanzas.Nombre_Producto = ProductoN1.Text + "," + ProductoN2.Text;
            }
            else if (Celdas_Ocupadas == 3)
            {
                finanzas.Nombre_Producto = ProductoN1.Text + "," + ProductoN2.Text + "," + ProductoN3.Text;
            }
            else if (Celdas_Ocupadas == 4)
            {
                finanzas.Nombre_Producto = ProductoN1.Text + "," + ProductoN2.Text + "," + ProductoN3.Text + "," + ProductoN4.Text;
            }
            else if (Celdas_Ocupadas == 5)
            {
                finanzas.Nombre_Producto = ProductoN1.Text + "," + ProductoN2.Text + "," + ProductoN3.Text + "," + ProductoN4.Text + "," + ProductoN5.Text;
            }
            else
            {
                MessageBox.Show("Carrito Vacio");
            }
            finanzas.Precio_Total = int.Parse(Lbl_Total.Text);
            servicioFinanzas.Insertar(finanzas);
        }
    }
}   