namespace SisVentaPresentacion.Informes
{
	partial class frmReporteUltimaVenta
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
			Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
			this.VentaActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.sisVentaProg40DataSet8 = new SisVentaPresentacion.SisVentaProg40DataSet8();
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.sisVentaProg40DataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.VentaActualBindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8BindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// VentaActualBindingSource
			// 
			this.VentaActualBindingSource.DataMember = "VentaActual";
			this.VentaActualBindingSource.DataSource = this.sisVentaProg40DataSet8;
			// 
			// sisVentaProg40DataSet8
			// 
			this.sisVentaProg40DataSet8.DataSetName = "SisVentaProg40DataSet8";
			this.sisVentaProg40DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource2.Name = "DataSet1";
			reportDataSource2.Value = this.VentaActualBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.ReporteUltimaVenta.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(822, 485);
			this.reportViewer1.TabIndex = 0;
			// 
			// sisVentaProg40DataSet8BindingSource
			// 
			this.sisVentaProg40DataSet8BindingSource.DataSource = this.sisVentaProg40DataSet8;
			this.sisVentaProg40DataSet8BindingSource.Position = 0;
			// 
			// frmReporteUltimaVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(822, 485);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmReporteUltimaVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmReporteUltimaVenta";
			this.Load += new System.EventHandler(this.frmReporteUltimaVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.VentaActualBindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8BindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource VentaActualBindingSource;
		private SisVentaProg40DataSet8 sisVentaProg40DataSet8;
		private System.Windows.Forms.BindingSource sisVentaProg40DataSet8BindingSource;
	}
}