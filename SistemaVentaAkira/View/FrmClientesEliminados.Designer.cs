namespace SistemaVentaAkira.View
{
    partial class FrmClientesEliminados
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
            System.Windows.Forms.Label lblClientesEliminados;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnActivarCliente = new System.Windows.Forms.Button();
            this.dgvClientesEliminados = new System.Windows.Forms.DataGridView();
            lblClientesEliminados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblClientesEliminados
            // 
            lblClientesEliminados.AutoSize = true;
            lblClientesEliminados.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblClientesEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblClientesEliminados.Location = new System.Drawing.Point(210, 23);
            lblClientesEliminados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblClientesEliminados.Name = "lblClientesEliminados";
            lblClientesEliminados.Size = new System.Drawing.Size(202, 23);
            lblClientesEliminados.TabIndex = 20;
            lblClientesEliminados.Text = "Clientes eliminados";
            lblClientesEliminados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(12, 12);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 19;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // btnActivarCliente
            // 
            this.btnActivarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnActivarCliente.FlatAppearance.BorderSize = 0;
            this.btnActivarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnActivarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarCliente.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnActivarCliente.ForeColor = System.Drawing.Color.White;
            this.btnActivarCliente.Location = new System.Drawing.Point(261, 374);
            this.btnActivarCliente.Name = "btnActivarCliente";
            this.btnActivarCliente.Size = new System.Drawing.Size(121, 29);
            this.btnActivarCliente.TabIndex = 23;
            this.btnActivarCliente.Text = "Activar cliente";
            this.btnActivarCliente.UseVisualStyleBackColor = false;
            this.btnActivarCliente.Click += new System.EventHandler(this.btnActivarCliente_Click);
            // 
            // dgvClientesEliminados
            // 
            this.dgvClientesEliminados.AllowUserToAddRows = false;
            this.dgvClientesEliminados.AllowUserToDeleteRows = false;
            this.dgvClientesEliminados.AllowUserToResizeColumns = false;
            this.dgvClientesEliminados.AllowUserToResizeRows = false;
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientesEliminados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dgvClientesEliminados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgvClientesEliminados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvClientesEliminados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesEliminados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dgvClientesEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesEliminados.DefaultCellStyle = dataGridViewCellStyle8;
            this.dgvClientesEliminados.EnableHeadersVisualStyles = false;
            this.dgvClientesEliminados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.dgvClientesEliminados.Location = new System.Drawing.Point(19, 49);
            this.dgvClientesEliminados.MultiSelect = false;
            this.dgvClientesEliminados.Name = "dgvClientesEliminados";
            this.dgvClientesEliminados.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvClientesEliminados.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientesEliminados.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvClientesEliminados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvClientesEliminados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvClientesEliminados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.dgvClientesEliminados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvClientesEliminados.RowTemplate.Height = 25;
            this.dgvClientesEliminados.RowTemplate.ReadOnly = true;
            this.dgvClientesEliminados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvClientesEliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvClientesEliminados.Size = new System.Drawing.Size(617, 297);
            this.dgvClientesEliminados.TabIndex = 28;
            // 
            // FrmClientesEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(648, 426);
            this.Controls.Add(this.dgvClientesEliminados);
            this.Controls.Add(this.btnActivarCliente);
            this.Controls.Add(lblClientesEliminados);
            this.Controls.Add(this.IcClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClientesEliminados";
            this.Text = "Clientes eliminados";
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClientesEliminados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.Button btnActivarCliente;
        private System.Windows.Forms.DataGridView dgvClientesEliminados;
    }
}