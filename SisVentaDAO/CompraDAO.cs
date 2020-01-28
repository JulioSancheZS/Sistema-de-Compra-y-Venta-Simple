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
    public class CompraDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Compra oVenta)
        {
            db.Compra.Add(oVenta);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Compra oVenta)
        {
            db.Entry(oVenta).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Compra oVenta)
        {
            db.Compra.Remove(oVenta);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Compra Buscar(string pCodigo)
        {

            Compra oVenta;
            oVenta = db.Compra.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oVenta);

        }

        public Compra buscar(int pid)
        {
            Compra oVenta;
            oVenta = db.Compra.DefaultIfEmpty(null).FirstOrDefault(t => t.IdCompra == pid);
            return (oVenta);
        }

        public List<ListaCompra1_Result> ListaCompra()
        {
            return db.ListaCompra1().ToList();
        }

		public List<ObtenerCompraCliente_Result> ObtenerCompraCliente(int IdCliente) {

			return db.ObtenerCompraCliente(IdCliente).ToList();
		}

		public List<ObtenerCompraActualCliente_Result> CompraActual() {

			return db.ObtenerCompraActualCliente().ToList();
				
		}
    }
}
