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
    public class RepositorioFinanzas : Conexion
    {
        public RepositorioFinanzas(string connectionString) : base(connectionString) { }

        public void Insert(Finanzas finanzas)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into FINANZAS(Documento,Fecha_de_Compra,Nombre_productos,Precio_Total) values (:Documento,:Fecha_de_Compra,:Nombre_productos,:Precio_Total)";
                Comando.Parameters.Add(new OracleParameter("Documento", OracleDbType.Varchar2)).Value = finanzas.Documento;
                Comando.Parameters.Add(new OracleParameter("Fecha_de_Compra", OracleDbType.Date)).Value = finanzas.Fecha_Compra;
                Comando.Parameters.Add(new OracleParameter("Nombre_productos", OracleDbType.Varchar2)).Value = finanzas.Nombre_Producto;
                Comando.Parameters.Add(new OracleParameter("Precio_Total", OracleDbType.Int32)).Value = finanzas.Precio_Total;
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }
        }

        private Finanzas Mapeador_Finanzas(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Finanzas clienteLog = new Finanzas();
            clienteLog.Documento = dataReader.GetString(0);
            clienteLog.Fecha_Compra = dataReader.GetDateTime(1);
            clienteLog.Nombre_Producto = dataReader.GetString(2);
            clienteLog.Precio_Total = dataReader.GetInt32(3);

            return clienteLog;
        }

        public List<Finanzas> GetAll()
        {
            List<Finanzas> finanzas = new List<Finanzas>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM FINANZAS";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                finanzas.Add(Mapeador_Finanzas(lector));
            }
            Closed();
            return finanzas;
        }

        public DataTable GetAllProductos_Cliente(string documento)
        {
            Open();
            OracleCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Fecha_de_Compra,Nombre_productos,Precio_Total FROM FINANZAS where Documento = :Documento";
            comando.Parameters.Add(new OracleParameter("Documento", OracleDbType.Varchar2)).Value = documento;
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }

        public DataTable GetAllTabla()
        {
            Open();
            OracleCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT Fecha_de_Compra,Nombre_productos,Precio_Total FROM FINANZAS";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
    }
}

