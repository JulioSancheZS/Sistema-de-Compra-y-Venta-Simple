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
	public partial class frmObtenerComprasCliente : Form
	{

		ClienteDAO cli = new ClienteDAO();
		CompraDAO ope = new CompraDAO();

		public frmObtenerComprasCliente()
		{
			InitializeComponent();
		}

		private void frmObtenerComprasCliente_Load(object sender, EventArgs e)
		{

			cboCliente.DataSource = cli.ListCLiente();
			cboCliente.DisplayMember = "Nombre";
			cboCliente.ValueMember = "IdCliente";
		}

		private void btnCliente_Click(object sender, EventArgs e)
		{
			bindingSource1.Clear();
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptObtenerComprasCliente.rdlc";
			bindingSource1.DataSource = ope.ObtenerCompraCliente((int)cboCliente.SelectedValue);
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
			this.reportViewer1.RefreshReport();
		}
	}
}
