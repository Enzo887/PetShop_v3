namespace LoginPetShop_v1.Veterinario
{
    partial class UC_AgregarProducto
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
            this.tboxBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.inputFechaVencimiento = new System.Windows.Forms.DateTimePicker();
            this.lblFechaVencimiento = new System.Windows.Forms.Label();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.tboxPrecioProducto = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nUDCantidadProducto = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tboxNombreProducto = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.cBoxReceta = new System.Windows.Forms.ComboBox();
            this.lblReceta = new System.Windows.Forms.Label();
            this.cBoxEstado = new System.Windows.Forms.ComboBox();
            this.lblEstado = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadProducto)).BeginInit();
            this.SuspendLayout();
            // 
            // tboxBuscar
            // 
            this.tboxBuscar.Location = new System.Drawing.Point(119, 234);
            this.tboxBuscar.Name = "tboxBuscar";
            this.tboxBuscar.Size = new System.Drawing.Size(297, 20);
            this.tboxBuscar.TabIndex = 34;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(79, 237);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 33;
            this.lblBuscar.Text = "Buscar";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Categoria,
            this.Precio});
            this.dataGridViewProductos.Location = new System.Drawing.Point(78, 263);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.Size = new System.Drawing.Size(447, 150);
            this.dataGridViewProductos.TabIndex = 32;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // Cantidad
            // 
            this.Cantidad.HeaderText = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            // 
            // Categoria
            // 
            this.Categoria.HeaderText = "Categoria";
            this.Categoria.Name = "Categoria";
            // 
            // Precio
            // 
            this.Precio.HeaderText = "Precio";
            this.Precio.Name = "Precio";
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(246, 200);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 23);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 200);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // inputFechaVencimiento
            // 
            this.inputFechaVencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputFechaVencimiento.Location = new System.Drawing.Point(249, 109);
            this.inputFechaVencimiento.Name = "inputFechaVencimiento";
            this.inputFechaVencimiento.Size = new System.Drawing.Size(100, 20);
            this.inputFechaVencimiento.TabIndex = 28;
            // 
            // lblFechaVencimiento
            // 
            this.lblFechaVencimiento.AutoSize = true;
            this.lblFechaVencimiento.Location = new System.Drawing.Point(246, 92);
            this.lblFechaVencimiento.Name = "lblFechaVencimiento";
            this.lblFechaVencimiento.Size = new System.Drawing.Size(112, 13);
            this.lblFechaVencimiento.TabIndex = 27;
            this.lblFechaVencimiento.Text = "Fecha de vencimiento";
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Items.AddRange(new object[] {
            "Vacuna",
            "Medicamento"});
            this.cBoxCategoria.Location = new System.Drawing.Point(78, 108);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.cBoxCategoria.TabIndex = 26;
            // 
            // tboxPrecioProducto
            // 
            this.tboxPrecioProducto.Location = new System.Drawing.Point(249, 46);
            this.tboxPrecioProducto.Name = "tboxPrecioProducto";
            this.tboxPrecioProducto.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecioProducto.TabIndex = 25;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(246, 29);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // nUDCantidadProducto
            // 
            this.nUDCantidadProducto.Location = new System.Drawing.Point(396, 47);
            this.nUDCantidadProducto.Name = "nUDCantidadProducto";
            this.nUDCantidadProducto.Size = new System.Drawing.Size(46, 20);
            this.nUDCantidadProducto.TabIndex = 23;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(393, 29);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(75, 92);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria";
            // 
            // tboxNombreProducto
            // 
            this.tboxNombreProducto.Location = new System.Drawing.Point(78, 45);
            this.tboxNombreProducto.Name = "tboxNombreProducto";
            this.tboxNombreProducto.Size = new System.Drawing.Size(100, 20);
            this.tboxNombreProducto.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(75, 29);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // cBoxReceta
            // 
            this.cBoxReceta.FormattingEnabled = true;
            this.cBoxReceta.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cBoxReceta.Location = new System.Drawing.Point(396, 109);
            this.cBoxReceta.Name = "cBoxReceta";
            this.cBoxReceta.Size = new System.Drawing.Size(74, 21);
            this.cBoxReceta.TabIndex = 35;
            // 
            // lblReceta
            // 
            this.lblReceta.AutoSize = true;
            this.lblReceta.Location = new System.Drawing.Point(393, 93);
            this.lblReceta.Name = "lblReceta";
            this.lblReceta.Size = new System.Drawing.Size(88, 13);
            this.lblReceta.TabIndex = 36;
            this.lblReceta.Text = "Necesita receta?";
            // 
            // cBoxEstado
            // 
            this.cBoxEstado.FormattingEnabled = true;
            this.cBoxEstado.Items.AddRange(new object[] {
            "Habilitado",
            "Deshabilitado"});
            this.cBoxEstado.Location = new System.Drawing.Point(78, 157);
            this.cBoxEstado.Name = "cBoxEstado";
            this.cBoxEstado.Size = new System.Drawing.Size(121, 21);
            this.cBoxEstado.TabIndex = 37;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(75, 141);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(168, 13);
            this.lblEstado.TabIndex = 38;
            this.lblEstado.Text = "Seleccione el estado del producto";
            // 
            // UC_AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.cBoxEstado);
            this.Controls.Add(this.lblReceta);
            this.Controls.Add(this.cBoxReceta);
            this.Controls.Add(this.tboxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.inputFechaVencimiento);
            this.Controls.Add(this.lblFechaVencimiento);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.tboxPrecioProducto);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nUDCantidadProducto);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tboxNombreProducto);
            this.Controls.Add(this.lblNombre);
            this.Name = "UC_AgregarProducto";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidadProducto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox tboxBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker inputFechaVencimiento;
        private System.Windows.Forms.Label lblFechaVencimiento;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.TextBox tboxPrecioProducto;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nUDCantidadProducto;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox tboxNombreProducto;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.ComboBox cBoxReceta;
        private System.Windows.Forms.Label lblReceta;
        private System.Windows.Forms.ComboBox cBoxEstado;
        private System.Windows.Forms.Label lblEstado;
    }
}
