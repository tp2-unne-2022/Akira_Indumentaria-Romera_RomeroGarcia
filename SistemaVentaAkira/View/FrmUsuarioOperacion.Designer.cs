using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class FrmUsuarioOperacion
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
            System.Windows.Forms.Label lblRegistrarUsuario;
            this.btnRegistrarUsuario = new System.Windows.Forms.Button();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblApellidoUsuario = new System.Windows.Forms.Label();
            this.lblEmailUsuario = new System.Windows.Forms.Label();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.lblRolUsuario = new System.Windows.Forms.Label();
            this.tbNombreUsuario = new System.Windows.Forms.TextBox();
            this.tbApellidoUsuario = new System.Windows.Forms.TextBox();
            this.tbEmailUsuario = new System.Windows.Forms.TextBox();
            this.tbClaveUsuario = new System.Windows.Forms.TextBox();
            this.cbRolUsuario = new System.Windows.Forms.ComboBox();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.tbTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.ErrorUser = new System.Windows.Forms.ErrorProvider(this.components);
            this.dtp_nacimientoUsuario = new System.Windows.Forms.DateTimePicker();
            this.lblNacimientoUsuario = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.tbUsuario = new System.Windows.Forms.TextBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            lblRegistrarUsuario = new System.Windows.Forms.Label();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUser)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrarUsuario
            // 
            lblRegistrarUsuario.AutoSize = true;
            lblRegistrarUsuario.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblRegistrarUsuario.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblRegistrarUsuario.Location = new System.Drawing.Point(128, 48);
            lblRegistrarUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblRegistrarUsuario.Name = "lblRegistrarUsuario";
            lblRegistrarUsuario.Size = new System.Drawing.Size(169, 23);
            lblRegistrarUsuario.TabIndex = 0;
            lblRegistrarUsuario.Text = "Registrar usuario";
            lblRegistrarUsuario.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnRegistrarUsuario
            // 
            this.btnRegistrarUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnRegistrarUsuario.FlatAppearance.BorderSize = 0;
            this.btnRegistrarUsuario.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnRegistrarUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarUsuario.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnRegistrarUsuario.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarUsuario.Location = new System.Drawing.Point(33, 389);
            this.btnRegistrarUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.btnRegistrarUsuario.Name = "btnRegistrarUsuario";
            this.btnRegistrarUsuario.Size = new System.Drawing.Size(123, 34);
            this.btnRegistrarUsuario.TabIndex = 1;
            this.btnRegistrarUsuario.Text = "Registrar usuario";
            this.btnRegistrarUsuario.UseVisualStyleBackColor = false;
            this.btnRegistrarUsuario.Click += new System.EventHandler(this.btnRegistrarUsuario_Click);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNombreUsuario.Location = new System.Drawing.Point(48, 91);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(68, 19);
            this.lblNombreUsuario.TabIndex = 2;
            this.lblNombreUsuario.Text = "Nombre: ";
            // 
            // lblApellidoUsuario
            // 
            this.lblApellidoUsuario.AutoSize = true;
            this.lblApellidoUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblApellidoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblApellidoUsuario.Location = new System.Drawing.Point(48, 126);
            this.lblApellidoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoUsuario.Name = "lblApellidoUsuario";
            this.lblApellidoUsuario.Size = new System.Drawing.Size(66, 19);
            this.lblApellidoUsuario.TabIndex = 3;
            this.lblApellidoUsuario.Text = "Apellido:";
            // 
            // lblEmailUsuario
            // 
            this.lblEmailUsuario.AutoSize = true;
            this.lblEmailUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblEmailUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblEmailUsuario.Location = new System.Drawing.Point(29, 232);
            this.lblEmailUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblEmailUsuario.Name = "lblEmailUsuario";
            this.lblEmailUsuario.Size = new System.Drawing.Size(54, 19);
            this.lblEmailUsuario.TabIndex = 5;
            this.lblEmailUsuario.Text = "E-mail:";
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblClaveUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblClaveUsuario.Location = new System.Drawing.Point(26, 314);
            this.lblClaveUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(87, 19);
            this.lblClaveUsuario.TabIndex = 6;
            this.lblClaveUsuario.Text = "Contraseña:";
            // 
            // lblRolUsuario
            // 
            this.lblRolUsuario.AutoSize = true;
            this.lblRolUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblRolUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblRolUsuario.Location = new System.Drawing.Point(63, 357);
            this.lblRolUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRolUsuario.Name = "lblRolUsuario";
            this.lblRolUsuario.Size = new System.Drawing.Size(34, 19);
            this.lblRolUsuario.TabIndex = 7;
            this.lblRolUsuario.Text = "Rol:";
            // 
            // tbNombreUsuario
            // 
            this.tbNombreUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreUsuario.Location = new System.Drawing.Point(130, 92);
            this.tbNombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreUsuario.Name = "tbNombreUsuario";
            this.tbNombreUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbNombreUsuario.TabIndex = 9;
            this.tbNombreUsuario.TextChanged += new System.EventHandler(this.tbNombreUsuario_TextChanged);
            this.tbNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreUsuario_KeyPress);
            // 
            // tbApellidoUsuario
            // 
            this.tbApellidoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoUsuario.Location = new System.Drawing.Point(130, 127);
            this.tbApellidoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidoUsuario.Name = "tbApellidoUsuario";
            this.tbApellidoUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbApellidoUsuario.TabIndex = 10;
            this.tbApellidoUsuario.TextChanged += new System.EventHandler(this.tbApellidoUsuario_TextChanged);
            this.tbApellidoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbApellidoUsuario_KeyPress);
            // 
            // tbEmailUsuario
            // 
            this.tbEmailUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbEmailUsuario.Location = new System.Drawing.Point(111, 231);
            this.tbEmailUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbEmailUsuario.Name = "tbEmailUsuario";
            this.tbEmailUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbEmailUsuario.TabIndex = 12;
            this.tbEmailUsuario.TextChanged += new System.EventHandler(this.tbEmailUsuario_TextChanged);
            // 
            // tbClaveUsuario
            // 
            this.tbClaveUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbClaveUsuario.Location = new System.Drawing.Point(127, 315);
            this.tbClaveUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbClaveUsuario.Name = "tbClaveUsuario";
            this.tbClaveUsuario.PasswordChar = '*';
            this.tbClaveUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbClaveUsuario.TabIndex = 13;
            this.tbClaveUsuario.TextChanged += new System.EventHandler(this.tbClaveUsuario_TextChanged);
            // 
            // cbRolUsuario
            // 
            this.cbRolUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbRolUsuario.FormattingEnabled = true;
            this.cbRolUsuario.Location = new System.Drawing.Point(130, 358);
            this.cbRolUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.cbRolUsuario.Name = "cbRolUsuario";
            this.cbRolUsuario.Size = new System.Drawing.Size(207, 21);
            this.cbRolUsuario.TabIndex = 14;
            this.cbRolUsuario.TextChanged += new System.EventHandler(this.cbRolUsuario_TextChanged);
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefonoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(26, 271);
            this.lblTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(69, 19);
            this.lblTelefonoUsuario.TabIndex = 16;
            this.lblTelefonoUsuario.Text = "Teléfono:";
            // 
            // tbTelefonoUsuario
            // 
            this.tbTelefonoUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbTelefonoUsuario.Location = new System.Drawing.Point(111, 272);
            this.tbTelefonoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbTelefonoUsuario.Name = "tbTelefonoUsuario";
            this.tbTelefonoUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbTelefonoUsuario.TabIndex = 17;
            this.tbTelefonoUsuario.TextChanged += new System.EventHandler(this.tbTelefonoUsuario_TextChanged);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(430, 26);
            this.panelTitulo.TabIndex = 35;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.White;
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(396, 0);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 16;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // ErrorUser
            // 
            this.ErrorUser.ContainerControl = this;
            // 
            // dtp_nacimientoUsuario
            // 
            this.dtp_nacimientoUsuario.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_nacimientoUsuario.Location = new System.Drawing.Point(161, 194);
            this.dtp_nacimientoUsuario.MaxDate = new System.DateTime(2005, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoUsuario.MinDate = new System.DateTime(1952, 1, 1, 0, 0, 0, 0);
            this.dtp_nacimientoUsuario.Name = "dtp_nacimientoUsuario";
            this.dtp_nacimientoUsuario.Size = new System.Drawing.Size(97, 20);
            this.dtp_nacimientoUsuario.TabIndex = 36;
            this.dtp_nacimientoUsuario.Value = new System.DateTime(1994, 6, 8, 0, 0, 0, 0);
            // 
            // lblNacimientoUsuario
            // 
            this.lblNacimientoUsuario.AutoSize = true;
            this.lblNacimientoUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNacimientoUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblNacimientoUsuario.Location = new System.Drawing.Point(29, 194);
            this.lblNacimientoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNacimientoUsuario.Name = "lblNacimientoUsuario";
            this.lblNacimientoUsuario.Size = new System.Drawing.Size(127, 19);
            this.lblNacimientoUsuario.TabIndex = 37;
            this.lblNacimientoUsuario.Text = "Fecha nacimiento:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(266, 389);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(2);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(123, 34);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // tbUsuario
            // 
            this.tbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbUsuario.Location = new System.Drawing.Point(130, 164);
            this.tbUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.tbUsuario.Name = "tbUsuario";
            this.tbUsuario.Size = new System.Drawing.Size(245, 20);
            this.tbUsuario.TabIndex = 62;
            this.tbUsuario.TextChanged += new System.EventHandler(this.tbUsuario_TextChanged);
            this.tbUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbUsuario_KeyPress);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblUsuario.ForeColor = System.Drawing.Color.Black;
            this.lblUsuario.Location = new System.Drawing.Point(50, 163);
            this.lblUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(63, 19);
            this.lblUsuario.TabIndex = 61;
            this.lblUsuario.Text = "Usuario:";
            // 
            // FrmUsuarioOperacion
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
            this.Controls.Add(this.panelTitulo);
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
            this.Controls.Add(this.btnRegistrarUsuario);
            this.Controls.Add(lblRegistrarUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmUsuarioOperacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro Usuario";
            this.Load += new System.EventHandler(this.FrmUsuarioOperacion_Load);
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistrarUsuario;
        private Label lblNombreUsuario;
        private Label lblApellidoUsuario;
        private Label lblEmailUsuario;
        private Label lblClaveUsuario;
        private Label lblRolUsuario;
        private TextBox tbNombreUsuario;
        private TextBox tbApellidoUsuario;
        private TextBox tbEmailUsuario;
        private TextBox tbClaveUsuario;
        private ComboBox cbRolUsuario;
        private Label lblTelefonoUsuario;
        private TextBox tbTelefonoUsuario;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private ErrorProvider ErrorUser;
        private Label lblNacimientoUsuario;
        private DateTimePicker dtp_nacimientoUsuario;
        private Button btnCancelar;
        private TextBox tbUsuario;
        private Label lblUsuario;
    }
}