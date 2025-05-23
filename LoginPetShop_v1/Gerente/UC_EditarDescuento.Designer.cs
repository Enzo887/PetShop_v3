namespace LoginPetShop_v1.Gerente
{
    partial class UC_EditarDescuento
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
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnEditarDescuento = new System.Windows.Forms.Button();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.tboxDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.tboxNombreDescuento = new System.Windows.Forms.TextBox();
            this.lblNombreDescuento = new System.Windows.Forms.Label();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.cBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.tboxBuscarCliente = new System.Windows.Forms.TextBox();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.Nombre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DNI = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(391, 283);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 23);
            this.btnCancelar.TabIndex = 23;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnEditarDescuento
            // 
            this.btnEditarDescuento.Location = new System.Drawing.Point(391, 238);
            this.btnEditarDescuento.Name = "btnEditarDescuento";
            this.btnEditarDescuento.Size = new System.Drawing.Size(158, 23);
            this.btnEditarDescuento.TabIndex = 22;
            this.btnEditarDescuento.Text = "Editar Descuento";
            this.btnEditarDescuento.UseVisualStyleBackColor = true;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(453, 129);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentaje.TabIndex = 21;
            this.lblPorcentaje.Text = "%";
            // 
            // tboxDescuento
            // 
            this.tboxDescuento.Location = new System.Drawing.Point(391, 126);
            this.tboxDescuento.Name = "tboxDescuento";
            this.tboxDescuento.Size = new System.Drawing.Size(56, 20);
            this.tboxDescuento.TabIndex = 20;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(388, 110);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 19;
            this.lblDescuento.Text = "Descuento";
            // 
            // tboxNombreDescuento
            // 
            this.tboxNombreDescuento.Location = new System.Drawing.Point(391, 72);
            this.tboxNombreDescuento.Name = "tboxNombreDescuento";
            this.tboxNombreDescuento.Size = new System.Drawing.Size(160, 20);
            this.tboxNombreDescuento.TabIndex = 18;
            // 
            // lblNombreDescuento
            // 
            this.lblNombreDescuento.AutoSize = true;
            this.lblNombreDescuento.Location = new System.Drawing.Point(388, 56);
            this.lblNombreDescuento.Name = "lblNombreDescuento";
            this.lblNombreDescuento.Size = new System.Drawing.Size(99, 13);
            this.lblNombreDescuento.TabIndex = 17;
            this.lblNombreDescuento.Text = "Nombre Descuento";
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Descuento});
            this.gridCliente.Location = new System.Drawing.Point(15, 56);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(351, 250);
            this.gridCliente.TabIndex = 16;
            this.gridCliente.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridCliente_CellContentClick);
            // 
            // cBoxFiltrar
            // 
            this.cBoxFiltrar.FormattingEnabled = true;
            this.cBoxFiltrar.Location = new System.Drawing.Point(299, 29);
            this.cBoxFiltrar.Name = "cBoxFiltrar";
            this.cBoxFiltrar.Size = new System.Drawing.Size(65, 21);
            this.cBoxFiltrar.TabIndex = 15;
            // 
            // tboxBuscarCliente
            // 
            this.tboxBuscarCliente.Location = new System.Drawing.Point(89, 30);
            this.tboxBuscarCliente.Name = "tboxBuscarCliente";
            this.tboxBuscarCliente.Size = new System.Drawing.Size(166, 20);
            this.tboxBuscarCliente.TabIndex = 14;
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(261, 31);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lblFiltrar.TabIndex = 13;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Location = new System.Drawing.Point(12, 31);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(75, 13);
            this.lblBuscarCliente.TabIndex = 12;
            this.lblBuscarCliente.Text = "Buscar Cliente";
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // DNI
            // 
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Descuento
            // 
            this.Descuento.HeaderText = "Descuento";
            this.Descuento.Name = "Descuento";
            // 
            // UC_EditarDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditarDescuento);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.tboxDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.tboxNombreDescuento);
            this.Controls.Add(this.lblNombreDescuento);
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.cBoxFiltrar);
            this.Controls.Add(this.tboxBuscarCliente);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblBuscarCliente);
            this.Name = "UC_EditarDescuento";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnEditarDescuento;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.TextBox tboxDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox tboxNombreDescuento;
        private System.Windows.Forms.Label lblNombreDescuento;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.ComboBox cBoxFiltrar;
        private System.Windows.Forms.TextBox tboxBuscarCliente;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.DataGridViewLinkColumn Nombre;
        private System.Windows.Forms.DataGridViewLinkColumn DNI;
        private System.Windows.Forms.DataGridViewLinkColumn Descuento;
    }
}
