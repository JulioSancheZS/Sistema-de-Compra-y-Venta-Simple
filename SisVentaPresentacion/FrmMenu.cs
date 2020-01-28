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

namespace SisVentaPresentacion
{
    public partial class FrmMenuPrincipal : Form
    {
		private UsuarioDAO opeUsuario = new UsuarioDAO();
		public int IdUsuario = 0;
		public int p = 0;

        public FrmMenuPrincipal()
        {
            InitializeComponent();
           
        }

        private void TsmModelo_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantModelo();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsmCategoria_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantCategoria();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsmMarca_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantMarca();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsmProducto_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantProducto();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsmProveedor_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantProveedor();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsmCliente_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantCliente();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsmEmpleado_Click(object sender, EventArgs e)
        {
            var oFrm = new Catalogos.FormMantEmpleado();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstCerrarSecion_Click(object sender, EventArgs e)
        {
            //Application.Exit();

			var oFrm = new GestionarUsuario.Login();
			oFrm.ShowDialog();
			IdUsuario = oFrm.idUsuario;
			oFrm.Dispose();

			if (IdUsuario < 1)
				this.Close();

			else
				p = opeUsuario.VerificarPermiso1(IdUsuario);
			if (p < 1)
				menuStrip1.Enabled = false;


		}

        private void TstListaCategoria_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaCategoria();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstListaModelo_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaModelo();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstListaMarca_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaMarca();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstListaProducto_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaProducto();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstListaCliente_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaCliente();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstListaEmpledo_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaEmpleado();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstListaProveedor_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaProveedor();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindProveedor_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindProveedor();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindCiente_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindCliente();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindEmpleado_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindEmpledo();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindProducto_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindProducto();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindProductoCate_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindCategoria();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindProductoMarca_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindMarca();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstFindProductoModelo_Click(object sender, EventArgs e)
        {
            var oFrm = new Consultas.FormFindModelo();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TstDatos_Click(object sender, EventArgs e)
        {

            var oFrm = new Catalogos.FormMantDatos();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void TsVentas_Click(object sender, EventArgs e)
        {
			if (opeUsuario.VerificarPermiso(IdUsuario, 3))
			{
				var oFrm = new Operaciones.frmDetalleVenta();
				oFrm.ShowDialog();
				oFrm.Dispose();
			}
			else
				MessageBox.Show("El usuario no tiene Permiso");

			//var oFrom = new Reportes.frmVentaActual();
			//oFrom.ShowDialog();
			//oFrom.Dispose();
		}

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
			if (opeUsuario.VerificarPermiso(IdUsuario, 3))
			{
				var oFrm = new Operaciones.frmDetalleCompra();
				oFrm.ShowDialog();
				oFrm.Dispose();

			}
			else
				MessageBox.Show("El usuario no tiene Permiso");
        }

        private void comprasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaCompra();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

        private void ventasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var oFrm = new Listados.FromListaVenta();
            oFrm.ShowDialog();
            oFrm.Dispose();
        }

		private void clienteToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmClientes();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void proveedorToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmProveedor();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void categoriaToolStripMenuItem1_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmCategoria();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void categoriaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmEmpleado();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void modeloToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmModelo();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void productoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmProductos();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void marcaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmMarcas();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
		{

			
				var oFrm = new Reportes.frmVentas();
				oFrm.ShowDialog();
				oFrm.Dispose();
			
		}

		private void comprasToolStripMenuItem2_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmCompras();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

	

		private void buscarProductoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmBuscarProducto();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void obtenerVentasEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmObtenerVentasEmplea();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		private void ObtenerComprasToolStripMenuItem_Click(object sender, EventArgs e)
		{
			var oFrm = new Reportes.frmObtenerComprasCliente();
			oFrm.ShowDialog();
			oFrm.Dispose();
		}

		

		private void crearUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
		if (opeUsuario.VerificarPermiso(IdUsuario, 2))
			{
				var oFrm = new GestionarUsuario.FrmUsuarios();
				oFrm.ShowDialog();
				oFrm.Dispose();
			}
			else
				MessageBox.Show("El usuario no tiene Permiso");

			}

		private void permisosDeUsuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (opeUsuario.VerificarPermiso(IdUsuario, 2))
			{
				var oFrm = new GestionarUsuario.FrmFunciones();
				oFrm.ShowDialog();
				oFrm.Dispose();
			}
			else
				MessageBox.Show("El usuario no tiene Permiso");
		}

		private void cambiarContraseñaToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (opeUsuario.VerificarPermiso(IdUsuario, 2))
			{
				var oFrm = new GestionarUsuario.PermisosUsuarios();
				oFrm.ShowDialog();
				oFrm.Dispose();
			}
			else
				MessageBox.Show("El usuario no tiene Permiso");
		}

		private void FrmMenuPrincipal_Load(object sender, EventArgs e)
		{
			var oFrm = new GestionarUsuario.Login();
			oFrm.ShowDialog();
			IdUsuario = oFrm.idUsuario;
			oFrm.Dispose();

			if (IdUsuario < 1)
				this.Close();

			else
				p = opeUsuario.VerificarPermiso1(IdUsuario);
			if (p < 1)
				menuStrip1.Enabled = false;
		}

		private void usuarioToolStripMenuItem_Click(object sender, EventArgs e)
		{

		}
	}
}
