namespace SistemaVentaAkira.View.Reporte_Venta
{
    partial class Reporte_ProductosGeneral
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
            System.Windows.Forms.Label lblSeleccionePeriodoAnual;
            this.dtp_periodoHasta = new System.Windows.Forms.DateTimePicker();
            this.dtp_periodoDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.LblHasta = new System.Windows.Forms.Label();
            this.LblDesde = new System.Windows.Forms.Label();
            lblSeleccionePeriodoAnual = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionePeriodoAnual
            // 
            lblSeleccionePeriodoAnual.AutoSize = true;
            lblSeleccionePeriodoAnual.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblSeleccionePeriodoAnual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblSeleccionePeriodoAnual.Location = new System.Drawing.Point(162, 37);
            lblSeleccionePeriodoAnual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeleccionePeriodoAnual.Name = "lblSeleccionePeriodoAnual";
            lblSeleccionePeriodoAnual.Size = new System.Drawing.Size(226, 23);
            lblSeleccionePeriodoAnual.TabIndex = 48;
            lblSeleccionePeriodoAnual.Text = "Seleccione el período";
            lblSeleccionePeriodoAnual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dtp_periodoHasta
            // 
            this.dtp_periodoHasta.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoHasta.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoHasta.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_periodoHasta.Location = new System.Drawing.Point(370, 137);
            this.dtp_periodoHasta.Name = "dtp_periodoHasta";
            this.dtp_periodoHasta.Size = new System.Drawing.Size(99, 26);
            this.dtp_periodoHasta.TabIndex = 53;
            // 
            // dtp_periodoDesde
            // 
            this.dtp_periodoDesde.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_periodoDesde.Location = new System.Drawing.Point(161, 138);
            this.dtp_periodoDesde.Name = "dtp_periodoDesde";
            this.dtp_periodoDesde.Size = new System.Drawing.Size(99, 26);
            this.dtp_periodoDesde.TabIndex = 51;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(227, 273);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(93, 28);
            this.btnFiltrar.TabIndex = 50;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(12, 37);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 54;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // LblHasta
            // 
            this.LblHasta.AutoSize = true;
            this.LblHasta.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblHasta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblHasta.Location = new System.Drawing.Point(301, 141);
            this.LblHasta.Name = "LblHasta";
            this.LblHasta.Size = new System.Drawing.Size(56, 21);
            this.LblHasta.TabIndex = 56;
            this.LblHasta.Text = "Hasta";
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblDesde.Location = new System.Drawing.Point(75, 142);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(59, 21);
            this.LblDesde.TabIndex = 55;
            this.LblDesde.Text = "Desde";
            // 
            // Reporte_ProductosGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(565, 354);
            this.Controls.Add(this.LblHasta);
            this.Controls.Add(this.LblDesde);
            this.Controls.Add(this.IcClose);
            this.Controls.Add(this.dtp_periodoHasta);
            this.Controls.Add(lblSeleccionePeriodoAnual);
            this.Controls.Add(this.dtp_periodoDesde);
            this.Controls.Add(this.btnFiltrar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_ProductosGeneral";
            this.Text = "Reporte_ProductosGeneral";
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtp_periodoHasta;
        private System.Windows.Forms.DateTimePicker dtp_periodoDesde;
        private System.Windows.Forms.Button btnFiltrar;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.Label LblHasta;
        private System.Windows.Forms.Label LblDesde;
    }
}