using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class RepositorioProductos : Conexion
    {
        public RepositorioProductos(string connectionString) : base(connectionString) { }

        public void Insert(Productos productos)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into PRODUCTOS(Documento,Nombre_productos,Precio_Total) values (:Documento,:Nombre_productos,:Precio_Total)";
                Comando.Parameters.Add(new OracleParameter("Documento", OracleDbType.Varchar2)).Value = productos.Documento;
                Comando.Parameters.Add(new OracleParameter("Nombre_productos", OracleDbType.Varchar2)).Value = productos.Nombre_Producto;
                Comando.Parameters.Add(new OracleParameter("Precio_Total", OracleDbType.Int32)).Value = productos.Precio_Total;
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }
        }

        public DataTable GetAllTabla()
        {
            Open();
            OracleCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM PRODUCTOS";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
    }
}
