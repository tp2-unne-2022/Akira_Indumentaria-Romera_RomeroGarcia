namespace SistemaVentaAkira.View.Supervisor
{
    partial class FormBackup
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
            System.Windows.Forms.Label lblRealizarBackUp;
            this.panel_backUp = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.LblNombreRes = new System.Windows.Forms.Label();
            this.TxtDirectorio = new System.Windows.Forms.TextBox();
            this.LblDirectorio = new System.Windows.Forms.Label();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.IcCrarBackup = new FontAwesome.Sharp.IconButton();
            this.fBD_direccion = new System.Windows.Forms.FolderBrowserDialog();
            lblRealizarBackUp = new System.Windows.Forms.Label();
            this.panel_backUp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRealizarBackUp
            // 
            lblRealizarBackUp.AutoSize = true;
            lblRealizarBackUp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblRealizarBackUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblRealizarBackUp.Location = new System.Drawing.Point(227, 12);
            lblRealizarBackUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRealizarBackUp.Name = "lblRealizarBackUp";
            lblRealizarBackUp.Size = new System.Drawing.Size(167, 23);
            lblRealizarBackUp.TabIndex = 16;
            lblRealizarBackUp.Text = "Realizar Backup";
            lblRealizarBackUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_backUp
            // 
            this.panel_backUp.Controls.Add(this.btnBuscar);
            this.panel_backUp.Controls.Add(this.txtNombre);
            this.panel_backUp.Controls.Add(this.LblNombreRes);
            this.panel_backUp.Controls.Add(this.TxtDirectorio);
            this.panel_backUp.Controls.Add(this.LblDirectorio);
            this.panel_backUp.Controls.Add(lblRealizarBackUp);
            this.panel_backUp.Controls.Add(this.IcClose);
            this.panel_backUp.Controls.Add(this.IcCrarBackup);
            this.panel_backUp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_backUp.Location = new System.Drawing.Point(0, 0);
            this.panel_backUp.Name = "panel_backUp";
            this.panel_backUp.Size = new System.Drawing.Size(584, 361);
            this.panel_backUp.TabIndex = 0;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(361, 130);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 28);
            this.btnBuscar.TabIndex = 31;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtNombre
            // 
            this.txtNombre.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNombre.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(52, 195);
            this.txtNombre.MaxLength = 100;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(230, 27);
            this.txtNombre.TabIndex = 20;
            // 
            // LblNombreRes
            // 
            this.LblNombreRes.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblNombreRes.AutoSize = true;
            this.LblNombreRes.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNombreRes.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblNombreRes.Location = new System.Drawing.Point(48, 171);
            this.LblNombreRes.Name = "LblNombreRes";
            this.LblNombreRes.Size = new System.Drawing.Size(136, 21);
            this.LblNombreRes.TabIndex = 19;
            this.LblNombreRes.Text = "Nombre Backup";
            // 
            // TxtDirectorio
            // 
            this.TxtDirectorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDirectorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirectorio.Location = new System.Drawing.Point(52, 131);
            this.TxtDirectorio.MaxLength = 100;
            this.TxtDirectorio.Name = "TxtDirectorio";
            this.TxtDirectorio.Size = new System.Drawing.Size(230, 27);
            this.TxtDirectorio.TabIndex = 18;
            // 
            // LblDirectorio
            // 
            this.LblDirectorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDirectorio.AutoSize = true;
            this.LblDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirectorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblDirectorio.Location = new System.Drawing.Point(48, 107);
            this.LblDirectorio.Name = "LblDirectorio";
            this.LblDirectorio.Size = new System.Drawing.Size(85, 21);
            this.LblDirectorio.TabIndex = 17;
            this.LblDirectorio.Text = "Directorio";
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
            this.IcClose.TabIndex = 15;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // IcCrarBackup
            // 
            this.IcCrarBackup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCrarBackup.FlatAppearance.BorderSize = 0;
            this.IcCrarBackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcCrarBackup.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.IcCrarBackup.ForeColor = System.Drawing.Color.White;
            this.IcCrarBackup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.IcCrarBackup.IconColor = System.Drawing.Color.White;
            this.IcCrarBackup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcCrarBackup.IconSize = 40;
            this.IcCrarBackup.Location = new System.Drawing.Point(243, 286);
            this.IcCrarBackup.Name = "IcCrarBackup";
            this.IcCrarBackup.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.IcCrarBackup.Size = new System.Drawing.Size(130, 72);
            this.IcCrarBackup.TabIndex = 6;
            this.IcCrarBackup.Text = "Crear";
            this.IcCrarBackup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.IcCrarBackup.UseVisualStyleBackColor = false;
            this.IcCrarBackup.Click += new System.EventHandler(this.IcCrarBackup_Click);
            // 
            // FormBackup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel_backUp);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormBackup";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "FormBackup";
            this.panel_backUp.ResumeLayout(false);
            this.panel_backUp.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_backUp;
        private FontAwesome.Sharp.IconButton IcCrarBackup;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label LblNombreRes;
        private System.Windows.Forms.TextBox TxtDirectorio;
        private System.Windows.Forms.Label LblDirectorio;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.FolderBrowserDialog fBD_direccion;
    }
}