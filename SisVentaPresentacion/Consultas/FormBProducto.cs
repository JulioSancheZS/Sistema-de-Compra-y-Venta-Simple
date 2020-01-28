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
using System.Runtime.InteropServices;

namespace SisVentaPresentacion.Consultas
{
    public partial class FormBProducto : Form
    {
        ProductosDAO oProductoDAO = new ProductosDAO();

        public FormBProducto()
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
            dataGridView1.DataSource = oProductoDAO.BusquedaProducto(TxtNombre.Text);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleCompra frm = Owner as Operaciones.frmDetalleCompra;
            frm.TxtIdProducto.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodigoProducto.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            frm.TxtDescripProducto.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            frm.TxtPrecioVenta.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
