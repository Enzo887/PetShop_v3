namespace LoginPetShop_v1.Vendedor
{
    partial class UC_RegistrarVenta
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblFecha = new System.Windows.Forms.Label();
            this.lblMetodoPago = new System.Windows.Forms.Label();
            this.lblCliente = new System.Windows.Forms.Label();
            this.tboxMetodoPago = new System.Windows.Forms.TextBox();
            this.tboxCliente = new System.Windows.Forms.TextBox();
            this.inputFecha = new System.Windows.Forms.DateTimePicker();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tboxProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.listViewVenta = new System.Windows.Forms.ListView();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.colProducto = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCantidad = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPrecioUnitario = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSubTotal = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            this.SuspendLayout();
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(155, 46);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 0;
            this.lblFecha.Text = "Fecha";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // lblMetodoPago
            // 
            this.lblMetodoPago.AutoSize = true;
            this.lblMetodoPago.Location = new System.Drawing.Point(258, 46);
            this.lblMetodoPago.Name = "lblMetodoPago";
            this.lblMetodoPago.Size = new System.Drawing.Size(86, 13);
            this.lblMetodoPago.TabIndex = 2;
            this.lblMetodoPago.Text = "Metodo de Pago";
            // 
            // lblCliente
            // 
            this.lblCliente.AutoSize = true;
            this.lblCliente.Location = new System.Drawing.Point(28, 46);
            this.lblCliente.Name = "lblCliente";
            this.lblCliente.Size = new System.Drawing.Size(39, 13);
            this.lblCliente.TabIndex = 3;
            this.lblCliente.Text = "Cliente";
            // 
            // tboxMetodoPago
            // 
            this.tboxMetodoPago.Location = new System.Drawing.Point(261, 65);
            this.tboxMetodoPago.Name = "tboxMetodoPago";
            this.tboxMetodoPago.Size = new System.Drawing.Size(100, 20);
            this.tboxMetodoPago.TabIndex = 4;
            // 
            // tboxCliente
            // 
            this.tboxCliente.Location = new System.Drawing.Point(29, 62);
            this.tboxCliente.Name = "tboxCliente";
            this.tboxCliente.Size = new System.Drawing.Size(100, 20);
            this.tboxCliente.TabIndex = 5;
            // 
            // inputFecha
            // 
            this.inputFecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputFecha.Location = new System.Drawing.Point(158, 62);
            this.inputFecha.Name = "inputFecha";
            this.inputFecha.Size = new System.Drawing.Size(87, 20);
            this.inputFecha.TabIndex = 6;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(28, 108);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "Producto";
            // 
            // tboxProducto
            // 
            this.tboxProducto.Location = new System.Drawing.Point(29, 129);
            this.tboxProducto.Name = "tboxProducto";
            this.tboxProducto.Size = new System.Drawing.Size(100, 20);
            this.tboxProducto.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(155, 108);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(158, 129);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(46, 20);
            this.nudCantidad.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(261, 129);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 12;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(258, 108);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 13;
            this.lblPrecio.Text = "Precio";
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(377, 129);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 14;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // listViewVenta
            // 
            this.listViewVenta.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colProducto,
            this.colCantidad,
            this.colPrecioUnitario,
            this.colSubTotal});
            this.listViewVenta.HideSelection = false;
            this.listViewVenta.Location = new System.Drawing.Point(31, 170);
            this.listViewVenta.Name = "listViewVenta";
            this.listViewVenta.Size = new System.Drawing.Size(275, 157);
            this.listViewVenta.TabIndex = 15;
            this.listViewVenta.UseCompatibleStateImageBehavior = false;
            this.listViewVenta.View = System.Windows.Forms.View.Details;
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(207, 347);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Location = new System.Drawing.Point(247, 344);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.Size = new System.Drawing.Size(59, 20);
            this.tboxTotal.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(336, 341);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar Venta";
            this.btnGuardar.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(458, 342);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // colProducto
            // 
            this.colProducto.Text = "Producto";
            // 
            // colCantidad
            // 
            this.colCantidad.Text = "Cantidad";
            // 
            // colPrecioUnitario
            // 
            this.colPrecioUnitario.Text = "Precio Unitario";
            this.colPrecioUnitario.Width = 84;
            // 
            // colSubTotal
            // 
            this.colSubTotal.Text = "SubTotal";
            // 
            // UC_RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.listViewVenta);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tboxProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.inputFecha);
            this.Controls.Add(this.tboxCliente);
            this.Controls.Add(this.tboxMetodoPago);
            this.Controls.Add(this.lblCliente);
            this.Controls.Add(this.lblMetodoPago);
            this.Controls.Add(this.lblFecha);
            this.Name = "UC_RegistrarVenta";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Label lblMetodoPago;
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tboxMetodoPago;
        private System.Windows.Forms.TextBox tboxCliente;
        private System.Windows.Forms.DateTimePicker inputFecha;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox tboxProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.ListView listViewVenta;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.ColumnHeader colProducto;
        private System.Windows.Forms.ColumnHeader colCantidad;
        private System.Windows.Forms.ColumnHeader colPrecioUnitario;
        private System.Windows.Forms.ColumnHeader colSubTotal;
    }
}
