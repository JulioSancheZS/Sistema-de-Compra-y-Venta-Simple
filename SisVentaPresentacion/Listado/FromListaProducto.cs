using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SisVentaDAO;
using SIsEDM;
using SIsEDM.Modelo;

namespace SisVentaPresentacion.Listados
{
    public partial class FromListaProducto : Form
    {
        private ProductosDAO oProductoDAO = new ProductosDAO();

        public FromListaProducto()
        {
            InitializeComponent();
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

       

        private void FromLista_Load(object sender, EventArgs e)
        {
            DgvListaProducto.DataSource = oProductoDAO.ListaProductos();
        }

        private void DgvListaProducto_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleVenta frm = Owner as Operaciones.frmDetalleVenta;
            frm.TxtIdProducto.Text = DgvListaProducto.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodigoProducto.Text = DgvListaProducto.CurrentRow.Cells[1].Value.ToString();
            frm.TxtDescripProducto.Text = DgvListaProducto.CurrentRow.Cells[2].Value.ToString();
            frm.TxtPrecioVenta.Text = DgvListaProducto.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }
    }
}
