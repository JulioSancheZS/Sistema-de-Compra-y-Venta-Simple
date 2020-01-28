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
	public partial class PermisosUsuarios : Form
	{
		private AsignarPermisoDAO permiso = new AsignarPermisoDAO();
		public PermisosUsuarios()
		{
			InitializeComponent();
		}


		private void btnGuardar_Click(object sender, EventArgs e)
		{
			FuncionAsignada asignada = new FuncionAsignada();									   
			asignada.UsuarioId = (int)cboUsuario.SelectedValue;
			asignada.FuncionDeAccesoId = (int)cboPermiso.SelectedValue;
			asignada.FechaDeVencimiento = (DateTime)dtpFecha.Value;

			if (permiso.Agregar(asignada) == false)
			{
				MessageBox.Show("El nuevo registro no pudo ser grabado", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			else
			{
				MessageBox.Show("El nuevo registro fue grabado", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

		}

		private void btnCancelar_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void PermisosUsuarios_Load(object sender, EventArgs e)
		{

			cboUsuario.DataSource = permiso.ListarUsuarios();
			cboUsuario.DisplayMember = "NombreDeUsuario";
			cboUsuario.ValueMember = "Id";
			cboUsuario.SelectedIndex = -1;

			cboPermiso.DataSource = permiso.ListarPermisos();
			cboPermiso.DisplayMember = "Descripcion";
			cboPermiso.ValueMember = "Id";
			cboPermiso.SelectedIndex = -1;
		}
	}
}
