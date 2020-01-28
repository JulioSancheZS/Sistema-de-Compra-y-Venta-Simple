using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIsEDM;
using SIsEDM.Modelo;

namespace SisVentaDAO
{
    public class ProveedorDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Proveedor oProveedor)
        {
            db.Proveedor.Add(oProveedor);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Proveedor oProveedor)
        {
            db.Entry(oProveedor).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Proveedor oProveedor)
        {
            db.Proveedor.Remove(oProveedor);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Proveedor Buscar(string pCodigo)
        {

            Proveedor oProveedor;
            oProveedor = db.Proveedor.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oProveedor);

        }

        public Proveedor buscar(int pid)
        {
            Proveedor oProveedor;
            oProveedor = db.Proveedor.DefaultIfEmpty(null).FirstOrDefault(t => t.IdProveedor == pid);
            return (oProveedor);
        }

        public List<ListaProveedores7_Result> ListaProveedore()
        {
            return db.ListaProveedores7().ToList();
        }

        public List<BusquedaProveedor7_Result> BusquedaProveedor(string Nombre, string Apellido)
        {
            return db.BusquedaProveedor7(Nombre, Apellido).ToList();
        }
    }
}
