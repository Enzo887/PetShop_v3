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
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.inputFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
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
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(396, 165);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(103, 23);
            this.btnDeshabilitar.TabIndex = 31;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            this.btnDeshabilitar.Click += new System.EventHandler(this.btnDeshabilitar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(246, 165);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 23);
            this.btnEditar.TabIndex = 30;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(78, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 29;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // inputFechaIngreso
            // 
            this.inputFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputFechaIngreso.Location = new System.Drawing.Point(249, 117);
            this.inputFechaIngreso.Name = "inputFechaIngreso";
            this.inputFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.inputFechaIngreso.TabIndex = 28;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(246, 100);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(75, 13);
            this.lblFechaIngreso.TabIndex = 27;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(78, 116);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.cBoxCategoria.TabIndex = 26;
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(249, 54);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecio.TabIndex = 25;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(246, 37);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 24;
            this.lblPrecio.Text = "Precio";
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Location = new System.Drawing.Point(396, 55);
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(46, 20);
            this.nUDCantidad.TabIndex = 23;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(393, 37);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 22;
            this.lblCantidad.Text = "Cantidad";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(75, 100);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 21;
            this.lblCategoria.Text = "Categoria";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(78, 53);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 20;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(75, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 19;
            this.lblNombre.Text = "Nombre";
            // 
            // AgregarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tboxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.btnDeshabilitar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.inputFechaIngreso);
            this.Controls.Add(this.lblFechaIngreso);
            this.Controls.Add(this.cBoxCategoria);
            this.Controls.Add(this.tboxPrecio);
            this.Controls.Add(this.lblPrecio);
            this.Controls.Add(this.nUDCantidad);
            this.Controls.Add(this.lblCantidad);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.tboxNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "AgregarProducto";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
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
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.DateTimePicker inputFechaIngreso;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblNombre;
    }
}
