namespace LoginPetShop_v1.Veterinario
{
    partial class UC_EditarHistorialMedico
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
            this.dataGridViewVacunas = new System.Windows.Forms.DataGridView();
            this.Vacuna = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FechaAplicacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewConsultas = new System.Windows.Forms.DataGridView();
            this.Diagnostico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tratamiento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblVacunas = new System.Windows.Forms.Label();
            this.lblConsultas = new System.Windows.Forms.Label();
            this.btnVolver = new System.Windows.Forms.Button();
            this.btnProgramarVacuna = new System.Windows.Forms.Button();
            this.btnAgregarConsulta = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunas)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewVacunas
            // 
            this.dataGridViewVacunas.AllowUserToAddRows = false;
            this.dataGridViewVacunas.AllowUserToDeleteRows = false;
            this.dataGridViewVacunas.AllowUserToResizeColumns = false;
            this.dataGridViewVacunas.AllowUserToResizeRows = false;
            this.dataGridViewVacunas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewVacunas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Vacuna,
            this.FechaAplicacion,
            this.Estado});
            this.dataGridViewVacunas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dataGridViewVacunas.Location = new System.Drawing.Point(27, 81);
            this.dataGridViewVacunas.Name = "dataGridViewVacunas";
            this.dataGridViewVacunas.ReadOnly = true;
            this.dataGridViewVacunas.RowHeadersVisible = false;
            this.dataGridViewVacunas.Size = new System.Drawing.Size(241, 243);
            this.dataGridViewVacunas.TabIndex = 0;
            this.dataGridViewVacunas.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewVacunas_CellContentClick);
            // 
            // Vacuna
            // 
            this.Vacuna.Frozen = true;
            this.Vacuna.HeaderText = "Vacuna";
            this.Vacuna.Name = "Vacuna";
            this.Vacuna.ReadOnly = true;
            this.Vacuna.Width = 70;
            // 
            // FechaAplicacion
            // 
            this.FechaAplicacion.FillWeight = 70F;
            this.FechaAplicacion.Frozen = true;
            this.FechaAplicacion.HeaderText = "Fecha";
            this.FechaAplicacion.Name = "FechaAplicacion";
            this.FechaAplicacion.ReadOnly = true;
            this.FechaAplicacion.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.FechaAplicacion.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            // 
            // Estado
            // 
            this.Estado.Frozen = true;
            this.Estado.HeaderText = "Estado";
            this.Estado.Name = "Estado";
            this.Estado.ReadOnly = true;
            this.Estado.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Estado.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.Estado.Width = 70;
            // 
            // dataGridViewConsultas
            // 
            this.dataGridViewConsultas.AllowUserToAddRows = false;
            this.dataGridViewConsultas.AllowUserToDeleteRows = false;
            this.dataGridViewConsultas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewConsultas.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Diagnostico,
            this.Tratamiento,
            this.Fecha});
            this.dataGridViewConsultas.Location = new System.Drawing.Point(301, 81);
            this.dataGridViewConsultas.Name = "dataGridViewConsultas";
            this.dataGridViewConsultas.ReadOnly = true;
            this.dataGridViewConsultas.RowHeadersVisible = false;
            this.dataGridViewConsultas.Size = new System.Drawing.Size(273, 221);
            this.dataGridViewConsultas.TabIndex = 1;
            // 
            // Diagnostico
            // 
            this.Diagnostico.HeaderText = "Diagnostico";
            this.Diagnostico.Name = "Diagnostico";
            this.Diagnostico.ReadOnly = true;
            // 
            // Tratamiento
            // 
            this.Tratamiento.HeaderText = "Tratamiento";
            this.Tratamiento.Name = "Tratamiento";
            this.Tratamiento.ReadOnly = true;
            // 
            // Fecha
            // 
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.ReadOnly = true;
            this.Fecha.Width = 70;
            // 
            // lblVacunas
            // 
            this.lblVacunas.AutoSize = true;
            this.lblVacunas.Location = new System.Drawing.Point(24, 65);
            this.lblVacunas.Name = "lblVacunas";
            this.lblVacunas.Size = new System.Drawing.Size(49, 13);
            this.lblVacunas.TabIndex = 2;
            this.lblVacunas.Text = "Vacunas";
            // 
            // lblConsultas
            // 
            this.lblConsultas.AutoSize = true;
            this.lblConsultas.Location = new System.Drawing.Point(298, 65);
            this.lblConsultas.Name = "lblConsultas";
            this.lblConsultas.Size = new System.Drawing.Size(53, 13);
            this.lblConsultas.TabIndex = 3;
            this.lblConsultas.Text = "Consultas";
            // 
            // btnVolver
            // 
            this.btnVolver.Location = new System.Drawing.Point(27, 22);
            this.btnVolver.Name = "btnVolver";
            this.btnVolver.Size = new System.Drawing.Size(75, 23);
            this.btnVolver.TabIndex = 4;
            this.btnVolver.Text = "Volver";
            this.btnVolver.UseVisualStyleBackColor = true;
            this.btnVolver.Click += new System.EventHandler(this.btnVolver_Click);
            // 
            // btnProgramarVacuna
            // 
            this.btnProgramarVacuna.Location = new System.Drawing.Point(108, 333);
            this.btnProgramarVacuna.Name = "btnProgramarVacuna";
            this.btnProgramarVacuna.Size = new System.Drawing.Size(75, 36);
            this.btnProgramarVacuna.TabIndex = 5;
            this.btnProgramarVacuna.Text = "Programar vacuna";
            this.btnProgramarVacuna.UseVisualStyleBackColor = true;
            this.btnProgramarVacuna.Click += new System.EventHandler(this.btnProgramarVacuna_Click);
            // 
            // btnAgregarConsulta
            // 
            this.btnAgregarConsulta.Location = new System.Drawing.Point(397, 330);
            this.btnAgregarConsulta.Name = "btnAgregarConsulta";
            this.btnAgregarConsulta.Size = new System.Drawing.Size(75, 39);
            this.btnAgregarConsulta.TabIndex = 6;
            this.btnAgregarConsulta.Text = "Agregar consulta";
            this.btnAgregarConsulta.UseVisualStyleBackColor = true;
            this.btnAgregarConsulta.Click += new System.EventHandler(this.btnAgregarConsulta_Click);
            // 
            // UC_EditarHistorialMedico
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnAgregarConsulta);
            this.Controls.Add(this.btnProgramarVacuna);
            this.Controls.Add(this.btnVolver);
            this.Controls.Add(this.lblConsultas);
            this.Controls.Add(this.lblVacunas);
            this.Controls.Add(this.dataGridViewConsultas);
            this.Controls.Add(this.dataGridViewVacunas);
            this.Name = "UC_EditarHistorialMedico";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewVacunas)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewConsultas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewVacunas;
        private System.Windows.Forms.DataGridView dataGridViewConsultas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Diagnostico;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tratamiento;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.Label lblVacunas;
        private System.Windows.Forms.Label lblConsultas;
        private System.Windows.Forms.Button btnVolver;
        private System.Windows.Forms.Button btnProgramarVacuna;
        private System.Windows.Forms.Button btnAgregarConsulta;
        private System.Windows.Forms.DataGridViewTextBoxColumn Vacuna;
        private System.Windows.Forms.DataGridViewTextBoxColumn FechaAplicacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estado;
    }
}
