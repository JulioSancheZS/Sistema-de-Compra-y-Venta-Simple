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
    public class ProductosDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Producto oProducto)
        {
            db.Producto.Add(oProducto);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Producto oProducto)
        {
            db.Entry(oProducto).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }
     
        public bool Eliminar(Producto oProducto)
        {
            db.Producto.Remove(oProducto);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Producto Buscar(string pCodigo)
        {

            Producto oProducto;
            oProducto = db.Producto.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oProducto);

        }

        public Producto buscar(int pid)
        {
            Producto oProducto;
            oProducto = db.Producto.DefaultIfEmpty(null).FirstOrDefault(t => t.IdProducto == pid);
            return (oProducto);
        }

        public List<ListaProductos7_Result> ListaProductos()
        {
            return db.ListaProductos7().ToList();
        }

        public List<BusquedaProducto7_Result> BusquedaProducto(string Descripcion)
        {
            return db.BusquedaProducto7(Descripcion).ToList();
        }
    }
}
