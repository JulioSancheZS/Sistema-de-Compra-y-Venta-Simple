using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIsEDM.ModeloUsuario;
using SisVentaDAO.GestionDeUsuario;

namespace SisVentaPresentacion.GestionarUsuario
{
	public partial class FrmUsuarios : Form
	{
		public bool AccesoValido = false;
		private UsuarioDAO opeUsuario = new UsuarioDAO();
		public FrmUsuarios()
		{
			InitializeComponent();
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			if (opeUsuario.Agregar(txtUsuario.Text, txtClave.Text)== false)
			{
				MessageBox.Show("Operaciones Invalida");
			}

			txtClave.Text = "";
			txtUsuario.Text = "";
			txtUsuario.Focus();
		}

		private void txtUsuario_TextChanged(object sender, EventArgs e)
		{
			
		}
	}
}
