namespace SistemaVentaAkira.View
{
    partial class FrmUsuariosEliminados
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
            System.Windows.Forms.Label lblUsuariosEliminados;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnActivarUsuario = new System.Windows.Forms.Button();
            this.dgvUsuariosEliminados = new System.Windows.Forms.DataGridView();
            lblUsuariosEliminados = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosEliminados)).BeginInit();
            this.SuspendLayout();
            // 
            // lblUsuariosEliminados
            // 
            lblUsuariosEliminados.AutoSize = true;
            lblUsuariosEliminados.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblUsuariosEliminados.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblUsuariosEliminados.Location = new System.Drawing.Point(211, 25);
            lblUsuariosEliminados.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblUsuariosEliminados.Name = "lblUsuariosEliminados";
            lblUsuariosEliminados.Size = new System.Drawing.Size(203, 23);
            lblUsuariosEliminados.TabIndex = 19;
            lblUsuariosEliminados.Text = "Usuarios eliminados";
            lblUsuariosEliminados.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.IcClose.TabIndex = 18;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // btnActivarUsuario
            // 
            this.btnActivarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnActivarUsuario.FlatAppearance.BorderSize = 0;
            this.btnActivarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnActivarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnActivarUsuario.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnActivarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnActivarUsuario.Location = new System.Drawing.Point(267, 389);
            this.btnActivarUsuario.Name = "btnActivarUsuario";
            this.btnActivarUsuario.Size = new System.Drawing.Size(126, 29);
            this.btnActivarUsuario.TabIndex = 22;
            this.btnActivarUsuario.Text = "Activar usuario";
            this.btnActivarUsuario.UseVisualStyleBackColor = false;
            this.btnActivarUsuario.Click += new System.EventHandler(this.btnActivarUsuario_Click);
            // 
            // dgvUsuariosEliminados
            // 
            this.dgvUsuariosEliminados.AllowUserToAddRows = false;
            this.dgvUsuariosEliminados.AllowUserToDeleteRows = false;
            this.dgvUsuariosEliminados.AllowUserToResizeColumns = false;
            this.dgvUsuariosEliminados.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuariosEliminados.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvUsuariosEliminados.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgvUsuariosEliminados.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvUsuariosEliminados.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosEliminados.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvUsuariosEliminados.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosEliminados.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvUsuariosEliminados.EnableHeadersVisualStyles = false;
            this.dgvUsuariosEliminados.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.dgvUsuariosEliminados.Location = new System.Drawing.Point(27, 67);
            this.dgvUsuariosEliminados.MultiSelect = false;
            this.dgvUsuariosEliminados.Name = "dgvUsuariosEliminados";
            this.dgvUsuariosEliminados.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvUsuariosEliminados.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuariosEliminados.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.dgvUsuariosEliminados.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvUsuariosEliminados.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvUsuariosEliminados.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.dgvUsuariosEliminados.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvUsuariosEliminados.RowTemplate.Height = 25;
            this.dgvUsuariosEliminados.RowTemplate.ReadOnly = true;
            this.dgvUsuariosEliminados.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvUsuariosEliminados.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvUsuariosEliminados.Size = new System.Drawing.Size(611, 302);
            this.dgvUsuariosEliminados.TabIndex = 29;
            // 
            // FrmUsuariosEliminados
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(670, 447);
            this.Controls.Add(this.dgvUsuariosEliminados);
            this.Controls.Add(this.btnActivarUsuario);
            this.Controls.Add(lblUsuariosEliminados);
            this.Controls.Add(this.IcClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUsuariosEliminados";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios eliminados";
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUsuariosEliminados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.Button btnActivarUsuario;
        private System.Windows.Forms.DataGridView dgvUsuariosEliminados;
    }
}