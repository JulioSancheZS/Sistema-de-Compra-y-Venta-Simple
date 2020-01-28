namespace SisVentaPresentacion.Reportes
{
	partial class frmCompraActualCliente
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.sisVentaProg40DataSet9 = new SisVentaPresentacion.SisVentaProg40DataSet9();
			this.sisVentaProg40DataSet9BindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet9)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet9BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.sisVentaProg40DataSet9BindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptCompraActualCliente.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(800, 450);
			this.reportViewer1.TabIndex = 0;
			// 
			// sisVentaProg40DataSet9
			// 
			this.sisVentaProg40DataSet9.DataSetName = "SisVentaProg40DataSet9";
			this.sisVentaProg40DataSet9.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sisVentaProg40DataSet9BindingSource
			// 
			this.sisVentaProg40DataSet9BindingSource.DataSource = this.sisVentaProg40DataSet9;
			this.sisVentaProg40DataSet9BindingSource.Position = 0;
			// 
			// frmCompraActualCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmCompraActualCliente";
			this.Text = "frmCompraActualCliente";
			this.Load += new System.EventHandler(this.frmCompraActualCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet9)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet9BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource sisVentaProg40DataSet9BindingSource;
		private SisVentaProg40DataSet9 sisVentaProg40DataSet9;
	}
}