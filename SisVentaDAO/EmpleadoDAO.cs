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
    public class EmpleadoDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Empleado oEmpledo)
        {
            db.Empleado.Add(oEmpledo);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Empleado oEmpledo)
        {
            db.Entry(oEmpledo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Empleado oEmpledo)
        {
            db.Empleado.Remove(oEmpledo);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Empleado Buscar(string pCodigo)
        {

            Empleado oEmpledo;
            oEmpledo = db.Empleado.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oEmpledo);

        }

        public Empleado buscar(int pid)
        {
            Empleado oEmpledo;
            oEmpledo = db.Empleado.DefaultIfEmpty(null).FirstOrDefault(t => t.IdEmpleado == pid);
            return (oEmpledo);
        }

		public List<Empleado> ListaEmpleado()
		{
			return db.Empleado.ToList();
		}


		public List<Empleado> BusquedaEmpleado(string Nombre, string Apellido)
        {
			return db.Empleado.ToList();
        }

		public List<ListaEmpleados_Result> ListaEmpleados() {

			return db.ListaEmpleados().ToList();
		}
	}
}
