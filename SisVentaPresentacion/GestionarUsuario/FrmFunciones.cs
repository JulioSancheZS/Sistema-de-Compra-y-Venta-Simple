using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentaDAO.GestionDeUsuario;
using SIsEDM.ModeloUsuario;

namespace SisVentaPresentacion.GestionarUsuario
{ 
	public partial class FrmFunciones : Form
	{
		private FuncionesDAO ope = new FuncionesDAO();
		public FrmFunciones()
		{
			InitializeComponent();
		}

		private void FrmFunciones_Load(object sender, EventArgs e)
		{

			 
		}

		private void button2_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnAceptar_Click(object sender, EventArgs e)
		{
			if (ope.Buscar(txtCodigo.Text) == null)
			{
				if (ope.Agregar(txtCodigo.Text, txtDescripcion.Text) == false)
				{
					MessageBox.Show("Operacion Invalidad");
				}
			}

			else

			if (ope.Modificar(txtCodigo.Text, txtDescripcion.Text) == false)
			{
				MessageBox.Show("Operacion Invalidad");
			}

			txtCodigo.Text = "";
			txtDescripcion.Text = "";
			txtCodigo.Focus(); 
		}


		private void txtCodigo_Validating(object sender, CancelEventArgs e)
		{
			FuncionDeAcceso acceso = ope.Buscar(txtCodigo.Text);
			if (acceso == null)
			{
				txtDescripcion.Text = "";

			}
			else
			{
				txtDescripcion.Text = acceso.Descripcion.Trim();
			}
		}
	}
}
