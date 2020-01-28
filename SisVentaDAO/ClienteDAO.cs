using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIsEDM;
using SIsEDM.Modelo;

namespace SisVentaDAO
{
    public class ClienteDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Cliente oCliente)
        {
            db.Cliente.Add(oCliente);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Cliente oCliente)
        {
            db.Entry(oCliente).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Cliente oCliente)
        {
            db.Cliente.Remove(oCliente);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Cliente Buscar(string pCodigo)
        {

            Cliente oCliente;
            oCliente = db.Cliente.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oCliente);

        }

        public Cliente buscar(int pid)
        {
            Cliente oCliente;
            oCliente = db.Cliente.DefaultIfEmpty(null).FirstOrDefault(t => t.IdCliente == pid);
            return (oCliente);
        }

        public List<ListaClientes7_Result> ListaCliente()
        {
            return db.ListaClientes7().ToList();
        }

		public List<Cliente> ListCLiente()
		{

			return db.Cliente.ToList();
		}
        public List<BusquedaCliente7_Result> BusquedaCliente(string Nombre, string Apellido)
        {
            return db.BusquedaCliente7(Nombre, Apellido).ToList();
        }
    }
}
