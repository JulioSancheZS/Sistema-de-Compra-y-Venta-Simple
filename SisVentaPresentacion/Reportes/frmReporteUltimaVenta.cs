using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SisVentaPresentacion.Informes
{
	public partial class frmReporteUltimaVenta : Form
	{
		public frmReporteUltimaVenta()
		{
			InitializeComponent();
		}

		private void frmReporteUltimaVenta_Load(object sender, EventArgs e)
		{
			this.sisVentaProg40DataSet8.EnforceConstraints = false;
			SisVentaProg40DataSet8TableAdapters.VentaActualTableAdapter adapter = new SisVentaProg40DataSet8TableAdapters.VentaActualTableAdapter();
			adapter.Fill(this.sisVentaProg40DataSet8.VentaActual);
			sisVentaProg40DataSet8BindingSource.DataSource = this.sisVentaProg40DataSet8;
			this.reportViewer1.RefreshReport();
			//reportViewer1.SetDisplayMode(Microsoft.Reporting.WinForms.DisplayMode.PrintLayout);
		}
	}
}
