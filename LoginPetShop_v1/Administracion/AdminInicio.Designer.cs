namespace LoginPetShop_v1.Administracion
{
    partial class AdminInicio
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
            this.panelLateralAdmin = new System.Windows.Forms.Panel();
            this.btnVerEstadisticas = new System.Windows.Forms.Button();
            this.btnConfigurarAlertas = new System.Windows.Forms.Button();
            this.btnAdminstrarRoles = new System.Windows.Forms.Button();
            this.panelTopAdmin = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblAdminTitulo = new System.Windows.Forms.Label();
            this.panelContenedorAdmin = new System.Windows.Forms.Panel();
            this.btnGestionarUsuarios = new System.Windows.Forms.Button();
            this.panelLateralAdmin.SuspendLayout();
            this.panelTopAdmin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelLateralAdmin
            // 
            this.panelLateralAdmin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panelLateralAdmin.Controls.Add(this.btnGestionarUsuarios);
            this.panelLateralAdmin.Controls.Add(this.btnVerEstadisticas);
            this.panelLateralAdmin.Controls.Add(this.btnConfigurarAlertas);
            this.panelLateralAdmin.Controls.Add(this.btnAdminstrarRoles);
            this.panelLateralAdmin.Controls.Add(this.panelTopAdmin);
            this.panelLateralAdmin.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateralAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelLateralAdmin.Name = "panelLateralAdmin";
            this.panelLateralAdmin.Size = new System.Drawing.Size(200, 450);
            this.panelLateralAdmin.TabIndex = 0;
            // 
            // btnVerEstadisticas
            // 
            this.btnVerEstadisticas.BackColor = System.Drawing.Color.White;
            this.btnVerEstadisticas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerEstadisticas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnVerEstadisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVerEstadisticas.Location = new System.Drawing.Point(0, 260);
            this.btnVerEstadisticas.Name = "btnVerEstadisticas";
            this.btnVerEstadisticas.Size = new System.Drawing.Size(200, 65);
            this.btnVerEstadisticas.TabIndex = 3;
            this.btnVerEstadisticas.Text = "Ver Estadisticas";
            this.btnVerEstadisticas.UseVisualStyleBackColor = false;
            this.btnVerEstadisticas.Click += new System.EventHandler(this.btnVerEstadisticas_Click);
            // 
            // btnConfigurarAlertas
            // 
            this.btnConfigurarAlertas.BackColor = System.Drawing.Color.White;
            this.btnConfigurarAlertas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigurarAlertas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnConfigurarAlertas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigurarAlertas.Location = new System.Drawing.Point(0, 192);
            this.btnConfigurarAlertas.Name = "btnConfigurarAlertas";
            this.btnConfigurarAlertas.Size = new System.Drawing.Size(200, 68);
            this.btnConfigurarAlertas.TabIndex = 2;
            this.btnConfigurarAlertas.Text = "Configurar Alertas";
            this.btnConfigurarAlertas.UseVisualStyleBackColor = false;
            this.btnConfigurarAlertas.Click += new System.EventHandler(this.btnConfigurarAlertas_Click);
            // 
            // btnAdminstrarRoles
            // 
            this.btnAdminstrarRoles.BackColor = System.Drawing.Color.White;
            this.btnAdminstrarRoles.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAdminstrarRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAdminstrarRoles.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminstrarRoles.Location = new System.Drawing.Point(0, 121);
            this.btnAdminstrarRoles.Name = "btnAdminstrarRoles";
            this.btnAdminstrarRoles.Size = new System.Drawing.Size(200, 71);
            this.btnAdminstrarRoles.TabIndex = 1;
            this.btnAdminstrarRoles.Text = "Administrar Roles";
            this.btnAdminstrarRoles.UseVisualStyleBackColor = false;
            this.btnAdminstrarRoles.Click += new System.EventHandler(this.btnAdminstrarRoles_Click);
            // 
            // panelTopAdmin
            // 
            this.panelTopAdmin.Controls.Add(this.pictureBox1);
            this.panelTopAdmin.Controls.Add(this.lblAdminTitulo);
            this.panelTopAdmin.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTopAdmin.Location = new System.Drawing.Point(0, 0);
            this.panelTopAdmin.Name = "panelTopAdmin";
            this.panelTopAdmin.Size = new System.Drawing.Size(200, 121);
            this.panelTopAdmin.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(3, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(81, 45);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblAdminTitulo
            // 
            this.lblAdminTitulo.AutoSize = true;
            this.lblAdminTitulo.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdminTitulo.Location = new System.Drawing.Point(3, 60);
            this.lblAdminTitulo.Name = "lblAdminTitulo";
            this.lblAdminTitulo.Size = new System.Drawing.Size(118, 19);
            this.lblAdminTitulo.TabIndex = 0;
            this.lblAdminTitulo.Text = "Administrador";
            // 
            // panelContenedorAdmin
            // 
            this.panelContenedorAdmin.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelContenedorAdmin.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContenedorAdmin.Location = new System.Drawing.Point(200, 0);
            this.panelContenedorAdmin.Name = "panelContenedorAdmin";
            this.panelContenedorAdmin.Size = new System.Drawing.Size(600, 450);
            this.panelContenedorAdmin.TabIndex = 1;
            this.panelContenedorAdmin.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContenedorAdmin_Paint);
            // 
            // btnGestionarUsuarios
            // 
            this.btnGestionarUsuarios.BackColor = System.Drawing.Color.White;
            this.btnGestionarUsuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGestionarUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGestionarUsuarios.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestionarUsuarios.Location = new System.Drawing.Point(0, 325);
            this.btnGestionarUsuarios.Name = "btnGestionarUsuarios";
            this.btnGestionarUsuarios.Size = new System.Drawing.Size(200, 65);
            this.btnGestionarUsuarios.TabIndex = 4;
            this.btnGestionarUsuarios.Text = "Administrar usuarios";
            this.btnGestionarUsuarios.UseVisualStyleBackColor = false;
            this.btnGestionarUsuarios.Click += new System.EventHandler(this.btnGestionarUsuarios_Click);
            // 
            // AdminInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panelContenedorAdmin);
            this.Controls.Add(this.panelLateralAdmin);
            this.Name = "AdminInicio";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AdminInicio";
            this.panelLateralAdmin.ResumeLayout(false);
            this.panelTopAdmin.ResumeLayout(false);
            this.panelTopAdmin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateralAdmin;
        private System.Windows.Forms.Panel panelContenedorAdmin;
        private System.Windows.Forms.Button btnVerEstadisticas;
        private System.Windows.Forms.Button btnConfigurarAlertas;
        private System.Windows.Forms.Button btnAdminstrarRoles;
        private System.Windows.Forms.Panel panelTopAdmin;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblAdminTitulo;
        private System.Windows.Forms.Button btnGestionarUsuarios;
    }
}