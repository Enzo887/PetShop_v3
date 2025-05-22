namespace LoginPetShop_v1.Administracion
{
    partial class UC_VerEstadisticas
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.lblVistaGeneralEstadisticas = new System.Windows.Forms.Label();
            this.comboxVerEstadisticas = new System.Windows.Forms.ComboBox();
            this.panelProductosMasVendidos = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.graficoVentasGenerales = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panelClientesFrecuentes = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblClientesFrecuentesGeneral = new System.Windows.Forms.Label();
            this.panelProductosMasVendidos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVentasGenerales)).BeginInit();
            this.panelClientesFrecuentes.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblVistaGeneralEstadisticas
            // 
            this.lblVistaGeneralEstadisticas.AutoSize = true;
            this.lblVistaGeneralEstadisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVistaGeneralEstadisticas.Location = new System.Drawing.Point(29, 32);
            this.lblVistaGeneralEstadisticas.Name = "lblVistaGeneralEstadisticas";
            this.lblVistaGeneralEstadisticas.Size = new System.Drawing.Size(92, 17);
            this.lblVistaGeneralEstadisticas.TabIndex = 0;
            this.lblVistaGeneralEstadisticas.Text = "Vista general";
            // 
            // comboxVerEstadisticas
            // 
            this.comboxVerEstadisticas.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboxVerEstadisticas.FormattingEnabled = true;
            this.comboxVerEstadisticas.Items.AddRange(new object[] {
            "Productos mas vendidos",
            "Ventas generales",
            "Clientes frecuentes",
            "Stock "});
            this.comboxVerEstadisticas.Location = new System.Drawing.Point(460, 32);
            this.comboxVerEstadisticas.Name = "comboxVerEstadisticas";
            this.comboxVerEstadisticas.Size = new System.Drawing.Size(121, 25);
            this.comboxVerEstadisticas.TabIndex = 4;
            // 
            // panelProductosMasVendidos
            // 
            this.panelProductosMasVendidos.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelProductosMasVendidos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelProductosMasVendidos.Controls.Add(this.dataGridView2);
            this.panelProductosMasVendidos.Controls.Add(this.label1);
            this.panelProductosMasVendidos.Location = new System.Drawing.Point(318, 85);
            this.panelProductosMasVendidos.Name = "panelProductosMasVendidos";
            this.panelProductosMasVendidos.Size = new System.Drawing.Size(282, 124);
            this.panelProductosMasVendidos.TabIndex = 5;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(4, 14);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(273, 105);
            this.dataGridView2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, -1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(140, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Productos mas vendidos";
            // 
            // graficoVentasGenerales
            // 
            chartArea1.Name = "ChartArea1";
            this.graficoVentasGenerales.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.graficoVentasGenerales.Legends.Add(legend1);
            this.graficoVentasGenerales.Location = new System.Drawing.Point(3, 85);
            this.graficoVentasGenerales.Name = "graficoVentasGenerales";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.graficoVentasGenerales.Series.Add(series1);
            this.graficoVentasGenerales.Size = new System.Drawing.Size(300, 124);
            this.graficoVentasGenerales.TabIndex = 6;
            this.graficoVentasGenerales.Text = "Ventas la ultima semana";
            // 
            // panelClientesFrecuentes
            // 
            this.panelClientesFrecuentes.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.panelClientesFrecuentes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelClientesFrecuentes.Controls.Add(this.dataGridView1);
            this.panelClientesFrecuentes.Controls.Add(this.lblClientesFrecuentesGeneral);
            this.panelClientesFrecuentes.Location = new System.Drawing.Point(3, 228);
            this.panelClientesFrecuentes.Name = "panelClientesFrecuentes";
            this.panelClientesFrecuentes.Size = new System.Drawing.Size(300, 183);
            this.panelClientesFrecuentes.TabIndex = 7;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(4, 27);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(291, 150);
            this.dataGridView1.TabIndex = 1;
            // 
            // lblClientesFrecuentesGeneral
            // 
            this.lblClientesFrecuentesGeneral.AutoSize = true;
            this.lblClientesFrecuentesGeneral.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientesFrecuentesGeneral.Location = new System.Drawing.Point(88, 0);
            this.lblClientesFrecuentesGeneral.Name = "lblClientesFrecuentesGeneral";
            this.lblClientesFrecuentesGeneral.Size = new System.Drawing.Size(129, 17);
            this.lblClientesFrecuentesGeneral.TabIndex = 0;
            this.lblClientesFrecuentesGeneral.Text = "Clientes frecuentes";
            // 
            // UC_VerEstadisticas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.Controls.Add(this.panelClientesFrecuentes);
            this.Controls.Add(this.graficoVentasGenerales);
            this.Controls.Add(this.panelProductosMasVendidos);
            this.Controls.Add(this.comboxVerEstadisticas);
            this.Controls.Add(this.lblVistaGeneralEstadisticas);
            this.Name = "UC_VerEstadisticas";
            this.Size = new System.Drawing.Size(600, 450);
            this.panelProductosMasVendidos.ResumeLayout(false);
            this.panelProductosMasVendidos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.graficoVentasGenerales)).EndInit();
            this.panelClientesFrecuentes.ResumeLayout(false);
            this.panelClientesFrecuentes.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblVistaGeneralEstadisticas;
        private System.Windows.Forms.ComboBox comboxVerEstadisticas;
        private System.Windows.Forms.Panel panelProductosMasVendidos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataVisualization.Charting.Chart graficoVentasGenerales;
        private System.Windows.Forms.Panel panelClientesFrecuentes;
        private System.Windows.Forms.Label lblClientesFrecuentesGeneral;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
    }
}
