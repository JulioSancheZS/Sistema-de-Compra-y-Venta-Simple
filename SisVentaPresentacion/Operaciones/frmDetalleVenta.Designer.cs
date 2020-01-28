namespace SisVentaPresentacion.Operaciones
{
    partial class frmDetalleVenta
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
			this.label1 = new System.Windows.Forms.Label();
			this.TxtCodgoEmpleado = new System.Windows.Forms.TextBox();
			this.TxtIdEmpleado = new System.Windows.Forms.TextBox();
			this.TxtNombreEmpleado = new System.Windows.Forms.TextBox();
			this.label3 = new System.Windows.Forms.Label();
			this.TxtNombreCliente = new System.Windows.Forms.TextBox();
			this.label4 = new System.Windows.Forms.Label();
			this.txtIdCliente = new System.Windows.Forms.TextBox();
			this.TxtCodigoCliente = new System.Windows.Forms.TextBox();
			this.label6 = new System.Windows.Forms.Label();
			this.DgvDetalleVenta = new System.Windows.Forms.DataGridView();
			this.Descripcion = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Importe = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Id = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Op = new System.Windows.Forms.DataGridViewButtonColumn();
			this.TxtDescripProducto = new System.Windows.Forms.TextBox();
			this.label7 = new System.Windows.Forms.Label();
			this.TxtIdProducto = new System.Windows.Forms.TextBox();
			this.TxtCodigoProducto = new System.Windows.Forms.TextBox();
			this.label9 = new System.Windows.Forms.Label();
			this.TxtCantidadP = new System.Windows.Forms.TextBox();
			this.label10 = new System.Windows.Forms.Label();
			this.btnAgregarVenta = new System.Windows.Forms.Button();
			this.BtnGenerarVenta = new System.Windows.Forms.Button();
			this.TxtPrecioVenta = new System.Windows.Forms.TextBox();
			this.label11 = new System.Windows.Forms.Label();
			this.LblTotal = new System.Windows.Forms.Label();
			this.label12 = new System.Windows.Forms.Label();
			this.TxtCodigoVenta = new System.Windows.Forms.TextBox();
			this.label13 = new System.Windows.Forms.Label();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.btnBuscarEmpleado = new System.Windows.Forms.Button();
			this.BtnBuscarCliente = new System.Windows.Forms.Button();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.BtnBuscarProducto = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVenta)).BeginInit();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(5, 34);
			this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(123, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "Codigo Empleado:";
			// 
			// TxtCodgoEmpleado
			// 
			this.TxtCodgoEmpleado.Location = new System.Drawing.Point(137, 31);
			this.TxtCodgoEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtCodgoEmpleado.Name = "TxtCodgoEmpleado";
			this.TxtCodgoEmpleado.Size = new System.Drawing.Size(224, 22);
			this.TxtCodgoEmpleado.TabIndex = 1;
			this.TxtCodgoEmpleado.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodgoEmpleado_Validating);
			// 
			// TxtIdEmpleado
			// 
			this.TxtIdEmpleado.Location = new System.Drawing.Point(1123, 80);
			this.TxtIdEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtIdEmpleado.Name = "TxtIdEmpleado";
			this.TxtIdEmpleado.ReadOnly = true;
			this.TxtIdEmpleado.Size = new System.Drawing.Size(224, 22);
			this.TxtIdEmpleado.TabIndex = 3;
			this.TxtIdEmpleado.Visible = false;
			// 
			// TxtNombreEmpleado
			// 
			this.TxtNombreEmpleado.Location = new System.Drawing.Point(137, 66);
			this.TxtNombreEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtNombreEmpleado.Name = "TxtNombreEmpleado";
			this.TxtNombreEmpleado.Size = new System.Drawing.Size(224, 22);
			this.TxtNombreEmpleado.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(35, 66);
			this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(62, 17);
			this.label3.TabIndex = 4;
			this.label3.Text = "Nombre:";
			// 
			// TxtNombreCliente
			// 
			this.TxtNombreCliente.Location = new System.Drawing.Point(137, 146);
			this.TxtNombreCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtNombreCliente.Name = "TxtNombreCliente";
			this.TxtNombreCliente.Size = new System.Drawing.Size(224, 22);
			this.TxtNombreCliente.TabIndex = 12;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(40, 148);
			this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(62, 17);
			this.label4.TabIndex = 11;
			this.label4.Text = "Nombre:";
			// 
			// txtIdCliente
			// 
			this.txtIdCliente.Location = new System.Drawing.Point(1123, 15);
			this.txtIdCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.txtIdCliente.Name = "txtIdCliente";
			this.txtIdCliente.ReadOnly = true;
			this.txtIdCliente.Size = new System.Drawing.Size(224, 22);
			this.txtIdCliente.TabIndex = 10;
			this.txtIdCliente.Visible = false;
			// 
			// TxtCodigoCliente
			// 
			this.TxtCodigoCliente.Location = new System.Drawing.Point(137, 114);
			this.TxtCodigoCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtCodigoCliente.Name = "TxtCodigoCliente";
			this.TxtCodigoCliente.Size = new System.Drawing.Size(224, 22);
			this.TxtCodigoCliente.TabIndex = 8;
			this.TxtCodigoCliente.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoCliente_Validating);
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(5, 118);
			this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(103, 17);
			this.label6.TabIndex = 7;
			this.label6.Text = "Codigo Cliente:";
			// 
			// DgvDetalleVenta
			// 
			this.DgvDetalleVenta.AllowUserToAddRows = false;
			this.DgvDetalleVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.DgvDetalleVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Descripcion,
            this.Precio,
            this.Cantidad,
            this.Importe,
            this.Id,
            this.Op});
			this.DgvDetalleVenta.Location = new System.Drawing.Point(60, 326);
			this.DgvDetalleVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.DgvDetalleVenta.Name = "DgvDetalleVenta";
			this.DgvDetalleVenta.Size = new System.Drawing.Size(1171, 411);
			this.DgvDetalleVenta.TabIndex = 13;
			this.DgvDetalleVenta.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvDetalleVenta_CellClick);
			// 
			// Descripcion
			// 
			this.Descripcion.HeaderText = "Descripcion";
			this.Descripcion.Name = "Descripcion";
			// 
			// Precio
			// 
			this.Precio.HeaderText = "Precio";
			this.Precio.Name = "Precio";
			// 
			// Cantidad
			// 
			this.Cantidad.HeaderText = "Cantidad";
			this.Cantidad.Name = "Cantidad";
			// 
			// Importe
			// 
			this.Importe.HeaderText = "Importe";
			this.Importe.Name = "Importe";
			// 
			// Id
			// 
			this.Id.HeaderText = "Id";
			this.Id.Name = "Id";
			// 
			// Op
			// 
			this.Op.HeaderText = "Op";
			this.Op.Name = "Op";
			// 
			// TxtDescripProducto
			// 
			this.TxtDescripProducto.Location = new System.Drawing.Point(151, 59);
			this.TxtDescripProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtDescripProducto.Name = "TxtDescripProducto";
			this.TxtDescripProducto.ReadOnly = true;
			this.TxtDescripProducto.Size = new System.Drawing.Size(224, 22);
			this.TxtDescripProducto.TabIndex = 19;
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Location = new System.Drawing.Point(48, 59);
			this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(86, 17);
			this.label7.TabIndex = 18;
			this.label7.Text = "Descripcion:";
			// 
			// TxtIdProducto
			// 
			this.TxtIdProducto.Location = new System.Drawing.Point(1123, 47);
			this.TxtIdProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtIdProducto.Name = "TxtIdProducto";
			this.TxtIdProducto.ReadOnly = true;
			this.TxtIdProducto.Size = new System.Drawing.Size(224, 22);
			this.TxtIdProducto.TabIndex = 17;
			this.TxtIdProducto.Visible = false;
			this.TxtIdProducto.TextChanged += new System.EventHandler(this.TxtIdProducto_TextChanged);
			// 
			// TxtCodigoProducto
			// 
			this.TxtCodigoProducto.Location = new System.Drawing.Point(151, 23);
			this.TxtCodigoProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtCodigoProducto.Name = "TxtCodigoProducto";
			this.TxtCodigoProducto.Size = new System.Drawing.Size(224, 22);
			this.TxtCodigoProducto.TabIndex = 15;
			this.TxtCodigoProducto.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCodigoProducto_Validating);
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Location = new System.Drawing.Point(19, 31);
			this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(117, 17);
			this.label9.TabIndex = 14;
			this.label9.Text = "Codigo Producto:";
			// 
			// TxtCantidadP
			// 
			this.TxtCantidadP.Location = new System.Drawing.Point(151, 123);
			this.TxtCantidadP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtCantidadP.Name = "TxtCantidadP";
			this.TxtCantidadP.Size = new System.Drawing.Size(224, 22);
			this.TxtCantidadP.TabIndex = 21;
			this.TxtCantidadP.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtCantidadP_KeyPress);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Location = new System.Drawing.Point(48, 123);
			this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(68, 17);
			this.label10.TabIndex = 20;
			this.label10.Text = "Cantidad:";
			// 
			// btnAgregarVenta
			// 
			this.btnAgregarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btnAgregarVenta.Location = new System.Drawing.Point(151, 262);
			this.btnAgregarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnAgregarVenta.Name = "btnAgregarVenta";
			this.btnAgregarVenta.Size = new System.Drawing.Size(221, 44);
			this.btnAgregarVenta.TabIndex = 23;
			this.btnAgregarVenta.Text = "Agregar a la tabla";
			this.btnAgregarVenta.UseVisualStyleBackColor = true;
			this.btnAgregarVenta.Click += new System.EventHandler(this.btnAgregarVenta_Click);
			// 
			// BtnGenerarVenta
			// 
			this.BtnGenerarVenta.BackColor = System.Drawing.Color.Teal;
			this.BtnGenerarVenta.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.BtnGenerarVenta.Location = new System.Drawing.Point(468, 261);
			this.BtnGenerarVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnGenerarVenta.Name = "BtnGenerarVenta";
			this.BtnGenerarVenta.Size = new System.Drawing.Size(233, 44);
			this.BtnGenerarVenta.TabIndex = 24;
			this.BtnGenerarVenta.Text = "Generar Venta";
			this.BtnGenerarVenta.UseVisualStyleBackColor = false;
			this.BtnGenerarVenta.Click += new System.EventHandler(this.BtnGenerarVenta_Click);
			// 
			// TxtPrecioVenta
			// 
			this.TxtPrecioVenta.Location = new System.Drawing.Point(151, 91);
			this.TxtPrecioVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtPrecioVenta.Name = "TxtPrecioVenta";
			this.TxtPrecioVenta.ReadOnly = true;
			this.TxtPrecioVenta.Size = new System.Drawing.Size(224, 22);
			this.TxtPrecioVenta.TabIndex = 26;
			// 
			// label11
			// 
			this.label11.AutoSize = true;
			this.label11.Location = new System.Drawing.Point(48, 91);
			this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label11.Name = "label11";
			this.label11.Size = new System.Drawing.Size(93, 17);
			this.label11.TabIndex = 25;
			this.label11.Text = "Precio Venta:";
			// 
			// LblTotal
			// 
			this.LblTotal.AutoSize = true;
			this.LblTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.LblTotal.Location = new System.Drawing.Point(1155, 761);
			this.LblTotal.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.LblTotal.Name = "LblTotal";
			this.LblTotal.Size = new System.Drawing.Size(27, 29);
			this.LblTotal.TabIndex = 27;
			this.LblTotal.Text = "0";
			// 
			// label12
			// 
			this.label12.AutoSize = true;
			this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label12.Location = new System.Drawing.Point(1132, 761);
			this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label12.Name = "label12";
			this.label12.Size = new System.Drawing.Size(27, 29);
			this.label12.TabIndex = 28;
			this.label12.Text = "$";
			// 
			// TxtCodigoVenta
			// 
			this.TxtCodigoVenta.Location = new System.Drawing.Point(151, 156);
			this.TxtCodigoVenta.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.TxtCodigoVenta.Name = "TxtCodigoVenta";
			this.TxtCodigoVenta.Size = new System.Drawing.Size(224, 22);
			this.TxtCodigoVenta.TabIndex = 30;
			// 
			// label13
			// 
			this.label13.AutoSize = true;
			this.label13.Location = new System.Drawing.Point(37, 160);
			this.label13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
			this.label13.Name = "label13";
			this.label13.Size = new System.Drawing.Size(97, 17);
			this.label13.TabIndex = 29;
			this.label13.Text = "Código Venta:";
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.btnBuscarEmpleado);
			this.groupBox1.Controls.Add(this.TxtCodgoEmpleado);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.BtnBuscarCliente);
			this.groupBox1.Controls.Add(this.TxtNombreEmpleado);
			this.groupBox1.Controls.Add(this.TxtCodigoCliente);
			this.groupBox1.Controls.Add(this.label6);
			this.groupBox1.Controls.Add(this.label4);
			this.groupBox1.Controls.Add(this.TxtNombreCliente);
			this.groupBox1.Location = new System.Drawing.Point(151, 15);
			this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox1.Size = new System.Drawing.Size(469, 226);
			this.groupBox1.TabIndex = 31;
			//this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Buscar";
			// 
			// btnBuscarEmpleado
			// 
			this.btnBuscarEmpleado.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.btnBuscarEmpleado.Image = global::SisVentaPresentacion.Properties.Resources.icons8_search_36px;
			this.btnBuscarEmpleado.Location = new System.Drawing.Point(371, 27);
			this.btnBuscarEmpleado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.btnBuscarEmpleado.Name = "btnBuscarEmpleado";
			this.btnBuscarEmpleado.Size = new System.Drawing.Size(67, 62);
			this.btnBuscarEmpleado.TabIndex = 32;
			this.btnBuscarEmpleado.UseVisualStyleBackColor = true;
			this.btnBuscarEmpleado.Click += new System.EventHandler(this.button1_Click);
			// 
			// BtnBuscarCliente
			// 
			this.BtnBuscarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBuscarCliente.Image = global::SisVentaPresentacion.Properties.Resources.icons8_search_36px;
			this.BtnBuscarCliente.Location = new System.Drawing.Point(371, 114);
			this.BtnBuscarCliente.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnBuscarCliente.Name = "BtnBuscarCliente";
			this.BtnBuscarCliente.Size = new System.Drawing.Size(67, 62);
			this.BtnBuscarCliente.TabIndex = 6;
			this.BtnBuscarCliente.UseVisualStyleBackColor = true;
			this.BtnBuscarCliente.Click += new System.EventHandler(this.BtnBuscarCliente_Click);
			// 
			// groupBox2
			// 
			this.groupBox2.Controls.Add(this.TxtCodigoProducto);
			this.groupBox2.Controls.Add(this.label9);
			this.groupBox2.Controls.Add(this.TxtCodigoVenta);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label13);
			this.groupBox2.Controls.Add(this.TxtDescripProducto);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.TxtCantidadP);
			this.groupBox2.Controls.Add(this.TxtPrecioVenta);
			this.groupBox2.Controls.Add(this.label11);
			this.groupBox2.Controls.Add(this.BtnBuscarProducto);
			this.groupBox2.Location = new System.Drawing.Point(628, 15);
			this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.groupBox2.Size = new System.Drawing.Size(469, 226);
			this.groupBox2.TabIndex = 32;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Buscar Producto";
			// 
			// BtnBuscarProducto
			// 
			this.BtnBuscarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.BtnBuscarProducto.Image = global::SisVentaPresentacion.Properties.Resources.icons8_search_36px;
			this.BtnBuscarProducto.Location = new System.Drawing.Point(384, 46);
			this.BtnBuscarProducto.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.BtnBuscarProducto.Name = "BtnBuscarProducto";
			this.BtnBuscarProducto.Size = new System.Drawing.Size(67, 62);
			this.BtnBuscarProducto.TabIndex = 22;
			this.BtnBuscarProducto.UseVisualStyleBackColor = true;
			this.BtnBuscarProducto.Click += new System.EventHandler(this.BtnBuscarProducto_Click);
			// 
			// frmDetalleVenta
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1292, 816);
			this.Controls.Add(this.groupBox2);
			this.Controls.Add(this.groupBox1);
			this.Controls.Add(this.label12);
			this.Controls.Add(this.LblTotal);
			this.Controls.Add(this.BtnGenerarVenta);
			this.Controls.Add(this.btnAgregarVenta);
			this.Controls.Add(this.TxtIdProducto);
			this.Controls.Add(this.DgvDetalleVenta);
			this.Controls.Add(this.txtIdCliente);
			this.Controls.Add(this.TxtIdEmpleado);
			this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
			this.Name = "frmDetalleVenta";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "DetalleVenta";
			this.Load += new System.EventHandler(this.frmDetalleVenta_Load);
			((System.ComponentModel.ISupportInitialize)(this.DgvDetalleVenta)).EndInit();
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button BtnBuscarCliente;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox TxtNombreCliente;
        public System.Windows.Forms.TextBox txtIdCliente;
        public System.Windows.Forms.TextBox TxtCodigoCliente;
        private System.Windows.Forms.DataGridView DgvDetalleVenta;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button BtnBuscarProducto;
        private System.Windows.Forms.Button btnAgregarVenta;
        private System.Windows.Forms.Button BtnGenerarVenta;
        public System.Windows.Forms.TextBox TxtDescripProducto;
        public System.Windows.Forms.TextBox TxtIdProducto;
        public System.Windows.Forms.TextBox TxtCodigoProducto;
        public System.Windows.Forms.TextBox TxtCantidadP;
        public System.Windows.Forms.TextBox TxtPrecioVenta;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Label label12;
        public System.Windows.Forms.TextBox TxtCodigoVenta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridViewTextBoxColumn Descripcion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Importe;
        private System.Windows.Forms.DataGridViewTextBoxColumn Id;
        private System.Windows.Forms.DataGridViewButtonColumn Op;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnBuscarEmpleado;
        private System.Windows.Forms.GroupBox groupBox2;
        public System.Windows.Forms.TextBox TxtIdEmpleado;
        public System.Windows.Forms.TextBox TxtNombreEmpleado;
        public System.Windows.Forms.TextBox TxtCodgoEmpleado;
    }
}