namespace SistemaVentaAkira.View.Proveedor
{
    partial class FrmProveedoresEliminados
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
            System.Windows.Forms.Label lblProveedor;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_contenedor = new System.Windows.Forms.Panel();
            this.dgv_Prov = new System.Windows.Forms.DataGridView();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnActivarProveedor = new System.Windows.Forms.Button();
            lblProveedor = new System.Windows.Forms.Label();
            this.panel_contenedor.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prov)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProveedor
            // 
            lblProveedor.AutoSize = true;
            lblProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblProveedor.Location = new System.Drawing.Point(188, 22);
            lblProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProveedor.Name = "lblProveedor";
            lblProveedor.Size = new System.Drawing.Size(244, 23);
            lblProveedor.TabIndex = 8;
            lblProveedor.Text = "Proveedores eliminados";
            lblProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_contenedor
            // 
            this.panel_contenedor.BackColor = System.Drawing.Color.White;
            this.panel_contenedor.Controls.Add(this.dgv_Prov);
            this.panel_contenedor.Controls.Add(this.IcClose);
            this.panel_contenedor.Controls.Add(this.btnActivarProveedor);
            this.panel_contenedor.Controls.Add(lblProveedor);
            this.panel_contenedor.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_contenedor.Location = new System.Drawing.Point(0, 0);
            this.panel_contenedor.Name = "panel_contenedor";
            this.panel_contenedor.Size = new System.Drawing.Size(648, 426);
            this.panel_contenedor.TabIndex = 1;
            // 
            // dgv_Prov
            // 
            this.dgv_Prov.AllowUserToAddRows = false;
            this.dgv_Prov.AllowUserToDeleteRows = false;
            this.dgv_Prov.AllowUserToResizeColumns = false;
            this.dgv_Prov.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Prov.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Prov.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgv_Prov.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Prov.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_Prov.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Prov.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_Prov.EnableHeadersVisualStyles = false;
            this.dgv_Prov.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.dgv_Prov.Location = new System.Drawing.Point(12, 64);
            this.dgv_Prov.MultiSelect = false;
            this.dgv_Prov.Name = "dgv_Prov";
            this.dgv_Prov.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_Prov.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Prov.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgv_Prov.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgv_Prov.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgv_Prov.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.dgv_Prov.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgv_Prov.RowTemplate.Height = 25;
            this.dgv_Prov.RowTemplate.ReadOnly = true;
            this.dgv_Prov.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_Prov.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Prov.Size = new System.Drawing.Size(609, 298);
            this.dgv_Prov.TabIndex = 19;
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(7, 16);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 16;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // btnActivarProveedor
            // 
            this.btnActivarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnActivarProveedor.FlatAppearance.BorderSize = 0;
            this.btnActivarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnActivarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarProveedor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnActivarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnActivarProveedor.Location = new System.Drawing.Point(251, 375);
            this.btnActivarProveedor.Name = "btnActivarProveedor";
            this.btnActivarProveedor.Size = new System.Drawing.Size(138, 29);
            this.btnActivarProveedor.TabIndex = 10;
            this.btnActivarProveedor.Text = "Activar proveedor";
            this.btnActivarProveedor.UseVisualStyleBackColor = false;
            this.btnActivarProveedor.Click += new System.EventHandler(this.btnActivarProveedor_Click);
            // 
            // FrmProveedoresEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(648, 426);
            this.Controls.Add(this.panel_contenedor);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedoresEliminados";
            this.Text = "FrmProveedoresEliminados";
            this.panel_contenedor.ResumeLayout(false);
            this.panel_contenedor.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Prov)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_contenedor;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.Button btnActivarProveedor;
        private System.Windows.Forms.DataGridView dgv_Prov;
    }
}