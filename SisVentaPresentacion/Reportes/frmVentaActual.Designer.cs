namespace SisVentaPresentacion.Reportes
{
	partial class frmVentaActual
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
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.sisVentaProg40DataSet8 = new SisVentaPresentacion.SisVentaProg40DataSet8();
			this.sisVentaProg40DataSet8BindingSource = new System.Windows.Forms.BindingSource(this.components);
			this.VentaActualBindingSource = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8BindingSource)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.VentaActualBindingSource)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
			reportDataSource1.Name = "DataSet1";
			reportDataSource1.Value = this.VentaActualBindingSource;
			this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
			this.reportViewer1.LocalReport.ReportEmbeddedResource = "SisVentaPresentacion.Informes.RptVentaActual.rdlc";
			this.reportViewer1.Location = new System.Drawing.Point(0, 0);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(824, 452);
			this.reportViewer1.TabIndex = 0;
			// 
			// sisVentaProg40DataSet8
			// 
			this.sisVentaProg40DataSet8.DataSetName = "SisVentaProg40DataSet8";
			this.sisVentaProg40DataSet8.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			// 
			// sisVentaProg40DataSet8BindingSource
			// 
			this.sisVentaProg40DataSet8BindingSource.DataSource = this.sisVentaProg40DataSet8;
			this.sisVentaProg40DataSet8BindingSource.Position = 0;
			// 
			// VentaActualBindingSource
			// 
			this.VentaActualBindingSource.DataMember = "VentaActual";
			this.VentaActualBindingSource.DataSource = this.sisVentaProg40DataSet8;
			// 
			// frmVentaActual
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(824, 452);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmVentaActual";
			this.Text = "frmVentaActual";
			this.Load += new System.EventHandler(this.frmVentaActual_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.sisVentaProg40DataSet8BindingSource)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.VentaActualBindingSource)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.BindingSource VentaActualBindingSource;
		private SisVentaProg40DataSet8 sisVentaProg40DataSet8;
		private System.Windows.Forms.BindingSource sisVentaProg40DataSet8BindingSource;
	}
}