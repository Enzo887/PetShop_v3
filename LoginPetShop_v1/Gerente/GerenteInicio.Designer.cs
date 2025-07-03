namespace LoginPetShop_v1.Gerente
{
    partial class GerenteInicio
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelLateral = new System.Windows.Forms.Panel();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.margenTop = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.btnEditarPerfilGerente = new System.Windows.Forms.Button();
            this.btnCerrarSesionGerente = new System.Windows.Forms.Button();
            this.panelLateral.SuspendLayout();
            this.margenTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLateral.Controls.Add(this.btnCerrarSesionGerente);
            this.panelLateral.Controls.Add(this.btnDescuentos);
            this.panelLateral.Controls.Add(this.margenTop);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 450);
            this.panelLateral.TabIndex = 1;
            // 
            // btnDescuentos
            // 
            this.btnDescuentos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnDescuentos.Location = new System.Drawing.Point(0, 100);
            this.btnDescuentos.Name = "btnDescuentos";
            this.btnDescuentos.Size = new System.Drawing.Size(200, 47);
            this.btnDescuentos.TabIndex = 1;
            this.btnDescuentos.Text = "Descuentos";
            this.btnDescuentos.UseVisualStyleBackColor = true;
            this.btnDescuentos.Click += new System.EventHandler(this.btnDescuentos_Click);
            // 
            // margenTop
            // 
            this.margenTop.Controls.Add(this.btnEditarPerfilGerente);
            this.margenTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.margenTop.Location = new System.Drawing.Point(0, 0);
            this.margenTop.Name = "margenTop";
            this.margenTop.Size = new System.Drawing.Size(200, 100);
            this.margenTop.TabIndex = 0;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedor.Location = new System.Drawing.Point(200, 0);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(600, 450);
            this.panelContenedor.TabIndex = 2;
            // 
            // btnEditarPerfilGerente
            // 
            this.btnEditarPerfilGerente.Location = new System.Drawing.Point(59, 39);
            this.btnEditarPerfilGerente.Name = "btnEditarPerfilGerente";
            this.btnEditarPerfilGerente.Size = new System.Drawing.Size(84, 23);
            this.btnEditarPerfilGerente.TabIndex = 0;
            this.btnEditarPerfilGerente.Text = "Editar perfil";
            this.btnEditarPerfilGerente.UseVisualStyleBackColor = true;
            this.btnEditarPerfilGerente.Click += new System.EventHandler(this.btnEditarPerfilGerente_Click);
            // 
            // btnCerrarSesionGerente
            // 
            this.btnCerrarSesionGerente.Location = new System.Drawing.Point(50, 384);
            this.btnCerrarSesionGerente.Name = "btnCerrarSesionGerente";
            this.btnCerrarSesionGerente.Size = new System.Drawing.Size(93, 23);
            this.btnCerrarSesionGerente.TabIndex = 2;
            this.btnCerrarSesionGerente.Text = "Cerrar sesion";
            this.btnCerrarSesionGerente.UseVisualStyleBackColor = true;
            this.btnCerrarSesionGerente.Click += new System.EventHandler(this.btnCerrarSesionGerente_Click);
            // 
            // GerenteInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelLateral);
            this.Name = "GerenteInicio";
            this.Text = "GerenteInicio";
            this.panelLateral.ResumeLayout(false);
            this.margenTop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Panel margenTop;
        private System.Windows.Forms.Panel panelContenedor;
        private System.Windows.Forms.Button btnCerrarSesionGerente;
        private System.Windows.Forms.Button btnEditarPerfilGerente;
    }
}