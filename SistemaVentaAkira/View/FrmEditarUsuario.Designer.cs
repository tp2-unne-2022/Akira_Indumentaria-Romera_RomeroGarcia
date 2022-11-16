namespace SistemaVentaAkira.View
{
    partial class FrmEditarUsuario
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
            System.Windows.Forms.Label lblEditarUsuario;
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.tbTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.cbRolUsuario = new System.Windows.Forms.ComboBox();
            this.tbClaveUsuario = new System.Windows.Forms.TextBox();
            this.tbEmailUsuario = new System.Windows.Forms.TextBox();
            this.tbApellidoUsuario = new System.Windows.Forms.TextBox();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.ErrorUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbIDUser = new System.Windows.Forms.TextBox();
            this.lblNacimientoUsuario = new System.Windows.Forms.Label();
            this.dtp_nacimientoUsuario = new System.Windows.Forms.DateTimePicker();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            lblEditarUsuario = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarUsuario
            // 
            lblEditarUsuario.AutoSize = true;
            lblEditarUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblEditarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblEditarUsuario.Location = new System.Drawing.Point(133, 43);
            lblEditarUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblEditarUsuario.Name = "lblEditarUsuario";
            lblEditarUsuario.Size = new System.Drawing.Size(139, 23);
            lblEditarUsuario.TabIndex = 37;
            lblEditarUsuario.Text = "Editar usuario";
            lblEditarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.IcClose.Location = new System.Drawing.Point(396, 1);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 16;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // tbTelefonoUsuario
            // 
            this.tbTelefonoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoUsuario.Location = new System.Drawing.Point(133, 266);
            this.tbTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefonoUsuario.Name = "tbTelefonoUsuario";
            this.tbTelefonoUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbTelefonoUsuario.TabIndex = 54;
            this.tbTelefonoUsuario.TextChanged += new System.EventHandler(this.tbTelefonoUsuario_TextChanged);
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefonoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(48, 267);
            this.lblTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblTelefonoUsuario.TabIndex = 53;
            this.lblTelefonoUsuario.Text = "Teléfono:";
            // 
            // cbRolUsuario
            // 
            this.cbRolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRolUsuario.FormattingEnabled = true;
            this.cbRolUsuario.Location = new System.Drawing.Point(147, 350);
            this.cbRolUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbRolUsuario.Name = "cbRolUsuario";
            this.cbRolUsuario.Size = new System.Drawing.Size(207, 21);
            this.cbRolUsuario.TabIndex = 51;
            this.cbRolUsuario.TextChanged += new System.EventHandler(this.cbRolUsuario_TextChanged);
            // 
            // tbClaveUsuario
            // 
            this.tbClaveUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClaveUsuario.Location = new System.Drawing.Point(135, 300);
            this.tbClaveUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbClaveUsuario.Name = "tbClaveUsuario";
            this.tbClaveUsuario.PasswordChar = '*';
            this.tbClaveUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbClaveUsuario.TabIndex = 50;
            this.tbClaveUsuario.TextChanged += new System.EventHandler(this.tbClaveUsuario_TextChanged);
            // 
            // tbEmailUsuario
            // 
            this.tbEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailUsuario.Location = new System.Drawing.Point(133, 235);
            this.tbEmailUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailUsuario.Name = "tbEmailUsuario";
            this.tbEmailUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbEmailUsuario.TabIndex = 49;
            this.tbEmailUsuario.TextChanged += new System.EventHandler(this.tbEmailUsuario_TextChanged);
            // 
            // tbApellidoUsuario
            // 
            this.tbApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoUsuario.Location = new System.Drawing.Point(125, 133);
            this.tbApellidoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidoUsuario.Name = "tbApellidoUsuario";
            this.tbApellidoUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbApellidoUsuario.TabIndex = 47;
            this.tbApellidoUsuario.TextChanged += new System.EventHandler(this.tbApellidoUsuario_TextChanged);
            this.tbApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoUsuario_KeyPress);
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.Location = new System.Drawing.Point(127, 94);
            this.tbNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbNombreUsuario.TabIndex = 46;
            this.tbNombreUsuario.TextChanged += new System.EventHandler(this.tbNombreUsuario_TextChanged);
            this.tbNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreUsuario_KeyPress);
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblRolUsuario.Location = new System.Drawing.Point(97, 352);
            this.lblRolUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(34, 19);
            this.lblRolUsuario.TabIndex = 44;
            this.lblRolUsuario.Text = "Rol:";
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblClaveUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblClaveUsuario.Location = new System.Drawing.Point(32, 301);
            this.lblClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(87, 19);
            this.lblClaveUsuario.TabIndex = 43;
            this.lblClaveUsuario.Text = "Contraseña:";
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEmailUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblEmailUsuario.Location = new System.Drawing.Point(63, 236);
            this.lblEmailUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(54, 19);
            this.lblEmailUsuario.TabIndex = 42;
            this.lblEmailUsuario.Text = "E-mail:";
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblApellidoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoUsuario.Location = new System.Drawing.Point(45, 132);
            this.lblApellidoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(66, 19);
            this.lblApellidoUsuario.TabIndex = 40;
            this.lblApellidoUsuario.Text = "Apellido:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreUsuario.Location = new System.Drawing.Point(45, 94);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(68, 19);
            this.lblNombreUsuario.TabIndex = 39;
            this.lblNombreUsuario.Text = "Nombre: ";
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnModificarUsuario.FlatAppearance.BorderSize = 0;
            this.btnModificarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnModificarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarUsuario.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnModificarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnModificarUsuario.Location = new System.Drawing.Point(34, 388);
            this.btnModificarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(125, 34);
            this.btnModificarUsuario.TabIndex = 38;
            this.btnModificarUsuario.Text = "Guardar cambios";
            this.btnModificarUsuario.UseVisualStyleBackColor = false;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // ErrorUser
            // 
            this.ErrorUser.ContainerControl = this;
            // 
            // tbIDUser
            // 
            this.tbIDUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbIDUser.Location = new System.Drawing.Point(276, 43);
            this.tbIDUser.Margin = new System.Windows.Forms.Padding(2);
            this.tbIDUser.Name = "tbIDUser";
            this.tbIDUser.Size = new System.Drawing.Size(20, 20);
            this.tbIDUser.TabIndex = 55;
            this.tbIDUser.Visible = false;
            // 
            // lblNacimientoUsuario
            // 
            this.lblNacimientoUsuario.AutoSize = true;
            this.lblNacimientoUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNacimientoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNacimientoUsuario.Location = new System.Drawing.Point(32, 205);
            this.lblNacimientoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacimientoUsuario.Name = "lblNacimientoUsuario";
            this.lblNacimientoUsuario.Size = new System.Drawing.Size(127, 19);
            this.lblNacimientoUsuario.TabIndex = 57;
            this.lblNacimientoUsuario.Text = "Fecha nacimiento:";
            // 
            // dtp_nacimientoUsuario
            // 
            this.dtp_nacimientoUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimientoUsuario.Location = new System.Drawing.Point(179, 205);
            this.dtp_nacimientoUsuario.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoUsuario.MinDate = new System.DateTime(1952, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoUsuario.Name = "dtp_nacimientoUsuario";
            this.dtp_nacimientoUsuario.Size = new System.Drawing.Size(97, 20);
            this.dtp_nacimientoUsuario.TabIndex = 56;
            this.dtp_nacimientoUsuario.Value = new System.DateTime(1994, 6, 8, 0, 0, 0, 0);
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(247, 388);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(125, 34);
            this.btnCancelar.TabIndex = 58;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(127, 170);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbUsuario.TabIndex = 60;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(47, 169);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 59;
            this.lblUsuario.Text = "Usuario:";
            // 
            // FrmEditarUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(430, 434);
            this.Controls.Add(this.tbUsuario);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.lblNacimientoUsuario);
            this.Controls.Add(this.dtp_nacimientoUsuario);
            this.Controls.Add(this.tbIDUser);
            this.Controls.Add(this.tbTelefonoUsuario);
            this.Controls.Add(this.lblTelefonoUsuario);
            this.Controls.Add(this.cbRolUsuario);
            this.Controls.Add(this.tbClaveUsuario);
            this.Controls.Add(this.tbEmailUsuario);
            this.Controls.Add(this.tbApellidoUsuario);
            this.Controls.Add(this.tbNombreUsuario);
            this.Controls.Add(this.lblRolUsuario);
            this.Controls.Add(this.lblClaveUsuario);
            this.Controls.Add(this.lblEmailUsuario);
            this.Controls.Add(this.lblApellidoUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.btnModificarUsuario);
            this.Controls.Add(lblEditarUsuario);
            this.Controls.Add(this.panelTitulo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarUsuario";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar usuario";
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.TextBox tbTelefonoUsuario;
        private System.Windows.Forms.Label lblTelefonoUsuario;
        private System.Windows.Forms.ComboBox cbRolUsuario;
        private System.Windows.Forms.TextBox tbClaveUsuario;
        private System.Windows.Forms.TextBox tbEmailUsuario;
        private System.Windows.Forms.TextBox tbApellidoUsuario;
        private System.Windows.Forms.TextBox tbNombreUsuario;
        private System.Windows.Forms.Label lblRolUsuario;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.Label lblEmailUsuario;
        private System.Windows.Forms.Label lblApellidoUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.ErrorProvider ErrorUser;
        private System.Windows.Forms.TextBox tbIDUser;
        private System.Windows.Forms.Label lblNacimientoUsuario;
        private System.Windows.Forms.DateTimePicker dtp_nacimientoUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox tbUsuario;
        private System.Windows.Forms.Label lblUsuario;
    }
}