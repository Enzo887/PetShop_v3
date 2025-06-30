namespace LoginPetShop_v1.Veterinario
{
    partial class UC_AgregarConsulta
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
            this.lblTituloDiagnostico = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.tBoxDiagnostico = new System.Windows.Forms.TextBox();
            this.tBoxDescripcion = new System.Windows.Forms.TextBox();
            this.lblTratamiento = new System.Windows.Forms.Label();
            this.tBoxTratamiento = new System.Windows.Forms.TextBox();
            this.dTPFechaConsulta = new System.Windows.Forms.DateTimePicker();
            this.lblFechaConsulta = new System.Windows.Forms.Label();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloDiagnostico
            // 
            this.lblTituloDiagnostico.AutoSize = true;
            this.lblTituloDiagnostico.Location = new System.Drawing.Point(86, 63);
            this.lblTituloDiagnostico.Name = "lblTituloDiagnostico";
            this.lblTituloDiagnostico.Size = new System.Drawing.Size(63, 13);
            this.lblTituloDiagnostico.TabIndex = 0;
            this.lblTituloDiagnostico.Text = "Diagnostico";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Location = new System.Drawing.Point(86, 113);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(63, 13);
            this.lblDescripcion.TabIndex = 1;
            this.lblDescripcion.Text = "Descripcion";
            // 
            // tBoxDiagnostico
            // 
            this.tBoxDiagnostico.Location = new System.Drawing.Point(89, 79);
            this.tBoxDiagnostico.Name = "tBoxDiagnostico";
            this.tBoxDiagnostico.Size = new System.Drawing.Size(100, 20);
            this.tBoxDiagnostico.TabIndex = 2;
            // 
            // tBoxDescripcion
            // 
            this.tBoxDescripcion.Location = new System.Drawing.Point(89, 129);
            this.tBoxDescripcion.Multiline = true;
            this.tBoxDescripcion.Name = "tBoxDescripcion";
            this.tBoxDescripcion.Size = new System.Drawing.Size(414, 104);
            this.tBoxDescripcion.TabIndex = 3;
            // 
            // lblTratamiento
            // 
            this.lblTratamiento.AutoSize = true;
            this.lblTratamiento.Location = new System.Drawing.Point(86, 250);
            this.lblTratamiento.Name = "lblTratamiento";
            this.lblTratamiento.Size = new System.Drawing.Size(63, 13);
            this.lblTratamiento.TabIndex = 4;
            this.lblTratamiento.Text = "Tratamiento";
            // 
            // tBoxTratamiento
            // 
            this.tBoxTratamiento.Location = new System.Drawing.Point(89, 266);
            this.tBoxTratamiento.Name = "tBoxTratamiento";
            this.tBoxTratamiento.Size = new System.Drawing.Size(414, 20);
            this.tBoxTratamiento.TabIndex = 5;
            // 
            // dTPFechaConsulta
            // 
            this.dTPFechaConsulta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFechaConsulta.Location = new System.Drawing.Point(404, 76);
            this.dTPFechaConsulta.Name = "dTPFechaConsulta";
            this.dTPFechaConsulta.Size = new System.Drawing.Size(99, 20);
            this.dTPFechaConsulta.TabIndex = 6;
            // 
            // lblFechaConsulta
            // 
            this.lblFechaConsulta.AutoSize = true;
            this.lblFechaConsulta.Location = new System.Drawing.Point(401, 60);
            this.lblFechaConsulta.Name = "lblFechaConsulta";
            this.lblFechaConsulta.Size = new System.Drawing.Size(95, 13);
            this.lblFechaConsulta.TabIndex = 7;
            this.lblFechaConsulta.Text = "Fecha de consulta";
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.Location = new System.Drawing.Point(114, 323);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(75, 37);
            this.btnAgregarConsulta.TabIndex = 8;
            this.btnAgregarConsulta.Text = "Agregar consulta";
            this.btnAgregarConsulta.UseVisualStyleBackColor = true;
            this.btnAgregarConsulta.Click += new System.EventHandler(this.btnAgregarConsulta_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(421, 323);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 37);
            this.btnCancelar.TabIndex = 9;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UC_AgregarConsulta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAgregarConsulta);
            this.Controls.Add(this.lblFechaConsulta);
            this.Controls.Add(this.dTPFechaConsulta);
            this.Controls.Add(this.tBoxTratamiento);
            this.Controls.Add(this.lblTratamiento);
            this.Controls.Add(this.tBoxDescripcion);
            this.Controls.Add(this.tBoxDiagnostico);
            this.Controls.Add(this.lblDescripcion);
            this.Controls.Add(this.lblTituloDiagnostico);
            this.Name = "UC_AgregarConsulta";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloDiagnostico;
        private System.Windows.Forms.Label lblDescripcion;
        private System.Windows.Forms.TextBox tBoxDiagnostico;
        private System.Windows.Forms.TextBox tBoxDescripcion;
        private System.Windows.Forms.Label lblTratamiento;
        private System.Windows.Forms.TextBox tBoxTratamiento;
        private System.Windows.Forms.DateTimePicker dTPFechaConsulta;
        private System.Windows.Forms.Label lblFechaConsulta;
        private System.Windows.Forms.Button btnAgregarConsulta;
        private System.Windows.Forms.Button btnCancelar;
    }
}
