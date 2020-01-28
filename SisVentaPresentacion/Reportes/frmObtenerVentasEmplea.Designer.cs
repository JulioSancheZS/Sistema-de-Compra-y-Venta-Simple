namespace SisVentaPresentacion.Reportes
{
	partial class frmObtenerVentasEmplea
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
			this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
			this.label1 = new System.Windows.Forms.Label();
			this.cboEmpleado = new System.Windows.Forms.ComboBox();
			this.btnEmpleado = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Location = new System.Drawing.Point(5, 63);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(864, 468);
			this.reportViewer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(26, 24);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(71, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "Empleado";
			// 
			// cboEmpleado
			// 
			this.cboEmpleado.FormattingEnabled = true;
			this.cboEmpleado.Location = new System.Drawing.Point(93, 21);
			this.cboEmpleado.Name = "cboEmpleado";
			this.cboEmpleado.Size = new System.Drawing.Size(304, 24);
			this.cboEmpleado.TabIndex = 2;
			// 
			// btnEmpleado
			// 
			this.btnEmpleado.Location = new System.Drawing.Point(431, 21);
			this.btnEmpleado.Name = "btnEmpleado";
			this.btnEmpleado.Size = new System.Drawing.Size(94, 29);
			this.btnEmpleado.TabIndex = 3;
			this.btnEmpleado.Text = "Mostrar";
			this.btnEmpleado.UseVisualStyleBackColor = true;
			this.btnEmpleado.Click += new System.EventHandler(this.btnEmpleado_Click);
			// 
			// frmObtenerVentasEmplea
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(874, 533);
			this.Controls.Add(this.btnEmpleado);
			this.Controls.Add(this.cboEmpleado);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmObtenerVentasEmplea";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "frmObtenerVentasEmplea";
			this.Load += new System.EventHandler(this.frmObtenerVentasEmplea_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.ComboBox cboEmpleado;
		private System.Windows.Forms.Button btnEmpleado;
	}
}