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
	public partial class frmObtenerVentasEmplea : Form
	{
		VentaDAO ope = new VentaDAO();
		DatosDAO dao = new DatosDAO();
		EmpleadoDAO emp = new EmpleadoDAO();
		public frmObtenerVentasEmplea()
		{
			InitializeComponent();
		}

		private void frmObtenerVentasEmplea_Load(object sender, EventArgs e)
		{
			cboEmpleado.DataSource = emp.ListaEmpleado();
			//cboEmpleado.DataSource = emp.ListaEmpleados();
			cboEmpleado.DisplayMember = "Nombre";
			cboEmpleado.ValueMember = "IdEmpleado";			
		}

		private void btnEmpleado_Click(object sender, EventArgs e)
		{
			bindingSource1.Clear();
			reportViewer1.LocalReport.DataSources.Clear();
			reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptObtenerVentaEmplea.rdlc";
			bindingSource1.DataSource = ope.ObtenerVentaEmpleado((int)cboEmpleado.SelectedValue);
			reportViewer1.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", bindingSource1));
			this.reportViewer1.RefreshReport();
		}
	}
}
