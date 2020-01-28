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
    public partial class FormFindCliente : Form
    {
        ClienteDAO oClienteDAO = new ClienteDAO(); 
        public FormFindCliente()
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
            DgvFindCliente.DataSource = oClienteDAO.BusquedaCliente(TxtNombre.Text, TxtApellido.Text);
        }

        private void DgvFindCliente_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleVenta frm = Owner as Operaciones.frmDetalleVenta;
            frm.txtIdCliente.Text = DgvFindCliente.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodigoCliente.Text = DgvFindCliente.CurrentRow.Cells[1].Value.ToString();
            frm.TxtNombreCliente.Text = DgvFindCliente.CurrentRow.Cells[2].Value.ToString();
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
