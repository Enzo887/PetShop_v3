namespace LoginPetShop_v1.Vendedor
{
    partial class UC_GestionarStock
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.tboxNombre = new System.Windows.Forms.TextBox();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.nUDCantidad = new System.Windows.Forms.NumericUpDown();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.tboxPrecio = new System.Windows.Forms.TextBox();
            this.cBoxCategoria = new System.Windows.Forms.ComboBox();
            this.lblFechaIngreso = new System.Windows.Forms.Label();
            this.inputFechaIngreso = new System.Windows.Forms.DateTimePicker();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnDeshabilitar = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Categoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Precio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.tboxBuscar = new System.Windows.Forms.TextBox();
            this.cBoxFiltrarCategoria = new System.Windows.Forms.ComboBox();
            this.lblFiltrarCategoria = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(34, 37);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // tboxNombre
            // 
            this.tboxNombre.Location = new System.Drawing.Point(37, 53);
            this.tboxNombre.Name = "tboxNombre";
            this.tboxNombre.Size = new System.Drawing.Size(100, 20);
            this.tboxNombre.TabIndex = 1;
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(34, 100);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
            this.lblCategoria.TabIndex = 2;
            this.lblCategoria.Text = "Categoria";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(352, 37);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(49, 13);
            this.lblCantidad.TabIndex = 4;
            this.lblCantidad.Text = "Cantidad";
            // 
            // nUDCantidad
            // 
            this.nUDCantidad.Location = new System.Drawing.Point(355, 55);
            this.nUDCantidad.Name = "nUDCantidad";
            this.nUDCantidad.Size = new System.Drawing.Size(46, 20);
            this.nUDCantidad.TabIndex = 5;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(205, 37);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(37, 13);
            this.lblPrecio.TabIndex = 6;
            this.lblPrecio.Text = "Precio";
            // 
            // tboxPrecio
            // 
            this.tboxPrecio.Location = new System.Drawing.Point(208, 54);
            this.tboxPrecio.Name = "tboxPrecio";
            this.tboxPrecio.Size = new System.Drawing.Size(100, 20);
            this.tboxPrecio.TabIndex = 7;
            // 
            // cBoxCategoria
            // 
            this.cBoxCategoria.FormattingEnabled = true;
            this.cBoxCategoria.Location = new System.Drawing.Point(37, 116);
            this.cBoxCategoria.Name = "cBoxCategoria";
            this.cBoxCategoria.Size = new System.Drawing.Size(100, 21);
            this.cBoxCategoria.TabIndex = 8;
            // 
            // lblFechaIngreso
            // 
            this.lblFechaIngreso.AutoSize = true;
            this.lblFechaIngreso.Location = new System.Drawing.Point(205, 100);
            this.lblFechaIngreso.Name = "lblFechaIngreso";
            this.lblFechaIngreso.Size = new System.Drawing.Size(75, 13);
            this.lblFechaIngreso.TabIndex = 9;
            this.lblFechaIngreso.Text = "Fecha Ingreso";
            // 
            // inputFechaIngreso
            // 
            this.inputFechaIngreso.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.inputFechaIngreso.Location = new System.Drawing.Point(208, 117);
            this.inputFechaIngreso.Name = "inputFechaIngreso";
            this.inputFechaIngreso.Size = new System.Drawing.Size(100, 20);
            this.inputFechaIngreso.TabIndex = 10;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(37, 165);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(100, 23);
            this.btnAgregar.TabIndex = 11;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            // 
            // btnEditar
            // 
            this.btnEditar.Location = new System.Drawing.Point(205, 165);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(103, 23);
            this.btnEditar.TabIndex = 12;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            // 
            // btnDeshabilitar
            // 
            this.btnDeshabilitar.Location = new System.Drawing.Point(355, 165);
            this.btnDeshabilitar.Name = "btnDeshabilitar";
            this.btnDeshabilitar.Size = new System.Drawing.Size(103, 23);
            this.btnDeshabilitar.TabIndex = 13;
            this.btnDeshabilitar.Text = "Deshabilitar";
            this.btnDeshabilitar.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Cantidad,
            this.Categoria,
            this.Precio});
            this.dataGridView1.Location = new System.Drawing.Point(37, 263);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(447, 150);
            this.dataGridView1.TabIndex = 14;
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
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(38, 237);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(40, 13);
            this.lblBuscar.TabIndex = 15;
            this.lblBuscar.Text = "Buscar";
            // 
            // tboxBuscar
            // 
            this.tboxBuscar.Location = new System.Drawing.Point(78, 234);
            this.tboxBuscar.Name = "tboxBuscar";
            this.tboxBuscar.Size = new System.Drawing.Size(297, 20);
            this.tboxBuscar.TabIndex = 16;
            // 
            // cBoxFiltrarCategoria
            // 
            this.cBoxFiltrarCategoria.FormattingEnabled = true;
            this.cBoxFiltrarCategoria.Location = new System.Drawing.Point(387, 234);
            this.cBoxFiltrarCategoria.Name = "cBoxFiltrarCategoria";
            this.cBoxFiltrarCategoria.Size = new System.Drawing.Size(97, 21);
            this.cBoxFiltrarCategoria.TabIndex = 17;
            // 
            // lblFiltrarCategoria
            // 
            this.lblFiltrarCategoria.AutoSize = true;
            this.lblFiltrarCategoria.Location = new System.Drawing.Point(387, 218);
            this.lblFiltrarCategoria.Name = "lblFiltrarCategoria";
            this.lblFiltrarCategoria.Size = new System.Drawing.Size(80, 13);
            this.lblFiltrarCategoria.TabIndex = 18;
            this.lblFiltrarCategoria.Text = "Filtrar Categoria";
            // 
            // UC_GestionarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblFiltrarCategoria);
            this.Controls.Add(this.cBoxFiltrarCategoria);
            this.Controls.Add(this.tboxBuscar);
            this.Controls.Add(this.lblBuscar);
            this.Controls.Add(this.dataGridView1);
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
            this.Name = "UC_GestionarStock";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.nUDCantidad)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox tboxNombre;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown nUDCantidad;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.TextBox tboxPrecio;
        private System.Windows.Forms.ComboBox cBoxCategoria;
        private System.Windows.Forms.Label lblFechaIngreso;
        private System.Windows.Forms.DateTimePicker inputFechaIngreso;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnDeshabilitar;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Categoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn Precio;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.TextBox tboxBuscar;
        private System.Windows.Forms.ComboBox cBoxFiltrarCategoria;
        private System.Windows.Forms.Label lblFiltrarCategoria;
    }
}
