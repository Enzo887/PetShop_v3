namespace LoginPetShop_v1.Gerente
{
    partial class UC_CrearDescuento
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
            this.lblBuscarCliente = new System.Windows.Forms.Label();
            this.lblFiltrar = new System.Windows.Forms.Label();
            this.tboxBuscarCliente = new System.Windows.Forms.TextBox();
            this.cBoxFiltrar = new System.Windows.Forms.ComboBox();
            this.lblNombreDescuento = new System.Windows.Forms.Label();
            this.tboxNombreDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.tboxDescuento = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnCrearDescuento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.gridCliente = new System.Windows.Forms.DataGridView();
            this.Nombre = new System.Windows.Forms.DataGridViewLinkColumn();
            this.DNI = new System.Windows.Forms.DataGridViewLinkColumn();
            this.Descuento = new System.Windows.Forms.DataGridViewLinkColumn();
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblBuscarCliente
            // 
            this.lblBuscarCliente.AutoSize = true;
            this.lblBuscarCliente.Location = new System.Drawing.Point(33, 29);
            this.lblBuscarCliente.Name = "lblBuscarCliente";
            this.lblBuscarCliente.Size = new System.Drawing.Size(75, 13);
            this.lblBuscarCliente.TabIndex = 0;
            this.lblBuscarCliente.Text = "Buscar Cliente";
            // 
            // lblFiltrar
            // 
            this.lblFiltrar.AutoSize = true;
            this.lblFiltrar.Location = new System.Drawing.Point(282, 29);
            this.lblFiltrar.Name = "lblFiltrar";
            this.lblFiltrar.Size = new System.Drawing.Size(32, 13);
            this.lblFiltrar.TabIndex = 1;
            this.lblFiltrar.Text = "Filtrar";
            // 
            // tboxBuscarCliente
            // 
            this.tboxBuscarCliente.Location = new System.Drawing.Point(110, 28);
            this.tboxBuscarCliente.Name = "tboxBuscarCliente";
            this.tboxBuscarCliente.Size = new System.Drawing.Size(166, 20);
            this.tboxBuscarCliente.TabIndex = 2;
            // 
            // cBoxFiltrar
            // 
            this.cBoxFiltrar.FormattingEnabled = true;
            this.cBoxFiltrar.Location = new System.Drawing.Point(311, 27);
            this.cBoxFiltrar.Name = "cBoxFiltrar";
            this.cBoxFiltrar.Size = new System.Drawing.Size(65, 21);
            this.cBoxFiltrar.TabIndex = 3;
            // 
            // lblNombreDescuento
            // 
            this.lblNombreDescuento.AutoSize = true;
            this.lblNombreDescuento.Location = new System.Drawing.Point(409, 54);
            this.lblNombreDescuento.Name = "lblNombreDescuento";
            this.lblNombreDescuento.Size = new System.Drawing.Size(99, 13);
            this.lblNombreDescuento.TabIndex = 5;
            this.lblNombreDescuento.Text = "Nombre Descuento";
            // 
            // tboxNombreDescuento
            // 
            this.tboxNombreDescuento.Location = new System.Drawing.Point(412, 70);
            this.tboxNombreDescuento.Name = "tboxNombreDescuento";
            this.tboxNombreDescuento.Size = new System.Drawing.Size(160, 20);
            this.tboxNombreDescuento.TabIndex = 6;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(409, 108);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento";
            // 
            // tboxDescuento
            // 
            this.tboxDescuento.Location = new System.Drawing.Point(412, 124);
            this.tboxDescuento.Name = "tboxDescuento";
            this.tboxDescuento.Size = new System.Drawing.Size(56, 20);
            this.tboxDescuento.TabIndex = 8;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(474, 127);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentaje.TabIndex = 9;
            this.lblPorcentaje.Text = "%";
            // 
            // btnCrearDescuento
            // 
            this.btnCrearDescuento.Location = new System.Drawing.Point(412, 236);
            this.btnCrearDescuento.Name = "btnCrearDescuento";
            this.btnCrearDescuento.Size = new System.Drawing.Size(158, 23);
            this.btnCrearDescuento.TabIndex = 10;
            this.btnCrearDescuento.Text = "Crear Descuento";
            this.btnCrearDescuento.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(412, 281);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // gridCliente
            // 
            this.gridCliente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridCliente.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.DNI,
            this.Descuento});
            this.gridCliente.Location = new System.Drawing.Point(36, 54);
            this.gridCliente.Name = "gridCliente";
            this.gridCliente.Size = new System.Drawing.Size(351, 250);
            this.gridCliente.TabIndex = 17;
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
            // UC_CrearDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gridCliente);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearDescuento);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.tboxDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.tboxNombreDescuento);
            this.Controls.Add(this.lblNombreDescuento);
            this.Controls.Add(this.cBoxFiltrar);
            this.Controls.Add(this.tboxBuscarCliente);
            this.Controls.Add(this.lblFiltrar);
            this.Controls.Add(this.lblBuscarCliente);
            this.Name = "UC_CrearDescuento";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.gridCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBuscarCliente;
        private System.Windows.Forms.Label lblFiltrar;
        private System.Windows.Forms.TextBox tboxBuscarCliente;
        private System.Windows.Forms.ComboBox cBoxFiltrar;
        private System.Windows.Forms.Label lblNombreDescuento;
        private System.Windows.Forms.TextBox tboxNombreDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox tboxDescuento;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnCrearDescuento;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.DataGridView gridCliente;
        private System.Windows.Forms.DataGridViewLinkColumn Nombre;
        private System.Windows.Forms.DataGridViewLinkColumn DNI;
        private System.Windows.Forms.DataGridViewLinkColumn Descuento;
    }
}
