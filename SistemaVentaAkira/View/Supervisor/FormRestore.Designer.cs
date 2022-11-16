namespace SistemaVentaAkira.View.Supervisor
{
    partial class FormRestore
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
            this.panel_Restore = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.TxtDirectorio = new System.Windows.Forms.TextBox();
            this.LblDirectorio = new System.Windows.Forms.Label();
            this.ICCargarRestore = new FontAwesome.Sharp.IconButton();
            this.BuscarBackup = new System.Windows.Forms.OpenFileDialog();
            lblRealizarBackUp = new System.Windows.Forms.Label();
            this.panel_Restore.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRealizarBackUp
            // 
            lblRealizarBackUp.AutoSize = true;
            lblRealizarBackUp.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblRealizarBackUp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblRealizarBackUp.Location = new System.Drawing.Point(208, 12);
            lblRealizarBackUp.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRealizarBackUp.Name = "lblRealizarBackUp";
            lblRealizarBackUp.Size = new System.Drawing.Size(164, 23);
            lblRealizarBackUp.TabIndex = 33;
            lblRealizarBackUp.Text = "Realizar Restore";
            lblRealizarBackUp.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_Restore
            // 
            this.panel_Restore.BackColor = System.Drawing.Color.White;
            this.panel_Restore.Controls.Add(this.IcClose);
            this.panel_Restore.Controls.Add(this.btnBuscar);
            this.panel_Restore.Controls.Add(this.TxtDirectorio);
            this.panel_Restore.Controls.Add(this.LblDirectorio);
            this.panel_Restore.Controls.Add(lblRealizarBackUp);
            this.panel_Restore.Controls.Add(this.ICCargarRestore);
            this.panel_Restore.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_Restore.Location = new System.Drawing.Point(0, 0);
            this.panel_Restore.Name = "panel_Restore";
            this.panel_Restore.Size = new System.Drawing.Size(584, 361);
            this.panel_Restore.TabIndex = 0;
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(23, 12);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 39;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(343, 117);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(93, 28);
            this.btnBuscar.TabIndex = 38;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // TxtDirectorio
            // 
            this.TxtDirectorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.TxtDirectorio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDirectorio.Location = new System.Drawing.Point(54, 119);
            this.TxtDirectorio.MaxLength = 100;
            this.TxtDirectorio.Name = "TxtDirectorio";
            this.TxtDirectorio.Size = new System.Drawing.Size(230, 27);
            this.TxtDirectorio.TabIndex = 35;
            // 
            // LblDirectorio
            // 
            this.LblDirectorio.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LblDirectorio.AutoSize = true;
            this.LblDirectorio.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDirectorio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblDirectorio.Location = new System.Drawing.Point(50, 95);
            this.LblDirectorio.Name = "LblDirectorio";
            this.LblDirectorio.Size = new System.Drawing.Size(85, 21);
            this.LblDirectorio.TabIndex = 34;
            this.LblDirectorio.Text = "Directorio";
            // 
            // ICCargarRestore
            // 
            this.ICCargarRestore.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.ICCargarRestore.FlatAppearance.BorderSize = 0;
            this.ICCargarRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICCargarRestore.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICCargarRestore.ForeColor = System.Drawing.Color.White;
            this.ICCargarRestore.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ICCargarRestore.IconColor = System.Drawing.Color.White;
            this.ICCargarRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICCargarRestore.IconSize = 40;
            this.ICCargarRestore.Location = new System.Drawing.Point(227, 214);
            this.ICCargarRestore.Name = "ICCargarRestore";
            this.ICCargarRestore.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICCargarRestore.Size = new System.Drawing.Size(130, 72);
            this.ICCargarRestore.TabIndex = 32;
            this.ICCargarRestore.Text = "Cargar";
            this.ICCargarRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ICCargarRestore.UseVisualStyleBackColor = false;
            this.ICCargarRestore.Click += new System.EventHandler(this.ICCargarRestore_Click);
            // 
            // FormRestore
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 361);
            this.Controls.Add(this.panel_Restore);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormRestore";
            this.Text = "FormRestore";
            this.panel_Restore.ResumeLayout(false);
            this.panel_Restore.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_Restore;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox TxtDirectorio;
        private System.Windows.Forms.Label LblDirectorio;
        private FontAwesome.Sharp.IconButton ICCargarRestore;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.OpenFileDialog BuscarBackup;
    }
}