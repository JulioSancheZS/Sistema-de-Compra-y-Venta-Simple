using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentaDAO;
using SIsEDM;
using SIsEDM.Modelo;

namespace SisVentaPresentacion.Consultas
{
    public partial class FormFindProveedor : Form
    {
        ProveedorDAO oProveedorDAO = new ProveedorDAO();

        public FormFindProveedor()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMostrar_Click(object sender, EventArgs e)
        {
            DgvBusquedaProveedor.DataSource = oProveedorDAO.BusquedaProveedor(TxtNombre.Text, TxtApellido.Text);
        }

        private void DgvBusquedaProveedor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleCompra frm = Owner as Operaciones.frmDetalleCompra;
            frm.txtIdProveedor.Text = DgvBusquedaProveedor.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodigoCliente.Text = DgvBusquedaProveedor.CurrentRow.Cells[1].Value.ToString();
            frm.TxtNombreCliente.Text = DgvBusquedaProveedor.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
