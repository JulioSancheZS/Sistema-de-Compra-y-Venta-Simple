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
    public partial class FormFindEmpledo : Form
    {
        EmpleadoDAO oEmpleadoDAO = new EmpleadoDAO();

        public FormFindEmpledo()
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
            DgvFindEmpleado.DataSource = oEmpleadoDAO.BusquedaEmpleado(TxtNombre.Text, TxtApellido.Text);
        }

        private void DgvFindEmpleado_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Operaciones.frmDetalleVenta frm = Owner as Operaciones.frmDetalleVenta;
            frm.TxtIdEmpleado.Text = DgvFindEmpleado.CurrentRow.Cells[0].Value.ToString();
            frm.TxtCodgoEmpleado.Text = DgvFindEmpleado.CurrentRow.Cells[1].Value.ToString();
            frm.TxtNombreEmpleado.Text = DgvFindEmpleado.CurrentRow.Cells[3].Value.ToString();
            this.Close();
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
