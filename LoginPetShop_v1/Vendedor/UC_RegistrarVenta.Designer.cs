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
            this.lblCliente = new System.Windows.Forms.Label();
            this.tboxCliente = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.tboxProducto = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nudCantidad = new System.Windows.Forms.NumericUpDown();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblTotal = new System.Windows.Forms.Label();
            this.tboxTotal = new System.Windows.Forms.TextBox();
            this.btnGuardar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnBuscarCliente = new System.Windows.Forms.Button();
            this.tboxClienteBuscado = new System.Windows.Forms.TextBox();
            this.btnBuscarProducto = new System.Windows.Forms.Button();
            this.tboxProductoBuscado = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.gridVenta = new System.Windows.Forms.DataGridView();
            this.producto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PrecioUnitario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).BeginInit();
            this.SuspendLayout();
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
            // tboxCliente
            // 
            this.tboxCliente.Location = new System.Drawing.Point(29, 62);
            this.tboxCliente.Name = "tboxCliente";
            this.tboxCliente.Size = new System.Drawing.Size(100, 20);
            this.tboxCliente.TabIndex = 5;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Location = new System.Drawing.Point(229, 46);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(50, 13);
            this.lblProducto.TabIndex = 8;
            this.lblProducto.Text = "Producto";
            // 
            // tboxProducto
            // 
            this.tboxProducto.Location = new System.Drawing.Point(232, 62);
            this.tboxProducto.Name = "tboxProducto";
            this.tboxProducto.Size = new System.Drawing.Size(100, 20);
            this.tboxProducto.TabIndex = 9;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(404, 47);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(78, 13);
            this.lblCantidad.TabIndex = 10;
            this.lblCantidad.Text = "Cantidad/Peso";
            // 
            // nudCantidad
            // 
            this.nudCantidad.Location = new System.Drawing.Point(407, 63);
            this.nudCantidad.Name = "nudCantidad";
            this.nudCantidad.Size = new System.Drawing.Size(75, 20);
            this.nudCantidad.TabIndex = 11;
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(404, 91);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(78, 23);
            this.btnAgregarProducto.TabIndex = 14;
            this.btnAgregarProducto.Text = "Agregar";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblTotal
            // 
            this.lblTotal.AutoSize = true;
            this.lblTotal.Location = new System.Drawing.Point(192, 327);
            this.lblTotal.Name = "lblTotal";
            this.lblTotal.Size = new System.Drawing.Size(34, 13);
            this.lblTotal.TabIndex = 16;
            this.lblTotal.Text = "Total:";
            // 
            // tboxTotal
            // 
            this.tboxTotal.Location = new System.Drawing.Point(232, 324);
            this.tboxTotal.Name = "tboxTotal";
            this.tboxTotal.Size = new System.Drawing.Size(59, 20);
            this.tboxTotal.TabIndex = 17;
            // 
            // btnGuardar
            // 
            this.btnGuardar.Location = new System.Drawing.Point(268, 362);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Size = new System.Drawing.Size(116, 23);
            this.btnGuardar.TabIndex = 18;
            this.btnGuardar.Text = "Guardar Venta";
            this.btnGuardar.UseVisualStyleBackColor = true;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(390, 362);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(73, 23);
            this.btnCancelar.TabIndex = 19;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnBuscarCliente
            // 
            this.btnBuscarCliente.Location = new System.Drawing.Point(144, 60);
            this.btnBuscarCliente.Name = "btnBuscarCliente";
            this.btnBuscarCliente.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarCliente.TabIndex = 20;
            this.btnBuscarCliente.Text = "Buscar";
            this.btnBuscarCliente.UseVisualStyleBackColor = true;
            this.btnBuscarCliente.Click += new System.EventHandler(this.btnBuscarCliente_Click);
            // 
            // tboxClienteBuscado
            // 
            this.tboxClienteBuscado.Location = new System.Drawing.Point(29, 91);
            this.tboxClienteBuscado.Name = "tboxClienteBuscado";
            this.tboxClienteBuscado.ReadOnly = true;
            this.tboxClienteBuscado.Size = new System.Drawing.Size(175, 20);
            this.tboxClienteBuscado.TabIndex = 21;
            // 
            // btnBuscarProducto
            // 
            this.btnBuscarProducto.Location = new System.Drawing.Point(338, 60);
            this.btnBuscarProducto.Name = "btnBuscarProducto";
            this.btnBuscarProducto.Size = new System.Drawing.Size(60, 23);
            this.btnBuscarProducto.TabIndex = 22;
            this.btnBuscarProducto.Text = "Buscar";
            this.btnBuscarProducto.UseVisualStyleBackColor = true;
            this.btnBuscarProducto.Click += new System.EventHandler(this.btnBuscarProducto_Click);
            // 
            // tboxProductoBuscado
            // 
            this.tboxProductoBuscado.Location = new System.Drawing.Point(232, 91);
            this.tboxProductoBuscado.Name = "tboxProductoBuscado";
            this.tboxProductoBuscado.ReadOnly = true;
            this.tboxProductoBuscado.Size = new System.Drawing.Size(166, 20);
            this.tboxProductoBuscado.TabIndex = 23;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(28, 329);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(97, 13);
            this.lblDescuento.TabIndex = 24;
            this.lblDescuento.Text = "Descuento al Total";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(31, 345);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(130, 21);
            this.comboBox1.TabIndex = 25;
            // 
            // gridVenta
            // 
            this.gridVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.producto,
            this.Cantidad,
            this.PrecioUnitario,
            this.SubTotal});
            this.gridVenta.Location = new System.Drawing.Point(29, 147);
            this.gridVenta.Name = "gridVenta";
            this.gridVenta.Size = new System.Drawing.Size(453, 150);
            this.gridVenta.TabIndex = 26;
            // 
            // producto
            // 
            this.producto.HeaderText = "Producto";
            this.producto.Name = "producto";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // PrecioUnitario
            // 
            this.PrecioUnitario.HeaderText = "Precio Unitario";
            this.PrecioUnitario.Name = "PrecioUnitario";
            // 
            // SubTotal
            // 
            this.SubTotal.HeaderText = "Sub Total";
            this.SubTotal.Name = "SubTotal";
            // 
            // UC_RegistrarVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridVenta);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.tboxProductoBuscado);
            this.Controls.Add(this.btnBuscarProducto);
            this.Controls.Add(this.tboxClienteBuscado);
            this.Controls.Add(this.btnBuscarCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.tboxTotal);
            this.Controls.Add(this.lblTotal);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.nudCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.tboxProducto);
            this.Controls.Add(this.lblProducto);
            this.Controls.Add(this.tboxCliente);
            this.Controls.Add(this.lblCliente);
            this.Name = "UC_RegistrarVenta";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.nudCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridVenta)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCliente;
        private System.Windows.Forms.TextBox tboxCliente;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.TextBox tboxProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nudCantidad;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblTotal;
        private System.Windows.Forms.TextBox tboxTotal;
        private System.Windows.Forms.Button btnGuardar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBuscarCliente;
        private System.Windows.Forms.TextBox tboxClienteBuscado;
        private System.Windows.Forms.Button btnBuscarProducto;
        private System.Windows.Forms.TextBox tboxProductoBuscado;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView gridVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn PrecioUnitario;
        private System.Windows.Forms.DataGridViewTextBoxColumn SubTotal;
    }
}
