using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SIsEDM;
using SisVentaDAO;
using Microsoft.Reporting.WinForms;

namespace SisVentaPresentacion.Reportes
{
	public partial class frmVentaActual : Form
	{
		VentaDAO ope = new VentaDAO();

		public frmVentaActual()
		{
			InitializeComponent();
		}

		private void frmVentaActual_Load(object sender, EventArgs e)
		{
			//bindingSource1.Clear();
			//reportViewer1.LocalReport.DataSources.Clear();
			//reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptVentaActual.rdlc";
			//bindingSource1.DataSource = ope.VentaActual();
			//reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
			//this.reportViewer1.RefreshReport();
			SisVentaProg40DataSet8TableAdapters.VentaActualTableAdapter adapter = new SisVentaProg40DataSet8TableAdapters.VentaActualTableAdapter();
			adapter.Fill(this.sisVentaProg40DataSet8.VentaActual);
			this.reportViewer1.Refresh();
		}
	}
}
