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
            this.lblNombreDescuento = new System.Windows.Forms.Label();
            this.tboxNombreDescuento = new System.Windows.Forms.TextBox();
            this.lblDescuento = new System.Windows.Forms.Label();
            this.tboxDescuento = new System.Windows.Forms.TextBox();
            this.lblPorcentaje = new System.Windows.Forms.Label();
            this.btnCrearDescuento = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombreDescuento
            // 
            this.lblNombreDescuento.AutoSize = true;
            this.lblNombreDescuento.Location = new System.Drawing.Point(202, 85);
            this.lblNombreDescuento.Name = "lblNombreDescuento";
            this.lblNombreDescuento.Size = new System.Drawing.Size(99, 13);
            this.lblNombreDescuento.TabIndex = 5;
            this.lblNombreDescuento.Text = "Nombre Descuento";
            // 
            // tboxNombreDescuento
            // 
            this.tboxNombreDescuento.Location = new System.Drawing.Point(205, 101);
            this.tboxNombreDescuento.Name = "tboxNombreDescuento";
            this.tboxNombreDescuento.Size = new System.Drawing.Size(160, 20);
            this.tboxNombreDescuento.TabIndex = 6;
            // 
            // lblDescuento
            // 
            this.lblDescuento.AutoSize = true;
            this.lblDescuento.Location = new System.Drawing.Point(202, 147);
            this.lblDescuento.Name = "lblDescuento";
            this.lblDescuento.Size = new System.Drawing.Size(59, 13);
            this.lblDescuento.TabIndex = 7;
            this.lblDescuento.Text = "Descuento";
            // 
            // tboxDescuento
            // 
            this.tboxDescuento.Location = new System.Drawing.Point(205, 163);
            this.tboxDescuento.Name = "tboxDescuento";
            this.tboxDescuento.Size = new System.Drawing.Size(56, 20);
            this.tboxDescuento.TabIndex = 8;
            // 
            // lblPorcentaje
            // 
            this.lblPorcentaje.AutoSize = true;
            this.lblPorcentaje.Location = new System.Drawing.Point(267, 170);
            this.lblPorcentaje.Name = "lblPorcentaje";
            this.lblPorcentaje.Size = new System.Drawing.Size(15, 13);
            this.lblPorcentaje.TabIndex = 9;
            this.lblPorcentaje.Text = "%";
            // 
            // btnCrearDescuento
            // 
            this.btnCrearDescuento.Location = new System.Drawing.Point(205, 248);
            this.btnCrearDescuento.Name = "btnCrearDescuento";
            this.btnCrearDescuento.Size = new System.Drawing.Size(158, 23);
            this.btnCrearDescuento.TabIndex = 10;
            this.btnCrearDescuento.Text = "Crear Descuento";
            this.btnCrearDescuento.UseVisualStyleBackColor = true;
            this.btnCrearDescuento.Click += new System.EventHandler(this.btnCrearDescuento_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(207, 277);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(158, 23);
            this.btnCancelar.TabIndex = 11;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // UC_CrearDescuento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCrearDescuento);
            this.Controls.Add(this.lblPorcentaje);
            this.Controls.Add(this.tboxDescuento);
            this.Controls.Add(this.lblDescuento);
            this.Controls.Add(this.tboxNombreDescuento);
            this.Controls.Add(this.lblNombreDescuento);
            this.Name = "UC_CrearDescuento";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblNombreDescuento;
        private System.Windows.Forms.TextBox tboxNombreDescuento;
        private System.Windows.Forms.Label lblDescuento;
        private System.Windows.Forms.TextBox tboxDescuento;
        private System.Windows.Forms.Label lblPorcentaje;
        private System.Windows.Forms.Button btnCrearDescuento;
        private System.Windows.Forms.Button btnCancelar;
    }
}
