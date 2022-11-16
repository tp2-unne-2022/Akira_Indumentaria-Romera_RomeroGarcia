using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class FrmProductosEliminados
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
            System.Windows.Forms.Label lblProductoEliminados;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnActivarProducto = new System.Windows.Forms.Button();
            this.dgvProductosEliminados = new System.Windows.Forms.DataGridView();
            lblProductoEliminados = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblProductoEliminados
            // 
            lblProductoEliminados.AutoSize = true;
            lblProductoEliminados.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblProductoEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblProductoEliminados.Location = new System.Drawing.Point(229, 24);
            lblProductoEliminados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblProductoEliminados.Name = "lblProductoEliminados";
            lblProductoEliminados.Size = new System.Drawing.Size(219, 23);
            lblProductoEliminados.TabIndex = 9;
            lblProductoEliminados.Text = "Productos eliminados";
            lblProductoEliminados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dgvProductosEliminados);
            this.panel1.Controls.Add(this.IcClose);
            this.panel1.Controls.Add(this.btnActivarProducto);
            this.panel1.Controls.Add(lblProductoEliminados);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(662, 459);
            this.panel1.TabIndex = 0;
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(14, 24);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 19;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // btnActivarProducto
            // 
            this.btnActivarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnActivarProducto.FlatAppearance.BorderSize = 0;
            this.btnActivarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnActivarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarProducto.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnActivarProducto.ForeColor = System.Drawing.Color.White;
            this.btnActivarProducto.Location = new System.Drawing.Point(259, 400);
            this.btnActivarProducto.Name = "btnActivarProducto";
            this.btnActivarProducto.Size = new System.Drawing.Size(126, 29);
            this.btnActivarProducto.TabIndex = 17;
            this.btnActivarProducto.Text = "Activar producto";
            this.btnActivarProducto.UseVisualStyleBackColor = false;
            this.btnActivarProducto.Click += new System.EventHandler(this.btnActivarProducto_Click);
            // 
            // dgvProductosEliminados
            // 
            this.dgvProductosEliminados.AllowUserToAddRows = false;
            this.dgvProductosEliminados.AllowUserToDeleteRows = false;
            this.dgvProductosEliminados.AllowUserToResizeColumns = false;
            this.dgvProductosEliminados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductosEliminados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductosEliminados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgvProductosEliminados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvProductosEliminados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosEliminados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductosEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosEliminados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductosEliminados.EnableHeadersVisualStyles = false;
            this.dgvProductosEliminados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.dgvProductosEliminados.Location = new System.Drawing.Point(15, 64);
            this.dgvProductosEliminados.MultiSelect = false;
            this.dgvProductosEliminados.Name = "dgvProductosEliminados";
            this.dgvProductosEliminados.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductosEliminados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductosEliminados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvProductosEliminados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvProductosEliminados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvProductosEliminados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.dgvProductosEliminados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvProductosEliminados.RowTemplate.Height = 25;
            this.dgvProductosEliminados.RowTemplate.ReadOnly = true;
            this.dgvProductosEliminados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvProductosEliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductosEliminados.Size = new System.Drawing.Size(635, 315);
            this.dgvProductosEliminados.TabIndex = 20;
            // 
            // FrmProductosEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(662, 459);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProductosEliminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos eliminados";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductosEliminados)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnActivarProducto;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private DataGridView dgvProductosEliminados;
    }
}