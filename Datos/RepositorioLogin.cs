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
    public class RepositorioLogin : Conexion
    {
        public RepositorioLogin(string connectionString) : base(connectionString) { }

        public void Insert(Login login)
        {
            using (var Comando = conexion.CreateCommand())
            {
                Comando.CommandText = "Insert into Login(Documento,Nombre_Completo,Fecha_Nacimiento,Usuario,Contraseña,Telefono) values (:Documento,:Nombre_Completo,:Fecha_Nacimiento,:Usuario,:Contraseña,:Telefono)";
                Comando.Parameters.Add(new OracleParameter("Documento", OracleDbType.Varchar2)).Value = login.Documento ?? throw new ArgumentNullException(nameof(login.Documento));
                Comando.Parameters.Add(new OracleParameter("Nombre_Completo", OracleDbType.Varchar2)).Value = login.Nombre_Completo ?? throw new ArgumentNullException(nameof(login.Nombre_Completo));
                Comando.Parameters.Add(new OracleParameter("Fecha_Nacimiento", OracleDbType.Date)).Value = login.Fecha_Nacimineto;
                Comando.Parameters.Add(new OracleParameter("Usuario", OracleDbType.Varchar2)).Value = login.Usuario ?? throw new ArgumentNullException(nameof(login.Usuario));
                Comando.Parameters.Add(new OracleParameter("Contraseña", OracleDbType.Varchar2)).Value = login.Contraseña ?? throw new ArgumentNullException(nameof(login.Contraseña));
                Comando.Parameters.Add(new OracleParameter("Telefono", OracleDbType.Varchar2)).Value = login.Telefono ?? throw new ArgumentNullException(nameof(login.Telefono));
                Open();
                Comando.ExecuteNonQuery();
                Closed();
            }
        }

        private Login Mapeador_login(OracleDataReader dataReader)
        {
            if (!dataReader.HasRows) return null;
            Login clienteLog = new Login();
            clienteLog.Documento = dataReader.GetString(0);
            clienteLog.Nombre_Completo = dataReader.GetString(1);
            clienteLog.Fecha_Nacimineto = dataReader.GetDateTime(2);
            clienteLog.Usuario = dataReader.GetString(3);
            clienteLog.Contraseña = dataReader.GetString(4);
            clienteLog.Telefono = dataReader.GetString(5);

            return clienteLog;
        }

        public List<Login> GetAll()
        {
            List<Login> log = new List<Login>();
            var comando = conexion.CreateCommand();
            comando.CommandText = "SELECT * FROM LOGIN";
            Open();
            OracleDataReader lector = comando.ExecuteReader();
            while (lector.Read())
            {
                log.Add(Mapeador_login(lector));
            }
            Closed();
            return log;
        }

        public DataTable GetAllTabla()
        {
            Open();
            OracleCommand comando = conexion.CreateCommand();
            comando.CommandType = CommandType.Text;
            comando.CommandText = "SELECT * FROM LOGIN";
            comando.ExecuteNonQuery();

            DataTable dt = new DataTable();
            OracleDataAdapter dataAdapter = new OracleDataAdapter(comando);
            dataAdapter.Fill(dt);
            Closed();
            return dt;
        }
    }
}

