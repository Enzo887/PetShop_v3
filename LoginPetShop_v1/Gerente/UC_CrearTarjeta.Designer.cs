namespace LoginPetShop_v1.Gerente
{
    partial class UC_CrearTarjeta
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblDniCliente = new System.Windows.Forms.Label();
            this.btnCrear = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Dni = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IdCliente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TipoDeTarjeta = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CantPuntos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnMejorarTarjeta = new System.Windows.Forms.Button();
            this.btnBuscarXDni = new System.Windows.Forms.Button();
            this.btnDarBaja = new System.Windows.Forms.Button();
            this.btnReactivar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(71, 76);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // lblDniCliente
            // 
            this.lblDniCliente.AutoSize = true;
            this.lblDniCliente.Location = new System.Drawing.Point(68, 60);
            this.lblDniCliente.Name = "lblDniCliente";
            this.lblDniCliente.Size = new System.Drawing.Size(72, 13);
            this.lblDniCliente.TabIndex = 1;
            this.lblDniCliente.Text = "Dni de cliente";
            // 
            // btnCrear
            // 
            this.btnCrear.Location = new System.Drawing.Point(439, 50);
            this.btnCrear.Name = "btnCrear";
            this.btnCrear.Size = new System.Drawing.Size(93, 23);
            this.btnCrear.TabIndex = 2;
            this.btnCrear.Text = "Crear Tarjeta";
            this.btnCrear.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Dni,
            this.IdCliente,
            this.TipoDeTarjeta,
            this.CantPuntos});
            this.dataGridView1.Location = new System.Drawing.Point(71, 229);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(441, 174);
            this.dataGridView1.TabIndex = 3;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // Dni
            // 
            this.Dni.HeaderText = "DniCliente";
            this.Dni.Name = "Dni";
            // 
            // IdCliente
            // 
            this.IdCliente.HeaderText = "IdCliente";
            this.IdCliente.Name = "IdCliente";
            // 
            // TipoDeTarjeta
            // 
            this.TipoDeTarjeta.HeaderText = "TipoDeTarjeta";
            this.TipoDeTarjeta.Name = "TipoDeTarjeta";
            // 
            // CantPuntos
            // 
            this.CantPuntos.HeaderText = "CantPuntos";
            this.CantPuntos.Name = "CantPuntos";
            // 
            // btnMejorarTarjeta
            // 
            this.btnMejorarTarjeta.Location = new System.Drawing.Point(439, 89);
            this.btnMejorarTarjeta.Name = "btnMejorarTarjeta";
            this.btnMejorarTarjeta.Size = new System.Drawing.Size(93, 23);
            this.btnMejorarTarjeta.TabIndex = 4;
            this.btnMejorarTarjeta.Text = "Mejorar tarjeta";
            this.btnMejorarTarjeta.UseVisualStyleBackColor = true;
            // 
            // btnBuscarXDni
            // 
            this.btnBuscarXDni.Location = new System.Drawing.Point(197, 73);
            this.btnBuscarXDni.Name = "btnBuscarXDni";
            this.btnBuscarXDni.Size = new System.Drawing.Size(93, 23);
            this.btnBuscarXDni.TabIndex = 5;
            this.btnBuscarXDni.Text = "Buscar con dni";
            this.btnBuscarXDni.UseVisualStyleBackColor = true;
            // 
            // btnDarBaja
            // 
            this.btnDarBaja.Location = new System.Drawing.Point(439, 171);
            this.btnDarBaja.Name = "btnDarBaja";
            this.btnDarBaja.Size = new System.Drawing.Size(93, 23);
            this.btnDarBaja.TabIndex = 6;
            this.btnDarBaja.Text = "Dar de baja tarjeta";
            this.btnDarBaja.UseVisualStyleBackColor = true;
            // 
            // btnReactivar
            // 
            this.btnReactivar.Location = new System.Drawing.Point(439, 131);
            this.btnReactivar.Name = "btnReactivar";
            this.btnReactivar.Size = new System.Drawing.Size(93, 23);
            this.btnReactivar.TabIndex = 7;
            this.btnReactivar.Text = "Reactivar tarjeta";
            this.btnReactivar.UseVisualStyleBackColor = true;
            // 
            // UC_CrearTarjeta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnReactivar);
            this.Controls.Add(this.btnDarBaja);
            this.Controls.Add(this.btnBuscarXDni);
            this.Controls.Add(this.btnMejorarTarjeta);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnCrear);
            this.Controls.Add(this.lblDniCliente);
            this.Controls.Add(this.textBox1);
            this.Name = "UC_CrearTarjeta";
            this.Size = new System.Drawing.Size(600, 450);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label lblDniCliente;
        private System.Windows.Forms.Button btnCrear;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dni;
        private System.Windows.Forms.DataGridViewTextBoxColumn IdCliente;
        private System.Windows.Forms.DataGridViewTextBoxColumn TipoDeTarjeta;
        private System.Windows.Forms.DataGridViewTextBoxColumn CantPuntos;
        private System.Windows.Forms.Button btnMejorarTarjeta;
        private System.Windows.Forms.Button btnBuscarXDni;
        private System.Windows.Forms.Button btnDarBaja;
        private System.Windows.Forms.Button btnReactivar;
    }
}
