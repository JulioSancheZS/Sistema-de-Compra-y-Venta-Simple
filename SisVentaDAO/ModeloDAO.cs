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
    public class ModeloDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Modelo oModelo)
        {
            db.Modelo.Add(oModelo);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Modelo oModelo)
        {
            db.Entry(oModelo).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Modelo oModelo)
        {
            db.Modelo.Remove(oModelo);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Modelo Buscar(string pCodigo)
        {

            Modelo oModelo;
            oModelo = db.Modelo.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oModelo);

        }

        public Modelo buscar(int pid)
        {
            Modelo oModelo;
            oModelo = db.Modelo.DefaultIfEmpty(null).FirstOrDefault(t => t.IdModelo == pid);
            return (oModelo);
        }
        public List<Modelo> listar()
        {
            return (db.Modelo.ToList());
        }

        public List<ListaModelo7_Result> ListaModelo()
        {
            return db.ListaModelo7().ToList();
        }

        public List<BusquedaModelo7_Result> BusquedaModelo(string Nombre)
        {
            return db.BusquedaModelo7(Nombre).ToList();
        }
    }
}
