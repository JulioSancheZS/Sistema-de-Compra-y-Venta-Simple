using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentaPresentacion.Reportes
{
	public partial class frmCompraActualCliente : Form
	{
		public frmCompraActualCliente()
		{
			InitializeComponent();
		}

		private void frmCompraActualCliente_Load(object sender, EventArgs e)
		{

			this.reportViewer1.RefreshReport();
		}
	}
}
