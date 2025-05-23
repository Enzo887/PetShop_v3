namespace LoginPetShop_v1.Gerente
{
    partial class UC_Descuentos
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
            this.lblListaDescuentos = new System.Windows.Forms.Label();
            this.gridListaDescuentos = new System.Windows.Forms.DataGridView();
            this.NombreDescuento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Porcentaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAgregarDescuento = new System.Windows.Forms.Button();
            this.btnEditarDescuento = new System.Windows.Forms.Button();
            this.btnEliminarDescuento = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDescuentos)).BeginInit();
            this.SuspendLayout();
            // 
            // lblListaDescuentos
            // 
            this.lblListaDescuentos.AutoSize = true;
            this.lblListaDescuentos.Location = new System.Drawing.Point(28, 26);
            this.lblListaDescuentos.Name = "lblListaDescuentos";
            this.lblListaDescuentos.Size = new System.Drawing.Size(89, 13);
            this.lblListaDescuentos.TabIndex = 0;
            this.lblListaDescuentos.Text = "Lista Descuentos";
            // 
            // gridListaDescuentos
            // 
            this.gridListaDescuentos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridListaDescuentos.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreDescuento,
            this.Cliente,
            this.Porcentaje});
            this.gridListaDescuentos.Location = new System.Drawing.Point(31, 42);
            this.gridListaDescuentos.Name = "gridListaDescuentos";
            this.gridListaDescuentos.Size = new System.Drawing.Size(345, 283);
            this.gridListaDescuentos.TabIndex = 1;
            // 
            // NombreDescuento
            // 
            this.NombreDescuento.HeaderText = "Nombre Descuento";
            this.NombreDescuento.Name = "NombreDescuento";
            // 
            // Cliente
            // 
            this.Cliente.HeaderText = "Cliente";
            this.Cliente.Name = "Cliente";
            // 
            // Porcentaje
            // 
            this.Porcentaje.HeaderText = "Porcentaje";
            this.Porcentaje.Name = "Porcentaje";
            // 
            // btnAgregarDescuento
            // 
            this.btnAgregarDescuento.Location = new System.Drawing.Point(31, 347);
            this.btnAgregarDescuento.Name = "btnAgregarDescuento";
            this.btnAgregarDescuento.Size = new System.Drawing.Size(110, 23);
            this.btnAgregarDescuento.TabIndex = 2;
            this.btnAgregarDescuento.Text = "Agregar Descuento";
            this.btnAgregarDescuento.UseVisualStyleBackColor = true;
            // 
            // btnEditarDescuento
            // 
            this.btnEditarDescuento.Location = new System.Drawing.Point(392, 59);
            this.btnEditarDescuento.Name = "btnEditarDescuento";
            this.btnEditarDescuento.Size = new System.Drawing.Size(108, 23);
            this.btnEditarDescuento.TabIndex = 3;
            this.btnEditarDescuento.Text = "Editar Descuento";
            this.btnEditarDescuento.UseVisualStyleBackColor = true;
            // 
            // btnEliminarDescuento
            // 
            this.btnEliminarDescuento.Location = new System.Drawing.Point(394, 88);
            this.btnEliminarDescuento.Name = "btnEliminarDescuento";
            this.btnEliminarDescuento.Size = new System.Drawing.Size(106, 23);
            this.btnEliminarDescuento.TabIndex = 4;
            this.btnEliminarDescuento.Text = "Eliminar Descuento";
            this.btnEliminarDescuento.UseVisualStyleBackColor = true;
            // 
            // UC_Descuentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnEliminarDescuento);
            this.Controls.Add(this.btnEditarDescuento);
            this.Controls.Add(this.btnAgregarDescuento);
            this.Controls.Add(this.gridListaDescuentos);
            this.Controls.Add(this.lblListaDescuentos);
            this.Name = "UC_Descuentos";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.gridListaDescuentos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblListaDescuentos;
        private System.Windows.Forms.DataGridView gridListaDescuentos;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreDescuento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn Porcentaje;
        private System.Windows.Forms.Button btnAgregarDescuento;
        private System.Windows.Forms.Button btnEditarDescuento;
        private System.Windows.Forms.Button btnEliminarDescuento;
    }
}
