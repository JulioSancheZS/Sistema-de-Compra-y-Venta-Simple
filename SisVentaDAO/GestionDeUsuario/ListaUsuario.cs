using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SIsEDM.ModeloUsuario;
using SisVentaDAO.GestionDeUsuario;

namespace SisVentaDAO.GestionDeUsuario
{
	public class ListaUsuario : Usuario
	{
		private UsuarioDAO opeUsuario = new UsuarioDAO();
		public string UsuarioDecifrado { get { return (opeUsuario.Desencriptar(NombreDeUsuario.Trim())); } }
	}

}
