namespace LoginPetShop_v1.Veterinario
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
            this.btnVolver = new System.Windows.Forms.Button();
            this.lblProductosxVencer = new System.Windows.Forms.Label();
            this.btnAgregarProducto = new System.Windows.Forms.Button();
            this.lblBuscarProducto = new System.Windows.Forms.Label();
            this.tBoxBuscarProducto = new System.Windows.Forms.TextBox();
            this.lblProductos = new System.Windows.Forms.Label();
            this.dataGridViewProductos = new System.Windows.Forms.DataGridView();
            this.NombreProducto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Editar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.dataGridViewProductoProxVencimiento = new System.Windows.Forms.DataGridView();
            this.NombreProducto2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Vencimiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantidadRestante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductoProxVencimiento)).BeginInit();
            this.SuspendLayout();
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(450, 330);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 41);
            this.btnVolver.TabIndex = 19;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // lblProductosxVencer
            // 
            this.lblProductosxVencer.AutoSize = true;
            this.lblProductosxVencer.Location = new System.Drawing.Point(332, 86);
            this.lblProductosxVencer.Name = "lblProductosxVencer";
            this.lblProductosxVencer.Size = new System.Drawing.Size(144, 13);
            this.lblProductosxVencer.TabIndex = 18;
            this.lblProductosxVencer.Text = "Proximos productos a vencer";
            // 
            // btnAgregarProducto
            // 
            this.btnAgregarProducto.Location = new System.Drawing.Point(316, 330);
            this.btnAgregarProducto.Name = "btnAgregarProducto";
            this.btnAgregarProducto.Size = new System.Drawing.Size(82, 41);
            this.btnAgregarProducto.TabIndex = 17;
            this.btnAgregarProducto.Text = "Agregar producto";
            this.btnAgregarProducto.UseVisualStyleBackColor = true;
            this.btnAgregarProducto.Click += new System.EventHandler(this.btnAgregarProducto_Click);
            // 
            // lblBuscarProducto
            // 
            this.lblBuscarProducto.AutoSize = true;
            this.lblBuscarProducto.Location = new System.Drawing.Point(34, 33);
            this.lblBuscarProducto.Name = "lblBuscarProducto";
            this.lblBuscarProducto.Size = new System.Drawing.Size(85, 13);
            this.lblBuscarProducto.TabIndex = 14;
            this.lblBuscarProducto.Text = "Buscar producto";
            // 
            // tBoxBuscarProducto
            // 
            this.tBoxBuscarProducto.Location = new System.Drawing.Point(34, 52);
            this.tBoxBuscarProducto.Name = "tBoxBuscarProducto";
            this.tBoxBuscarProducto.Size = new System.Drawing.Size(210, 20);
            this.tBoxBuscarProducto.TabIndex = 13;
            this.tBoxBuscarProducto.TextChanged += new System.EventHandler(this.tBoxBuscarProducto_TextChanged);
            // 
            // lblProductos
            // 
            this.lblProductos.AutoSize = true;
            this.lblProductos.Location = new System.Drawing.Point(34, 86);
            this.lblProductos.Name = "lblProductos";
            this.lblProductos.Size = new System.Drawing.Size(55, 13);
            this.lblProductos.TabIndex = 12;
            this.lblProductos.Text = "Productos";
            // 
            // dataGridViewProductos
            // 
            this.dataGridViewProductos.AllowUserToAddRows = false;
            this.dataGridViewProductos.AllowUserToDeleteRows = false;
            this.dataGridViewProductos.AllowUserToResizeColumns = false;
            this.dataGridViewProductos.AllowUserToResizeRows = false;
            this.dataGridViewProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto,
            this.Estado,
            this.Editar});
            this.dataGridViewProductos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProductos.Location = new System.Drawing.Point(34, 114);
            this.dataGridViewProductos.Name = "dataGridViewProductos";
            this.dataGridViewProductos.ReadOnly = true;
            this.dataGridViewProductos.RowHeadersVisible = false;
            this.dataGridViewProductos.Size = new System.Drawing.Size(228, 257);
            this.dataGridViewProductos.TabIndex = 20;
            this.dataGridViewProductos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductos_CellContentClick);
            // 
            // NombreProducto
            // 
            this.NombreProducto.HeaderText = "Nombre de producto";
            this.NombreProducto.Name = "NombreProducto";
            this.NombreProducto.ReadOnly = true;
            // 
            // Estado
            // 
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Width = 75;
            // 
            // Editar
            // 
            this.Editar.HeaderText = "";
            this.Editar.Name = "Editar";
            this.Editar.ReadOnly = true;
            this.Editar.Width = 50;
            // 
            // dataGridViewProductoProxVencimiento
            // 
            this.dataGridViewProductoProxVencimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewProductoProxVencimiento.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreProducto2,
            this.Vencimiento,
            this.CantidadRestante});
            this.dataGridViewProductoProxVencimiento.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewProductoProxVencimiento.Location = new System.Drawing.Point(335, 114);
            this.dataGridViewProductoProxVencimiento.Name = "dataGridViewProductoProxVencimiento";
            this.dataGridViewProductoProxVencimiento.ReadOnly = true;
            this.dataGridViewProductoProxVencimiento.RowHeadersVisible = false;
            this.dataGridViewProductoProxVencimiento.RowHeadersWidth = 30;
            this.dataGridViewProductoProxVencimiento.Size = new System.Drawing.Size(223, 97);
            this.dataGridViewProductoProxVencimiento.TabIndex = 21;
            this.dataGridViewProductoProxVencimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewProductoProxVencimiento_CellContentClick);
            // 
            // NombreProducto2
            // 
            this.NombreProducto2.HeaderText = "Nombre de producto";
            this.NombreProducto2.Name = "NombreProducto2";
            this.NombreProducto2.ReadOnly = true;
            // 
            // Vencimiento
            // 
            this.Vencimiento.HeaderText = "Vencimiento";
            this.Vencimiento.Name = "Vencimiento";
            this.Vencimiento.ReadOnly = true;
            this.Vencimiento.Width = 70;
            // 
            // CantidadRestante
            // 
            this.CantidadRestante.HeaderText = "Cantidad restante";
            this.CantidadRestante.Name = "CantidadRestante";
            this.CantidadRestante.ReadOnly = true;
            this.CantidadRestante.Width = 50;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(250, 52);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(49, 23);
            this.btnBuscar.TabIndex = 22;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // UC_GestionarStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.dataGridViewProductoProxVencimiento);
            this.Controls.Add(this.dataGridViewProductos);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblProductosxVencer);
            this.Controls.Add(this.btnAgregarProducto);
            this.Controls.Add(this.lblBuscarProducto);
            this.Controls.Add(this.tBoxBuscarProducto);
            this.Controls.Add(this.lblProductos);
            this.Name = "UC_GestionarStock";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewProductoProxVencimiento)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Label lblProductosxVencer;
        private System.Windows.Forms.Button btnAgregarProducto;
        private System.Windows.Forms.Label lblBuscarProducto;
        private System.Windows.Forms.TextBox tBoxBuscarProducto;
        private System.Windows.Forms.Label lblProductos;
        private System.Windows.Forms.DataGridView dataGridViewProductos;
        private System.Windows.Forms.DataGridView dataGridViewProductoProxVencimiento;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
        private System.Windows.Forms.DataGridViewButtonColumn Editar;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreProducto2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vencimiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantidadRestante;
    }
}
