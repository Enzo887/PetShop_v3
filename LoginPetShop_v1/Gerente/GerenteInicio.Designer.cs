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
            this.btnTarjetaPuntos = new System.Windows.Forms.Button();
            this.btnDescuentos = new System.Windows.Forms.Button();
            this.margenTop = new System.Windows.Forms.Panel();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelLateral.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelLateral
            // 
            this.panelLateral.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panelLateral.Controls.Add(this.btnTarjetaPuntos);
            this.panelLateral.Controls.Add(this.btnDescuentos);
            this.panelLateral.Controls.Add(this.margenTop);
            this.panelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelLateral.Location = new System.Drawing.Point(0, 0);
            this.panelLateral.Name = "panelLateral";
            this.panelLateral.Size = new System.Drawing.Size(200, 450);
            this.panelLateral.TabIndex = 1;
            // 
            // btnTarjetaPuntos
            // 
            this.btnTarjetaPuntos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTarjetaPuntos.Location = new System.Drawing.Point(0, 147);
            this.btnTarjetaPuntos.Name = "btnTarjetaPuntos";
            this.btnTarjetaPuntos.Size = new System.Drawing.Size(200, 47);
            this.btnTarjetaPuntos.TabIndex = 2;
            this.btnTarjetaPuntos.Text = "Tarjeta Puntos";
            this.btnTarjetaPuntos.UseVisualStyleBackColor = true;
            this.btnTarjetaPuntos.Click += new System.EventHandler(this.btnTarjetaPuntos_Click);
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
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelLateral;
        private System.Windows.Forms.Button btnTarjetaPuntos;
        private System.Windows.Forms.Button btnDescuentos;
        private System.Windows.Forms.Panel margenTop;
        private System.Windows.Forms.Panel panelContenedor;
    }
}