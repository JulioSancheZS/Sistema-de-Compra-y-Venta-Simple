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
using SisVentaPresentacion.Listados;

namespace SisVentaPresentacion.Listados
{
    public partial class FromListaCliente : Form
    {
        private ClienteDAO oClienteDAO = new ClienteDAO();
        public FromListaCliente()
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

        private void FromListaCliente_Load(object sender, EventArgs e)
        {
            DgvListadoCliente.DataSource = oClienteDAO.ListaCliente();
        }

        private void DgvListadoCliente_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleVenta frm = Owner as Operaciones.frmDetalleVenta;
            frm.txtIdCliente.Text = DgvListadoCliente.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodigoCliente.Text = DgvListadoCliente.CurrentRow.Cells[1].Value.ToString();
            frm.TxtNombreCliente.Text = DgvListadoCliente.CurrentRow.Cells[2].Value.ToString();
            this.Close();
        }
    }
}
