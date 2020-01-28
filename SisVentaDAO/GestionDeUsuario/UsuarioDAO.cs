using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SIsEDM.ModeloUsuario;

namespace SisVentaDAO.GestionDeUsuario
{
	public class UsuarioDAO
	{
		private AccesoUsuarioContainer db = new AccesoUsuarioContainer();
		private string ClaveMaestra = "ProgDB2019";

		public bool Agregar(string pUsuario, string pClave)
		{
			Usuario oUsuario = new Usuario();
			oUsuario.NombreDeUsuario = Encriptar(pUsuario.Trim());
			oUsuario.ClaveDeUsuario = Encriptar(pClave.Trim());
			db.UsuarioSet.Add(oUsuario);

			return (db.SaveChanges() > 0 ? true : false);

		}

		public int Validar(string pUsuario, string pClave)
		{
			string usua = Encriptar(pUsuario.Trim());
			string clv = Encriptar(pClave.Trim());
			Usuario oUsua = db.UsuarioSet.DefaultIfEmpty(null).FirstOrDefault(u => u
				.NombreDeUsuario.Trim() == usua &&
				u.ClaveDeUsuario.Trim() == clv);
			return (oUsua != null ? oUsua.Id : 0);
		}


		public string Encriptar(string cadena)
		{
			byte[] arrMaestro;
			byte[] arrCifrar = UTF8Encoding.UTF8.GetBytes(cadena);
			MD5CryptoServiceProvider varMd5 = new MD5CryptoServiceProvider();
			arrMaestro = varMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(ClaveMaestra));
			varMd5.Clear();

			TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
			tDes.Key = arrMaestro;
			tDes.Mode = CipherMode.ECB;
			tDes.Padding = PaddingMode.PKCS7;
			ICryptoTransform cTransformadore = tDes.CreateEncryptor();
			byte[] Resultado = cTransformadore.TransformFinalBlock(arrCifrar, 0, arrCifrar.Length);
			tDes.Clear();
			return (Convert.ToBase64String(Resultado, 0, Resultado.Length));
		}

		public string Desencriptar(string textoEncriptado)
		{
			byte[] arrClave;
			byte[] arrDesifrar = Convert.FromBase64String(textoEncriptado);
			MD5CryptoServiceProvider varMd5 = new MD5CryptoServiceProvider();
			arrClave = varMd5.ComputeHash(UTF8Encoding.UTF8.GetBytes(ClaveMaestra));
			varMd5.Clear();
			TripleDESCryptoServiceProvider tDes = new TripleDESCryptoServiceProvider();
			tDes.Key = arrClave;
			tDes.Mode = CipherMode.ECB;
			tDes.Padding = PaddingMode.PKCS7;
			ICryptoTransform Transformador = tDes.CreateDecryptor();
			byte[] resultado = Transformador.TransformFinalBlock(arrDesifrar, 0, arrDesifrar.Length);
			tDes.Clear();
			return (UTF8Encoding.UTF8.GetString(resultado));
		}


		public List<ListaUsuario> Listar()
		{
			var q = (from u in db.UsuarioSet
					 select new ListaUsuario { NombreDeUsuario = u.NombreDeUsuario, ClaveDeUsuario = u.ClaveDeUsuario, Id = u.Id }).ToList();
			return q;
		}


		public bool VerificarPermiso(int idusuario, int idFuncion)
		{
			var q = (from f in db.FuncionDeAccesoSet
					 join fn in db.FuncionAsignadaSet
					 on f.Id equals fn.FuncionDeAccesoId
					 where fn.UsuarioId == idusuario && fn.FuncionDeAccesoId == idFuncion && fn.FechaDeVencimiento >= DateTime.Now
					 select f).ToList();

			return q.Count > 0 ? true : false;

		}

		public int VerificarPermiso1(int idusuario)
		{
			var q = (from f in db.FuncionDeAccesoSet
					 join fu in db.FuncionAsignadaSet
					 on f.Id equals fu.FuncionDeAccesoId
					 where fu.UsuarioId == idusuario && fu.FechaDeVencimiento >= DateTime.Now
					 select f).ToList();

			return q.Count();

		}
	}
}

								 