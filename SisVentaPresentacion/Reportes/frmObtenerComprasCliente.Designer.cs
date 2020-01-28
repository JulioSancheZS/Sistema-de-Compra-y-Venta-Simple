namespace SisVentaPresentacion.Reportes
{
	partial class frmObtenerComprasCliente
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
			this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
			this.label1 = new System.Windows.Forms.Label();
			this.cboCliente = new System.Windows.Forms.ComboBox();
			this.btnCliente = new System.Windows.Forms.Button();
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Location = new System.Drawing.Point(-2, 43);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(878, 490);
			this.reportViewer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(13, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(51, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Cliente";
			// 
			// cboCliente
			// 
			this.cboCliente.FormattingEnabled = true;
			this.cboCliente.Location = new System.Drawing.Point(71, 13);
			this.cboCliente.Name = "cboCliente";
			this.cboCliente.Size = new System.Drawing.Size(320, 24);
			this.cboCliente.TabIndex = 2;
			// 
			// btnCliente
			// 
			this.btnCliente.Location = new System.Drawing.Point(418, 14);
			this.btnCliente.Name = "btnCliente";
			this.btnCliente.Size = new System.Drawing.Size(75, 23);
			this.btnCliente.TabIndex = 3;
			this.btnCliente.Text = "Mostrar";
			this.btnCliente.UseVisualStyleBackColor = true;
			this.btnCliente.Click += new System.EventHandler(this.btnCliente_Click);
			// 
			// frmObtenerComprasCliente
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 533);
			this.Controls.Add(this.btnCliente);
			this.Controls.Add(this.cboCliente);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmObtenerComprasCliente";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "frmObtenerComprasCliente";
			this.Load += new System.EventHandler(this.frmObtenerComprasCliente_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboCliente;
		private System.Windows.Forms.Button btnCliente;
		private System.Windows.Forms.BindingSource bindingSource1;
	}
}