using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIsEDM.Modelo;
using SIsEDM;

namespace SisVentaPresentacion.Operaciones
{
    public partial class FrmVentas : Form
    {
        public FrmVentas()
        {
            InitializeComponent();
        }

        private void btnNuevaVenta_Click(object sender, EventArgs e)
        {
            Operaciones.frmDetalleVenta frm = new frmDetalleVenta();
            frm.ShowDialog();
            Refrescar();
        }

        private void FrmVentas_Load(object sender, EventArgs e)
        {
            Refrescar();
        }

        private void Refrescar()
        {
            using (DBVentaContainer db = new DBVentaContainer())
            {
                dgvListaVentas.DataSource = db.Venta.Select(d => new { d.IdVenta, d.Codigo, d.FechaVenta }).ToList();
            }
        }
    }
}
