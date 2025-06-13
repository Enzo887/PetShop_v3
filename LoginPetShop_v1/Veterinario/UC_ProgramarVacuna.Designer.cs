namespace LoginPetShop_v1.Veterinario
{
    partial class UC_ProgramarVacuna
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
            this.lblVacuna = new System.Windows.Forms.Label();
            this.dTPFechaAplicacion = new System.Windows.Forms.DateTimePicker();
            this.lblFechaAplicacion = new System.Windows.Forms.Label();
            this.tBoxNombreVacuna = new System.Windows.Forms.TextBox();
            this.lblEstado = new System.Windows.Forms.Label();
            this.cBoxEstadoAplicacion = new System.Windows.Forms.ComboBox();
            this.btnProgramar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblVacuna
            // 
            this.lblVacuna.AutoSize = true;
            this.lblVacuna.Location = new System.Drawing.Point(243, 89);
            this.lblVacuna.Name = "lblVacuna";
            this.lblVacuna.Size = new System.Drawing.Size(98, 13);
            this.lblVacuna.TabIndex = 0;
            this.lblVacuna.Text = "Nombre de vacuna";
            // 
            // dTPFechaAplicacion
            // 
            this.dTPFechaAplicacion.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dTPFechaAplicacion.Location = new System.Drawing.Point(246, 175);
            this.dTPFechaAplicacion.Name = "dTPFechaAplicacion";
            this.dTPFechaAplicacion.Size = new System.Drawing.Size(100, 20);
            this.dTPFechaAplicacion.TabIndex = 1;
            this.dTPFechaAplicacion.ValueChanged += new System.EventHandler(this.dTPFechaAplicacion_ValueChanged);
            // 
            // lblFechaAplicacion
            // 
            this.lblFechaAplicacion.AutoSize = true;
            this.lblFechaAplicacion.Location = new System.Drawing.Point(243, 149);
            this.lblFechaAplicacion.Name = "lblFechaAplicacion";
            this.lblFechaAplicacion.Size = new System.Drawing.Size(103, 13);
            this.lblFechaAplicacion.TabIndex = 2;
            this.lblFechaAplicacion.Text = "Fecha de aplicacion";
            // 
            // tBoxNombreVacuna
            // 
            this.tBoxNombreVacuna.Location = new System.Drawing.Point(246, 105);
            this.tBoxNombreVacuna.Name = "tBoxNombreVacuna";
            this.tBoxNombreVacuna.Size = new System.Drawing.Size(100, 20);
            this.tBoxNombreVacuna.TabIndex = 3;
            // 
            // lblEstado
            // 
            this.lblEstado.AutoSize = true;
            this.lblEstado.Location = new System.Drawing.Point(243, 226);
            this.lblEstado.Name = "lblEstado";
            this.lblEstado.Size = new System.Drawing.Size(106, 13);
            this.lblEstado.TabIndex = 4;
            this.lblEstado.Text = "Estado de aplicacion";
            // 
            // cBoxEstadoAplicacion
            // 
            this.cBoxEstadoAplicacion.FormattingEnabled = true;
            this.cBoxEstadoAplicacion.Items.AddRange(new object[] {
            "Aplicada",
            "Sin aplicar"});
            this.cBoxEstadoAplicacion.Location = new System.Drawing.Point(246, 242);
            this.cBoxEstadoAplicacion.Name = "cBoxEstadoAplicacion";
            this.cBoxEstadoAplicacion.Size = new System.Drawing.Size(103, 21);
            this.cBoxEstadoAplicacion.TabIndex = 5;
            // 
            // btnProgramar
            // 
            this.btnProgramar.Location = new System.Drawing.Point(246, 299);
            this.btnProgramar.Name = "btnProgramar";
            this.btnProgramar.Size = new System.Drawing.Size(100, 35);
            this.btnProgramar.TabIndex = 6;
            this.btnProgramar.Text = "Programar vacuna";
            this.btnProgramar.UseVisualStyleBackColor = true;
            this.btnProgramar.Click += new System.EventHandler(this.btnProgramar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(246, 365);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(100, 23);
            this.btnCancelar.TabIndex = 7;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // UC_ProgramarVacuna
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnProgramar);
            this.Controls.Add(this.cBoxEstadoAplicacion);
            this.Controls.Add(this.lblEstado);
            this.Controls.Add(this.tBoxNombreVacuna);
            this.Controls.Add(this.lblFechaAplicacion);
            this.Controls.Add(this.dTPFechaAplicacion);
            this.Controls.Add(this.lblVacuna);
            this.Name = "UC_ProgramarVacuna";
            this.Size = new System.Drawing.Size(600, 450);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVacuna;
        private System.Windows.Forms.DateTimePicker dTPFechaAplicacion;
        private System.Windows.Forms.Label lblFechaAplicacion;
        private System.Windows.Forms.TextBox tBoxNombreVacuna;
        private System.Windows.Forms.Label lblEstado;
        private System.Windows.Forms.ComboBox cBoxEstadoAplicacion;
        private System.Windows.Forms.Button btnProgramar;
        private System.Windows.Forms.Button btnCancelar;
    }
}
