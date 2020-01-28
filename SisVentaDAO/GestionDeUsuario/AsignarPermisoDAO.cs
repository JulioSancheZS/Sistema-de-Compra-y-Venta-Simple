using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIsEDM.ModeloUsuario;

namespace SisVentaDAO.GestionDeUsuario
{
	public class AsignarPermisoDAO
	{
		private AccesoUsuarioContainer db = new AccesoUsuarioContainer();
		public List<FuncionDeAcceso> ListarPermisos()
		{
			return db.FuncionDeAccesoSet.ToList();
		}

		public List<Usuario> ListarUsuarios()
		{
			return db.UsuarioSet.ToList();
		}

		public bool Agregar(FuncionAsignada oFuncionAsignada)
		{
			db.FuncionAsignadaSet.Add(oFuncionAsignada);
			return (db.SaveChanges() > 0 ? true : false);

		}

	}
}
