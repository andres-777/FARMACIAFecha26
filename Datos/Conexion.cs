using System;
using System.Collections.Generic;
using Oracle.ManagedDataAccess.Client;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Datos
{
    public class Conexion
    {
        public static string ConnectionString = ConfigurationManager.ConnectionStrings["cadena_conexion"].ConnectionString;

        protected OracleConnection conexion;
        //cadena de conexion con la base de datos y objetos de conexion
        public Conexion(string connectionString)
        {
            conexion = new OracleConnection(connectionString);
        }

        //abre la conexion con la base de datos//
        public void Open()
        {
            conexion.Open();
        }
        //Cierra la conexion con la base de datos//
        public void Closed()
        {
            conexion.Close();
        }
    }
}
