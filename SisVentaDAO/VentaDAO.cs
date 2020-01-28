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
    public class VentaDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Venta oVenta)
        {
            db.Venta.Add(oVenta);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Venta oVenta)
        {
            db.Entry(oVenta).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Venta oVenta)
        {
            db.Venta.Remove(oVenta);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Venta Buscar(string pCodigo)
        {

            Venta oVenta;
            oVenta = db.Venta.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oVenta);

        }

        public Venta buscar(int pid)
        {
            Venta oVenta;
            oVenta = db.Venta.DefaultIfEmpty(null).FirstOrDefault(t => t.IdVenta == pid);
            return (oVenta);
        }

        public List<ListaVentas1_Result> ListaVenta()
        {
            return db.ListaVentas1().ToList();
        }

		public List<ObterVentaEmpleado_Result> ObtenerVentaEmpleado(int IdEmpleado)
		{

			return db.ObterVentaEmpleado(IdEmpleado).ToList();
		}
		public object ListaVenta(int selectedValue)
		{
			throw new NotImplementedException();
		}

		public List<VentaActual_Result> VentaActual(){

			return db.VentaActual().ToList();
		}
		//public List<BusquedaVentaEmpleado_Result> BusquedaVentaEmpleado(int Codigo)
		//{
		//	return db.BusquedaVentaEmpleado(Codigo).ToList();
		//}

	}
}
