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
    public class CategoriaDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Categoria oCategoria)
        {
            db.Categoria.Add(oCategoria);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Categoria oCategoria)
        {
            db.Entry(oCategoria).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Categoria oCategoria)
        {
            db.Categoria.Remove(oCategoria);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Categoria Buscar(string pCodigo)
        {

            Categoria oCategoria;
            oCategoria = db.Categoria.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oCategoria);

        }

        public Categoria buscar(int pid)
        {
            Categoria oCategoria;
            oCategoria = db.Categoria.DefaultIfEmpty(null).FirstOrDefault(t => t.IdCategoria == pid);
            return (oCategoria);
        }
        public List<Categoria> listar()
        {
            return (db.Categoria.ToList());
        }

        public List<ListaCategoria7_Result> ListaCategorias()
        {
            return db.ListaCategoria7().ToList();
        }

        public List<BusquedaCategoria7_Result> BusquedaCategoria(string Nombre)
        {
            return db.BusquedaCategoria7(Nombre).ToList();
        }
    }
}
