namespace SistemaVentaAkira.View.Reporte_Venta
{
    partial class ReporteGeneral
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
            System.Windows.Forms.Label lblReporteVenta;
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title2 = new System.Windows.Forms.DataVisualization.Charting.Title();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title3 = new System.Windows.Forms.DataVisualization.Charting.Title();
            this.dtFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.dtFechaFin = new System.Windows.Forms.DateTimePicker();
            this.btnHoy = new System.Windows.Forms.Button();
            this.btnSietedias = new System.Windows.Forms.Button();
            this.btnTreintadías = new System.Windows.Forms.Button();
            this.panelTotal = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.Ganancia = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.Venta_categoria = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.venta_proveedor = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            lblReporteVenta = new System.Windows.Forms.Label();
            this.panelTotal.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ganancia)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venta_categoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_proveedor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblReporteVenta
            // 
            lblReporteVenta.AutoSize = true;
            lblReporteVenta.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblReporteVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblReporteVenta.Location = new System.Drawing.Point(81, 9);
            lblReporteVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblReporteVenta.Name = "lblReporteVenta";
            lblReporteVenta.Size = new System.Drawing.Size(188, 23);
            lblReporteVenta.TabIndex = 2;
            lblReporteVenta.Text = "Reporte de ventas";
            lblReporteVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtFechaInicio
            // 
            this.dtFechaInicio.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dtFechaInicio.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaInicio.Location = new System.Drawing.Point(17, 50);
            this.dtFechaInicio.Name = "dtFechaInicio";
            this.dtFechaInicio.Size = new System.Drawing.Size(117, 25);
            this.dtFechaInicio.TabIndex = 3;
            // 
            // dtFechaFin
            // 
            this.dtFechaFin.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.dtFechaFin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtFechaFin.Location = new System.Drawing.Point(152, 50);
            this.dtFechaFin.Name = "dtFechaFin";
            this.dtFechaFin.Size = new System.Drawing.Size(117, 25);
            this.dtFechaFin.TabIndex = 5;
            // 
            // btnHoy
            // 
            this.btnHoy.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnHoy.FlatAppearance.BorderSize = 0;
            this.btnHoy.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnHoy.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoy.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnHoy.ForeColor = System.Drawing.Color.White;
            this.btnHoy.Location = new System.Drawing.Point(289, 48);
            this.btnHoy.Name = "btnHoy";
            this.btnHoy.Size = new System.Drawing.Size(66, 28);
            this.btnHoy.TabIndex = 31;
            this.btnHoy.Text = "Hoy";
            this.btnHoy.UseVisualStyleBackColor = false;
            // 
            // btnSietedias
            // 
            this.btnSietedias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnSietedias.FlatAppearance.BorderSize = 0;
            this.btnSietedias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnSietedias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSietedias.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnSietedias.ForeColor = System.Drawing.Color.White;
            this.btnSietedias.Location = new System.Drawing.Point(381, 48);
            this.btnSietedias.Name = "btnSietedias";
            this.btnSietedias.Size = new System.Drawing.Size(110, 28);
            this.btnSietedias.TabIndex = 32;
            this.btnSietedias.Text = "Último 7 días";
            this.btnSietedias.UseVisualStyleBackColor = false;
            // 
            // btnTreintadías
            // 
            this.btnTreintadías.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnTreintadías.FlatAppearance.BorderSize = 0;
            this.btnTreintadías.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnTreintadías.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTreintadías.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnTreintadías.ForeColor = System.Drawing.Color.White;
            this.btnTreintadías.Location = new System.Drawing.Point(507, 48);
            this.btnTreintadías.Name = "btnTreintadías";
            this.btnTreintadías.Size = new System.Drawing.Size(110, 28);
            this.btnTreintadías.TabIndex = 34;
            this.btnTreintadías.Text = "Último 30 días";
            this.btnTreintadías.UseVisualStyleBackColor = false;
            // 
            // panelTotal
            // 
            this.panelTotal.BackColor = System.Drawing.Color.White;
            this.panelTotal.Controls.Add(this.label4);
            this.panelTotal.Controls.Add(this.label1);
            this.panelTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTotal.Location = new System.Drawing.Point(17, 94);
            this.panelTotal.Name = "panelTotal";
            this.panelTotal.Size = new System.Drawing.Size(117, 57);
            this.panelTotal.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label4.Location = new System.Drawing.Point(37, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "1000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label1.Location = new System.Drawing.Point(12, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Total Venta";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(303, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(164, 57);
            this.panel1.TabIndex = 36;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.label2.Location = new System.Drawing.Point(55, 26);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "1000";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.label3.Location = new System.Drawing.Point(3, 6);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(155, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Productos vendidos";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Location = new System.Drawing.Point(152, 94);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(136, 57);
            this.panel2.TabIndex = 36;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.label5.Location = new System.Drawing.Point(37, 26);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 20);
            this.label5.TabIndex = 1;
            this.label5.Text = "1000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.label6.Location = new System.Drawing.Point(19, 6);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Ganancia";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.White;
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Location = new System.Drawing.Point(481, 94);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(136, 57);
            this.panel3.TabIndex = 37;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.label7.Location = new System.Drawing.Point(40, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(41, 20);
            this.label7.TabIndex = 1;
            this.label7.Text = "1000";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 11F);
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.label8.Location = new System.Drawing.Point(19, 6);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(88, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Valor Neto";
            // 
            // Ganancia
            // 
            chartArea1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            chartArea1.Name = "Ventas_totales";
            this.Ganancia.ChartAreas.Add(chartArea1);
            legend1.Name = "Ventas Totales";
            legend1.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ganancia.Legends.Add(legend1);
            this.Ganancia.Location = new System.Drawing.Point(17, 170);
            this.Ganancia.Name = "Ganancia";
            this.Ganancia.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.SeaGreen;
            series1.ChartArea = "Ventas_totales";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.StackedColumn;
            series1.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Ventas Totales";
            series1.Name = "Ventas por Producto";
            this.Ganancia.Series.Add(series1);
            this.Ganancia.Size = new System.Drawing.Size(600, 164);
            this.Ganancia.TabIndex = 38;
            this.Ganancia.Text = "Ganancia";
            title1.Font = new System.Drawing.Font("Century Gothic", 11F);
            title1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            title1.Name = "Ventas_tot";
            title1.Text = "Cantidad de ventas por producto";
            this.Ganancia.Titles.Add(title1);
            // 
            // Venta_categoria
            // 
            chartArea2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            chartArea2.Name = "Ventas_totales";
            this.Venta_categoria.ChartAreas.Add(chartArea2);
            legend2.Name = "Ventas_cat";
            legend2.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Venta_categoria.Legends.Add(legend2);
            this.Venta_categoria.Location = new System.Drawing.Point(17, 344);
            this.Venta_categoria.Name = "Venta_categoria";
            this.Venta_categoria.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series2.ChartArea = "Ventas_totales";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Doughnut;
            series2.Legend = "Ventas_cat";
            series2.Name = "S_Categoria";
            this.Venta_categoria.Series.Add(series2);
            this.Venta_categoria.Size = new System.Drawing.Size(276, 164);
            this.Venta_categoria.TabIndex = 39;
            this.Venta_categoria.Text = "Ventas por categoría";
            title2.Font = new System.Drawing.Font("Century Gothic", 11F);
            title2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            title2.Name = "Venta por categoría";
            title2.Text = "Ventas por catgoría";
            this.Venta_categoria.Titles.Add(title2);
            // 
            // venta_proveedor
            // 
            chartArea3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            chartArea3.Name = "Ventas_totales";
            this.venta_proveedor.ChartAreas.Add(chartArea3);
            legend3.Name = "ventas_proveedro";
            legend3.TitleFont = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.venta_proveedor.Legends.Add(legend3);
            this.venta_proveedor.Location = new System.Drawing.Point(322, 344);
            this.venta_proveedor.Name = "venta_proveedor";
            series3.ChartArea = "Ventas_totales";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
            series3.Legend = "ventas_proveedro";
            series3.Name = "venta_proveedor";
            this.venta_proveedor.Series.Add(series3);
            this.venta_proveedor.Size = new System.Drawing.Size(295, 164);
            this.venta_proveedor.TabIndex = 40;
            this.venta_proveedor.Text = "Venta por proveedor";
            title3.Font = new System.Drawing.Font("Century Gothic", 11F);
            title3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            title3.Name = "Venta_proveedor";
            title3.Text = "Ventas por proveedor";
            this.venta_proveedor.Titles.Add(title3);
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(17, 10);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 41;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // ReporteGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(634, 520);
            this.Controls.Add(this.IcClose);
            this.Controls.Add(this.venta_proveedor);
            this.Controls.Add(this.Venta_categoria);
            this.Controls.Add(this.Ganancia);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelTotal);
            this.Controls.Add(this.btnTreintadías);
            this.Controls.Add(this.btnSietedias);
            this.Controls.Add(this.btnHoy);
            this.Controls.Add(this.dtFechaFin);
            this.Controls.Add(this.dtFechaInicio);
            this.Controls.Add(lblReporteVenta);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReporteGeneral";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "s";
            this.Load += new System.EventHandler(this.ReporteGeneral_Load);
            this.panelTotal.ResumeLayout(false);
            this.panelTotal.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Ganancia)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Venta_categoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.venta_proveedor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFechaInicio;
        private System.Windows.Forms.DateTimePicker dtFechaFin;
        private System.Windows.Forms.Button btnHoy;
        private System.Windows.Forms.Button btnSietedias;
        private System.Windows.Forms.Button btnTreintadías;
        private System.Windows.Forms.Panel panelTotal;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataVisualization.Charting.Chart Ganancia;
        private System.Windows.Forms.DataVisualization.Charting.Chart Venta_categoria;
        private System.Windows.Forms.DataVisualization.Charting.Chart venta_proveedor;
        private FontAwesome.Sharp.IconPictureBox IcClose;
    }
}