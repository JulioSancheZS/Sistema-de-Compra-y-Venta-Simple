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
	public partial class frmBuscarProducto : Form
	{
		ProductosDAO ope = new ProductosDAO();
		public frmBuscarProducto()
		{
			InitializeComponent();
		}

		private void frmBuscarProducto_Load(object sender, EventArgs e)
		{
			cboBuscarProducto.DataSource = ope.ListaProductos();
			cboBuscarProducto.DisplayMember = "Descripcion";
			cboBuscarProducto.ValueMember = "Descripcion";
			
		}

		private void btnMostrar_Click(object sender, EventArgs e)
		{
			bindingSource1.Clear();
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptBuscarProducto.rdlc";
			bindingSource1.DataSource = ope.BusquedaProducto((string)cboBuscarProducto.SelectedValue);
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
			this.reportViewer1.RefreshReport();
		}
	}
}
