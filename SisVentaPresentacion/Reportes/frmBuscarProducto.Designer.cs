namespace SisVentaPresentacion.Reportes
{
	partial class frmBuscarProducto
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
			this.btnMostrar = new System.Windows.Forms.Button();
			this.cboBuscarProducto = new System.Windows.Forms.ComboBox();
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
			this.SuspendLayout();
			// 
			// reportViewer1
			// 
			this.reportViewer1.Location = new System.Drawing.Point(1, 107);
			this.reportViewer1.Name = "reportViewer1";
			this.reportViewer1.ServerReport.BearerToken = null;
			this.reportViewer1.Size = new System.Drawing.Size(787, 331);
			this.reportViewer1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(92, 50);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 1;
			this.label1.Text = "label1";
			// 
			// btnMostrar
			// 
			this.btnMostrar.Location = new System.Drawing.Point(409, 44);
			this.btnMostrar.Name = "btnMostrar";
			this.btnMostrar.Size = new System.Drawing.Size(75, 23);
			this.btnMostrar.TabIndex = 2;
			this.btnMostrar.Text = "Mostrar";
			this.btnMostrar.UseVisualStyleBackColor = true;
			this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
			// 
			// cboBuscarProducto
			// 
			this.cboBuscarProducto.FormattingEnabled = true;
			this.cboBuscarProducto.Location = new System.Drawing.Point(134, 44);
			this.cboBuscarProducto.Name = "cboBuscarProducto";
			this.cboBuscarProducto.Size = new System.Drawing.Size(259, 24);
			this.cboBuscarProducto.TabIndex = 3;
			// 
			// frmBuscarProducto
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 450);
			this.Controls.Add(this.cboBuscarProducto);
			this.Controls.Add(this.btnMostrar);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.reportViewer1);
			this.Name = "frmBuscarProducto";
			this.Text = "frmBuscarProducto";
			this.Load += new System.EventHandler(this.frmBuscarProducto_Load);
			((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
		private System.Windows.Forms.BindingSource bindingSource1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button btnMostrar;
		private System.Windows.Forms.ComboBox cboBuscarProducto;
	}
}