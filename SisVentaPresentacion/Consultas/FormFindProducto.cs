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
    public partial class FormFindProducto : Form
    {
        ProductosDAO oProductoDAO = new ProductosDAO();
        public FormFindProducto()
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
            DgvFindProducto.DataSource = oProductoDAO.BusquedaProducto(TxtNombre.Text);
        }

        private void DgvFindProducto_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleVenta frm = Owner as Operaciones.frmDetalleVenta;
            frm.TxtIdProducto.Text = DgvFindProducto.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodigoProducto.Text = DgvFindProducto.CurrentRow.Cells[1].Value.ToString();
            frm.TxtDescripProducto.Text = DgvFindProducto.CurrentRow.Cells[2].Value.ToString();
            frm.TxtPrecioVenta.Text = DgvFindProducto.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void FormFindProducto_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
