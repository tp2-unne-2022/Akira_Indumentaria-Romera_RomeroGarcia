namespace SistemaVentaAkira.View
{
    partial class FrmClienteOperacion
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label lblRegistrarCliente;
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.tbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.tbEmailCliente = new System.Windows.Forms.TextBox();
            this.tbDNICliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnRegistrarCliente = new System.Windows.Forms.Button();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.ErrorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNacimientoCliente = new System.Windows.Forms.Label();
            this.dtp_nacimientoCliente = new System.Windows.Forms.DateTimePicker();
            lblRegistrarCliente = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrarCliente
            // 
            lblRegistrarCliente.AutoSize = true;
            lblRegistrarCliente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblRegistrarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblRegistrarCliente.Location = new System.Drawing.Point(131, 52);
            lblRegistrarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRegistrarCliente.Name = "lblRegistrarCliente";
            lblRegistrarCliente.Size = new System.Drawing.Size(166, 23);
            lblRegistrarCliente.TabIndex = 37;
            lblRegistrarCliente.Text = "Registrar cliente";
            lblRegistrarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(430, 26);
            this.panelTitulo.TabIndex = 36;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.White;
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(396, 3);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 16;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // tbTelefonoCliente
            // 
            this.tbTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoCliente.Location = new System.Drawing.Point(135, 302);
            this.tbTelefonoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefonoCliente.Name = "tbTelefonoCliente";
            this.tbTelefonoCliente.Size = new System.Drawing.Size(245, 20);
            this.tbTelefonoCliente.TabIndex = 52;
            this.tbTelefonoCliente.TextChanged += new System.EventHandler(this.tbTelefonoCliente_TextChanged);
            this.tbTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefonoCliente_KeyPress);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(44, 303);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(69, 19);
            this.lblTelefonoCliente.TabIndex = 51;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailCliente.Location = new System.Drawing.Point(133, 263);
            this.tbEmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.Size = new System.Drawing.Size(245, 20);
            this.tbEmailCliente.TabIndex = 47;
            this.tbEmailCliente.TextChanged += new System.EventHandler(this.tbEmailCliente_TextChanged);
            // 
            // tbDNICliente
            // 
            this.tbDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNICliente.Location = new System.Drawing.Point(133, 180);
            this.tbDNICliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbDNICliente.Name = "tbDNICliente";
            this.tbDNICliente.Size = new System.Drawing.Size(245, 20);
            this.tbDNICliente.TabIndex = 46;
            this.tbDNICliente.TextChanged += new System.EventHandler(this.tbDNICliente_TextChanged);
            this.tbDNICliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNICliente_KeyPress);
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoCliente.Location = new System.Drawing.Point(133, 146);
            this.tbApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(245, 20);
            this.tbApellidoCliente.TabIndex = 45;
            this.tbApellidoCliente.TextChanged += new System.EventHandler(this.tbApellidoCliente_TextChanged);
            this.tbApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoCliente_KeyPress);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCliente.Location = new System.Drawing.Point(133, 107);
            this.tbNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(245, 20);
            this.tbNombreCliente.TabIndex = 44;
            this.tbNombreCliente.TextChanged += new System.EventHandler(this.tbNombreCliente_TextChanged);
            this.tbNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreCliente_KeyPress);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEmailCliente.ForeColor = System.Drawing.Color.Black;
            this.lblEmailCliente.Location = new System.Drawing.Point(51, 264);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(54, 19);
            this.lblEmailCliente.TabIndex = 41;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoCliente.Location = new System.Drawing.Point(45, 145);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(66, 19);
            this.lblApellidoCliente.TabIndex = 40;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCliente.Location = new System.Drawing.Point(45, 106);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(68, 19);
            this.lblNombreCliente.TabIndex = 39;
            this.lblNombreCliente.Text = "Nombre: ";
            // 
            // btnRegistrarCliente
            // 
            this.btnRegistrarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnRegistrarCliente.FlatAppearance.BorderSize = 0;
            this.btnRegistrarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnRegistrarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarCliente.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnRegistrarCliente.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarCliente.Location = new System.Drawing.Point(153, 354);
            this.btnRegistrarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarCliente.Name = "btnRegistrarCliente";
            this.btnRegistrarCliente.Size = new System.Drawing.Size(97, 34);
            this.btnRegistrarCliente.TabIndex = 38;
            this.btnRegistrarCliente.Text = "Registrar";
            this.btnRegistrarCliente.UseVisualStyleBackColor = false;
            this.btnRegistrarCliente.Click += new System.EventHandler(this.btnRegistrarCliente_Click);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDNICliente.ForeColor = System.Drawing.Color.Black;
            this.lblDNICliente.Location = new System.Drawing.Point(51, 179);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(49, 19);
            this.lblDNICliente.TabIndex = 53;
            this.lblDNICliente.Text = "D.N.I.:";
            // 
            // ErrorCliente
            // 
            this.ErrorCliente.ContainerControl = this;
            // 
            // lblNacimientoCliente
            // 
            this.lblNacimientoCliente.AutoSize = true;
            this.lblNacimientoCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNacimientoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNacimientoCliente.Location = new System.Drawing.Point(11, 221);
            this.lblNacimientoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacimientoCliente.Name = "lblNacimientoCliente";
            this.lblNacimientoCliente.Size = new System.Drawing.Size(127, 19);
            this.lblNacimientoCliente.TabIndex = 55;
            this.lblNacimientoCliente.Text = "Fecha nacimiento:";
            // 
            // dtp_nacimientoCliente
            // 
            this.dtp_nacimientoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimientoCliente.Location = new System.Drawing.Point(143, 221);
            this.dtp_nacimientoCliente.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoCliente.MinDate = new System.DateTime(1952, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoCliente.Name = "dtp_nacimientoCliente";
            this.dtp_nacimientoCliente.Size = new System.Drawing.Size(97, 20);
            this.dtp_nacimientoCliente.TabIndex = 54;
            this.dtp_nacimientoCliente.Value = new System.DateTime(1994, 6, 8, 0, 0, 0, 0);
            // 
            // FrmClienteOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 418);
            this.Controls.Add(this.lblNacimientoCliente);
            this.Controls.Add(this.dtp_nacimientoCliente);
            this.Controls.Add(this.lblDNICliente);
            this.Controls.Add(this.tbTelefonoCliente);
            this.Controls.Add(this.lblTelefonoCliente);
            this.Controls.Add(this.tbEmailCliente);
            this.Controls.Add(this.tbDNICliente);
            this.Controls.Add(this.tbApellidoCliente);
            this.Controls.Add(this.tbNombreCliente);
            this.Controls.Add(this.lblEmailCliente);
            this.Controls.Add(this.lblApellidoCliente);
            this.Controls.Add(this.lblNombreCliente);
            this.Controls.Add(this.btnRegistrarCliente);
            this.Controls.Add(lblRegistrarCliente);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmClienteOperacion";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar cliente";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.TextBox tbTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox tbEmailCliente;
        private System.Windows.Forms.TextBox tbDNICliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnRegistrarCliente;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.ErrorProvider ErrorCliente;
        private System.Windows.Forms.Label lblNacimientoCliente;
        private System.Windows.Forms.DateTimePicker dtp_nacimientoCliente;
    }
}