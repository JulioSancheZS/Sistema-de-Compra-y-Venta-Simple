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
	public partial class Login : Form
	{
		private UsuarioDAO user = new UsuarioDAO();
		public int idUsuario = 0;
		public Login()
		{
			InitializeComponent();
		}

		private void button1_Click(object sender, EventArgs e)
		{
			idUsuario = user.Validar(txtUsuario.Text.Trim(), txtContraseña.Text.Trim());
			if (idUsuario > 0)
			{
				this.Close();
			}
			else

				MessageBox.Show("Datos Invalidos");
			txtUsuario.Text = "";
			txtContraseña.Text = "";
			txtUsuario.Focus();

		}

		private void button2_Click(object sender, EventArgs e)
		{

			this.Close();
		}

		private void Login_Load(object sender, EventArgs e)
		{

		}
	}
}
