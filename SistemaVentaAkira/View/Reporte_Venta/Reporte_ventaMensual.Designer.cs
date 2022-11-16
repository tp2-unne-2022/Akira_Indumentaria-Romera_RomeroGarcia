namespace SistemaVentaAkira.View.Reporte_Venta
{
    partial class Reporte_ventaMensual
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
            System.Windows.Forms.Label lblSeleccionePeriodoMensual;
            this.panel_contenido = new System.Windows.Forms.Panel();
            this.dtp_periodoDesde = new System.Windows.Forms.DateTimePicker();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.LblDesde = new System.Windows.Forms.Label();
            lblSeleccionePeriodoMensual = new System.Windows.Forms.Label();
            this.panel_contenido.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSeleccionePeriodoMensual
            // 
            lblSeleccionePeriodoMensual.AutoSize = true;
            lblSeleccionePeriodoMensual.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblSeleccionePeriodoMensual.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblSeleccionePeriodoMensual.Location = new System.Drawing.Point(156, 27);
            lblSeleccionePeriodoMensual.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblSeleccionePeriodoMensual.Name = "lblSeleccionePeriodoMensual";
            lblSeleccionePeriodoMensual.Size = new System.Drawing.Size(288, 23);
            lblSeleccionePeriodoMensual.TabIndex = 34;
            lblSeleccionePeriodoMensual.Text = "Seleccione Período Mensual";
            lblSeleccionePeriodoMensual.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_contenido
            // 
            this.panel_contenido.Controls.Add(this.LblDesde);
            this.panel_contenido.Controls.Add(this.dtp_periodoDesde);
            this.panel_contenido.Controls.Add(this.btnFiltrar);
            this.panel_contenido.Controls.Add(lblSeleccionePeriodoMensual);
            this.panel_contenido.Controls.Add(this.IcClose);
            this.panel_contenido.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenido.Location = new System.Drawing.Point(0, 0);
            this.panel_contenido.Name = "panel_contenido";
            this.panel_contenido.Size = new System.Drawing.Size(603, 337);
            this.panel_contenido.TabIndex = 0;
            this.panel_contenido.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_contenido_Paint);
            // 
            // dtp_periodoDesde
            // 
            this.dtp_periodoDesde.CalendarFont = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoDesde.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_periodoDesde.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_periodoDesde.Location = new System.Drawing.Point(273, 115);
            this.dtp_periodoDesde.Name = "dtp_periodoDesde";
            this.dtp_periodoDesde.Size = new System.Drawing.Size(99, 26);
            this.dtp_periodoDesde.TabIndex = 40;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnFiltrar.FlatAppearance.BorderSize = 0;
            this.btnFiltrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.ForeColor = System.Drawing.Color.White;
            this.btnFiltrar.Location = new System.Drawing.Point(246, 230);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(93, 28);
            this.btnFiltrar.TabIndex = 39;
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
            this.IcClose.Location = new System.Drawing.Point(24, 28);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 33;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // LblDesde
            // 
            this.LblDesde.AutoSize = true;
            this.LblDesde.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblDesde.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblDesde.Location = new System.Drawing.Point(199, 119);
            this.LblDesde.Name = "LblDesde";
            this.LblDesde.Size = new System.Drawing.Size(59, 21);
            this.LblDesde.TabIndex = 55;
            this.LblDesde.Text = "Desde";
            // 
            // Reporte_ventaMensual
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(603, 337);
            this.Controls.Add(this.panel_contenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Reporte_ventaMensual";
            this.Text = "Seleccion período anual";
            this.panel_contenido.ResumeLayout(false);
            this.panel_contenido.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenido;
        private System.Windows.Forms.Button btnFiltrar;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.DateTimePicker dtp_periodoDesde;
        private System.Windows.Forms.Label LblDesde;
    }
}