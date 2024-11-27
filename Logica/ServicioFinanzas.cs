using Datos;
using Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class ServicioFinanzas
    {
        Datos.RepositorioFinanzas repositorioFinanzas;
        public ServicioFinanzas(string connectionString)
        {
            repositorioFinanzas = new Datos.RepositorioFinanzas(connectionString);
        }
        public void Insertar(Finanzas finanzas)
        {
            repositorioFinanzas.Insert(finanzas);
        }
        public string Total_Ingresos()
        {
            int total=0;
            foreach(var item in GetAll())
            {
                total += item.Precio_Total;
            }
            return total.ToString();
        }
        public DataTable GetAllProductos_Cliente(string documento)
        {
            return repositorioFinanzas.GetAllProductos_Cliente(documento);
        }
        public List<Finanzas> GetAll()
        {
            return repositorioFinanzas.GetAll();
        }
        public DataTable GetFinanzas()
        {
            return repositorioFinanzas.GetAllTabla();
        }
    }
}
