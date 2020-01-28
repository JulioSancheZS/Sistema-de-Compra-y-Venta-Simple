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
    public class DatosDAO
    {
        DBVentaContainer db = new DBVentaContainer();

        public bool Agregar(Datos oDatos)
        {
            db.Datos.Add(oDatos);
            return (db.SaveChanges() > 0 ? true : false);
        }

        public bool Modificar(Datos oDatos)
        {
            db.Entry(oDatos).State = EntityState.Modified;
            return (db.SaveChanges() > 0 ? true : false);

        }

        public bool Eliminar(Datos oDatos)
        {
            db.Datos.Remove(oDatos);
            return db.SaveChanges() > 0 ? true : false;
        }

        public Datos Buscar(string pCodigo)
        {

            Datos oDatos;
            oDatos = db.Datos.DefaultIfEmpty(null).FirstOrDefault(tc => tc.Codigo.Trim() == pCodigo.Trim());
            return (oDatos);

        }

        public Datos buscar(int pid)
        {
            Datos oDatos;
            oDatos = db.Datos.DefaultIfEmpty(null).FirstOrDefault(t => t.IdDatos == pid);
            return (oDatos);
        }
  
    }
}
