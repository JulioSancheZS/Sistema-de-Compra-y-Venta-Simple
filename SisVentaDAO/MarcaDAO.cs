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
    public class MarcaDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Marca oMarca)
        {
            db.Marca.Add(oMarca);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Marca oMarca)
        {
            db.Entry(oMarca).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Marca oMarca)
        {
            db.Marca.Remove(oMarca);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Marca Buscar(string pCodigo)
        {

            Marca oMarca;
            oMarca = db.Marca.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oMarca);

        }

        public Marca buscar(int pid)
        {
            Marca oMarca;
            oMarca = db.Marca.DefaultIfEmpty(null).FirstOrDefault(t => t.IdMarca == pid);
            return (oMarca);
        }
        public List<Marca> listar()
        {
            return (db.Marca.ToList());
        }

        public List<ListaMarca7_Result> ListaMarca()
        {
            return db.ListaMarca7().ToList();
        }

        public List<BusquedaMarca7_Result> BusquedaMarca(string Nombre)
        {
            return db.BusquedaMarca7(Nombre).ToList();
        }
    }
}
