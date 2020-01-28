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
	public partial class frmClientes : Form
	{
		ClienteDAO ope = new ClienteDAO();
		public frmClientes()
		{
			InitializeComponent();
		}

		private void frmClientes_Load(object sender, EventArgs e)
		{
			bindingSource1.Clear();
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptCliente.rdlc";
			bindingSource1.DataSource = ope.ListaCliente();
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
			this.reportViewer1.RefreshReport();
		}
	}
}
