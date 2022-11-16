namespace SistemaVentaAkira.View
{
    partial class FrmEditarCliente
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
            System.Windows.Forms.Label lblModificarCliente;
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.tbTelefonoCliente = new System.Windows.Forms.TextBox();
            this.lblTelefonoCliente = new System.Windows.Forms.Label();
            this.tbEmailCliente = new System.Windows.Forms.TextBox();
            this.tbDNICliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblEmailCliente = new System.Windows.Forms.Label();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.btnModificarCliente = new System.Windows.Forms.Button();
            this.ErrorCliente = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblNacimientoCliente = new System.Windows.Forms.Label();
            this.dtp_nacimientoCliente = new System.Windows.Forms.DateTimePicker();
            this.tbIDCliente = new System.Windows.Forms.TextBox();
            this.btnCancelarEdicion = new System.Windows.Forms.Button();
            lblModificarCliente = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCliente)).BeginInit();
            this.SuspendLayout();
            // 
            // lblModificarCliente
            // 
            lblModificarCliente.AutoSize = true;
            lblModificarCliente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblModificarCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblModificarCliente.Location = new System.Drawing.Point(147, 50);
            lblModificarCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblModificarCliente.Name = "lblModificarCliente";
            lblModificarCliente.Size = new System.Drawing.Size(136, 23);
            lblModificarCliente.TabIndex = 54;
            lblModificarCliente.Text = "Editar cliente";
            lblModificarCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(430, 26);
            this.panelTitulo.TabIndex = 37;
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
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDNICliente.ForeColor = System.Drawing.Color.Black;
            this.lblDNICliente.Location = new System.Drawing.Point(89, 162);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(49, 19);
            this.lblDNICliente.TabIndex = 67;
            this.lblDNICliente.Text = "D.N.I.:";
            // 
            // tbTelefonoCliente
            // 
            this.tbTelefonoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoCliente.Location = new System.Drawing.Point(151, 279);
            this.tbTelefonoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefonoCliente.Name = "tbTelefonoCliente";
            this.tbTelefonoCliente.Size = new System.Drawing.Size(245, 20);
            this.tbTelefonoCliente.TabIndex = 66;
            this.tbTelefonoCliente.TextChanged += new System.EventHandler(this.tbTelefonoCliente_TextChanged);
            this.tbTelefonoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbTelefonoCliente_KeyPress);
            // 
            // lblTelefonoCliente
            // 
            this.lblTelefonoCliente.AutoSize = true;
            this.lblTelefonoCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefonoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonoCliente.Location = new System.Drawing.Point(69, 278);
            this.lblTelefonoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoCliente.Name = "lblTelefonoCliente";
            this.lblTelefonoCliente.Size = new System.Drawing.Size(69, 19);
            this.lblTelefonoCliente.TabIndex = 65;
            this.lblTelefonoCliente.Text = "Teléfono:";
            // 
            // tbEmailCliente
            // 
            this.tbEmailCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailCliente.Location = new System.Drawing.Point(151, 243);
            this.tbEmailCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailCliente.Name = "tbEmailCliente";
            this.tbEmailCliente.Size = new System.Drawing.Size(245, 20);
            this.tbEmailCliente.TabIndex = 63;
            this.tbEmailCliente.TextChanged += new System.EventHandler(this.tbEmailCliente_TextChanged);
            // 
            // tbDNICliente
            // 
            this.tbDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNICliente.Location = new System.Drawing.Point(151, 163);
            this.tbDNICliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbDNICliente.Name = "tbDNICliente";
            this.tbDNICliente.Size = new System.Drawing.Size(245, 20);
            this.tbDNICliente.TabIndex = 62;
            this.tbDNICliente.TextChanged += new System.EventHandler(this.tbDNICliente_TextChanged);
            this.tbDNICliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbDNICliente_KeyPress);
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoCliente.Location = new System.Drawing.Point(151, 129);
            this.tbApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(245, 20);
            this.tbApellidoCliente.TabIndex = 61;
            this.tbApellidoCliente.TextChanged += new System.EventHandler(this.tbApellidoCliente_TextChanged);
            this.tbApellidoCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoCliente_KeyPress);
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCliente.Location = new System.Drawing.Point(151, 94);
            this.tbNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(245, 20);
            this.tbNombreCliente.TabIndex = 60;
            this.tbNombreCliente.TextChanged += new System.EventHandler(this.tbNombreCliente_TextChanged);
            this.tbNombreCliente.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreCliente_KeyPress);
            // 
            // lblEmailCliente
            // 
            this.lblEmailCliente.AutoSize = true;
            this.lblEmailCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEmailCliente.ForeColor = System.Drawing.Color.Black;
            this.lblEmailCliente.Location = new System.Drawing.Point(84, 242);
            this.lblEmailCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailCliente.Name = "lblEmailCliente";
            this.lblEmailCliente.Size = new System.Drawing.Size(54, 19);
            this.lblEmailCliente.TabIndex = 58;
            this.lblEmailCliente.Text = "E-mail:";
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoCliente.Location = new System.Drawing.Point(72, 128);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(66, 19);
            this.lblApellidoCliente.TabIndex = 57;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCliente.Location = new System.Drawing.Point(70, 93);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(68, 19);
            this.lblNombreCliente.TabIndex = 56;
            this.lblNombreCliente.Text = "Nombre: ";
            // 
            // btnModificarCliente
            // 
            this.btnModificarCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnModificarCliente.FlatAppearance.BorderSize = 0;
            this.btnModificarCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnModificarCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarCliente.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnModificarCliente.ForeColor = System.Drawing.Color.White;
            this.btnModificarCliente.Location = new System.Drawing.Point(34, 356);
            this.btnModificarCliente.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarCliente.Name = "btnModificarCliente";
            this.btnModificarCliente.Size = new System.Drawing.Size(120, 34);
            this.btnModificarCliente.TabIndex = 55;
            this.btnModificarCliente.Text = "Guardar cambios";
            this.btnModificarCliente.UseVisualStyleBackColor = false;
            this.btnModificarCliente.Click += new System.EventHandler(this.btnModificarCliente_Click);
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
            this.lblNacimientoCliente.Location = new System.Drawing.Point(11, 199);
            this.lblNacimientoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacimientoCliente.Name = "lblNacimientoCliente";
            this.lblNacimientoCliente.Size = new System.Drawing.Size(127, 19);
            this.lblNacimientoCliente.TabIndex = 69;
            this.lblNacimientoCliente.Text = "Fecha nacimiento:";
            // 
            // dtp_nacimientoCliente
            // 
            this.dtp_nacimientoCliente.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimientoCliente.Location = new System.Drawing.Point(151, 199);
            this.dtp_nacimientoCliente.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoCliente.MinDate = new System.DateTime(1952, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoCliente.Name = "dtp_nacimientoCliente";
            this.dtp_nacimientoCliente.Size = new System.Drawing.Size(97, 20);
            this.dtp_nacimientoCliente.TabIndex = 68;
            this.dtp_nacimientoCliente.Value = new System.DateTime(1994, 6, 8, 0, 0, 0, 0);
            // 
            // tbIDCliente
            // 
            this.tbIDCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDCliente.Location = new System.Drawing.Point(301, 50);
            this.tbIDCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDCliente.Name = "tbIDCliente";
            this.tbIDCliente.Size = new System.Drawing.Size(36, 20);
            this.tbIDCliente.TabIndex = 70;
            this.tbIDCliente.Visible = false;
            // 
            // btnCancelarEdicion
            // 
            this.btnCancelarEdicion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelarEdicion.FlatAppearance.BorderSize = 0;
            this.btnCancelarEdicion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelarEdicion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarEdicion.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelarEdicion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarEdicion.Location = new System.Drawing.Point(276, 356);
            this.btnCancelarEdicion.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelarEdicion.Name = "btnCancelarEdicion";
            this.btnCancelarEdicion.Size = new System.Drawing.Size(120, 34);
            this.btnCancelarEdicion.TabIndex = 71;
            this.btnCancelarEdicion.Text = "Cancelar";
            this.btnCancelarEdicion.UseVisualStyleBackColor = false;
            this.btnCancelarEdicion.Click += new System.EventHandler(this.btnCancelarEdicion_Click);
            // 
            // FrmEditarCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 418);
            this.Controls.Add(this.btnCancelarEdicion);
            this.Controls.Add(this.tbIDCliente);
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
            this.Controls.Add(this.btnModificarCliente);
            this.Controls.Add(lblModificarCliente);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarCliente";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar cliente";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCliente)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.Label lblDNICliente;
        private System.Windows.Forms.TextBox tbTelefonoCliente;
        private System.Windows.Forms.Label lblTelefonoCliente;
        private System.Windows.Forms.TextBox tbEmailCliente;
        private System.Windows.Forms.TextBox tbDNICliente;
        private System.Windows.Forms.TextBox tbApellidoCliente;
        private System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblEmailCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private System.Windows.Forms.Button btnModificarCliente;
        private System.Windows.Forms.ErrorProvider ErrorCliente;
        private System.Windows.Forms.Label lblNacimientoCliente;
        private System.Windows.Forms.DateTimePicker dtp_nacimientoCliente;
        private System.Windows.Forms.TextBox tbIDCliente;
        private System.Windows.Forms.Button btnCancelarEdicion;
    }
}