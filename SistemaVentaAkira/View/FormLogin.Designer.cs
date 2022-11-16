using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class FormLogin
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblContraseña = new System.Windows.Forms.Label();
            this.PLadoInferior = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.PLadoIzquierdo = new System.Windows.Forms.Panel();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblAcceso = new System.Windows.Forms.Label();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.ICMinimized = new FontAwesome.Sharp.IconPictureBox();
            this.IPBvisualizarClave = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.BtnAcceder = new System.Windows.Forms.Button();
            this.TxtUser = new System.Windows.Forms.TextBox();
            this.TextPassword = new System.Windows.Forms.TextBox();
            this.errorLogin = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel2.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICMinimized)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBvisualizarClave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.panel2.Controls.Add(this.LblContraseña);
            this.panel2.Controls.Add(this.PLadoInferior);
            this.panel2.Controls.Add(this.panel1);
            this.panel2.Controls.Add(this.PLadoIzquierdo);
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.panelTitulo);
            this.panel2.Controls.Add(this.IPBvisualizarClave);
            this.panel2.Controls.Add(this.iconPictureBox2);
            this.panel2.Controls.Add(this.iconPictureBox1);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.BtnAcceder);
            this.panel2.Controls.Add(this.TxtUser);
            this.panel2.Controls.Add(this.TextPassword);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 20.25F);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(472, 473);
            this.panel2.TabIndex = 6;
            // 
            // LblContraseña
            // 
            this.LblContraseña.AutoSize = true;
            this.LblContraseña.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblContraseña.Location = new System.Drawing.Point(130, 298);
            this.LblContraseña.Name = "LblContraseña";
            this.LblContraseña.Size = new System.Drawing.Size(86, 19);
            this.LblContraseña.TabIndex = 5;
            this.LblContraseña.Text = "Contraseña";
            // 
            // PLadoInferior
            // 
            this.PLadoInferior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.PLadoInferior.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PLadoInferior.Location = new System.Drawing.Point(5, 468);
            this.PLadoInferior.Name = "PLadoInferior";
            this.PLadoInferior.Size = new System.Drawing.Size(462, 5);
            this.PLadoInferior.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel1.Location = new System.Drawing.Point(467, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(5, 444);
            this.panel1.TabIndex = 16;
            // 
            // PLadoIzquierdo
            // 
            this.PLadoIzquierdo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.PLadoIzquierdo.Dock = System.Windows.Forms.DockStyle.Left;
            this.PLadoIzquierdo.Location = new System.Drawing.Point(0, 29);
            this.PLadoIzquierdo.Name = "PLadoIzquierdo";
            this.PLadoIzquierdo.Size = new System.Drawing.Size(5, 444);
            this.PLadoIzquierdo.TabIndex = 7;
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUsuario.Location = new System.Drawing.Point(130, 219);
            this.LblUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(61, 19);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Usuario";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.lblAcceso);
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Controls.Add(this.ICMinimized);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(472, 29);
            this.panelTitulo.TabIndex = 15;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblAcceso
            // 
            this.lblAcceso.AutoSize = true;
            this.lblAcceso.Font = new System.Drawing.Font("Segoe UI", 6.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceso.ForeColor = System.Drawing.Color.Gainsboro;
            this.lblAcceso.Location = new System.Drawing.Point(3, 9);
            this.lblAcceso.Name = "lblAcceso";
            this.lblAcceso.Size = new System.Drawing.Size(90, 12);
            this.lblAcceso.TabIndex = 13;
            this.lblAcceso.Text = "ACCESO AL SISTEMA";
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.White;
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 19;
            this.IcClose.Location = new System.Drawing.Point(438, 3);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 19);
            this.IcClose.TabIndex = 11;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // ICMinimized
            // 
            this.ICMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.ICMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ICMinimized.IconColor = System.Drawing.Color.White;
            this.ICMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICMinimized.IconSize = 17;
            this.ICMinimized.Location = new System.Drawing.Point(401, 0);
            this.ICMinimized.Name = "ICMinimized";
            this.ICMinimized.Size = new System.Drawing.Size(17, 22);
            this.ICMinimized.TabIndex = 12;
            this.ICMinimized.TabStop = false;
            this.ICMinimized.Click += new System.EventHandler(this.ICMinimized_Click);
            // 
            // IPBvisualizarClave
            // 
            this.IPBvisualizarClave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.IPBvisualizarClave.ForeColor = System.Drawing.SystemColors.ControlText;
            this.IPBvisualizarClave.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.IPBvisualizarClave.IconColor = System.Drawing.SystemColors.ControlText;
            this.IPBvisualizarClave.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IPBvisualizarClave.IconSize = 23;
            this.IPBvisualizarClave.Location = new System.Drawing.Point(329, 294);
            this.IPBvisualizarClave.Name = "IPBvisualizarClave";
            this.IPBvisualizarClave.Size = new System.Drawing.Size(27, 23);
            this.IPBvisualizarClave.TabIndex = 9;
            this.IPBvisualizarClave.TabStop = false;
            this.IPBvisualizarClave.Click += new System.EventHandler(this.IPBvisualizarClave_Click);
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.iconPictureBox2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Key;
            this.iconPictureBox2.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 19;
            this.iconPictureBox2.Location = new System.Drawing.Point(105, 298);
            this.iconPictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(22, 19);
            this.iconPictureBox2.TabIndex = 8;
            this.iconPictureBox2.TabStop = false;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Solid;
            this.iconPictureBox1.IconSize = 19;
            this.iconPictureBox1.Location = new System.Drawing.Point(105, 219);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(22, 19);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::SistemaVentaAkira.Properties.Resources.logoParaElCentro;
            this.pictureBox1.Location = new System.Drawing.Point(121, 98);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(214, 56);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // BtnAcceder
            // 
            this.BtnAcceder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.BtnAcceder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAcceder.Font = new System.Drawing.Font("Calibri", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAcceder.ForeColor = System.Drawing.Color.White;
            this.BtnAcceder.Location = new System.Drawing.Point(163, 388);
            this.BtnAcceder.Name = "BtnAcceder";
            this.BtnAcceder.Size = new System.Drawing.Size(122, 34);
            this.BtnAcceder.TabIndex = 3;
            this.BtnAcceder.Text = "Acceder";
            this.BtnAcceder.UseVisualStyleBackColor = false;
            this.BtnAcceder.Click += new System.EventHandler(this.BtnAcceder_Click);
            // 
            // TxtUser
            // 
            this.TxtUser.BackColor = System.Drawing.Color.White;
            this.TxtUser.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TxtUser.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtUser.ForeColor = System.Drawing.Color.Black;
            this.TxtUser.Location = new System.Drawing.Point(105, 241);
            this.TxtUser.Name = "TxtUser";
            this.TxtUser.Size = new System.Drawing.Size(251, 26);
            this.TxtUser.TabIndex = 2;
            this.TxtUser.TextChanged += new System.EventHandler(this.TxtUser_TextChanged);
            this.TxtUser.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TxtUser_KeyPress);
            // 
            // TextPassword
            // 
            this.TextPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextPassword.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextPassword.ForeColor = System.Drawing.Color.Black;
            this.TextPassword.Location = new System.Drawing.Point(105, 318);
            this.TextPassword.Name = "TextPassword";
            this.TextPassword.Size = new System.Drawing.Size(251, 26);
            this.TextPassword.TabIndex = 2;
            this.TextPassword.TextChanged += new System.EventHandler(this.TextPassword_TextChanged);
            this.TextPassword.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TextPassword_KeyPress);
            // 
            // errorLogin
            // 
            this.errorLogin.ContainerControl = this;
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(472, 473);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormLogin";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inicio de Sesión";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICMinimized)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IPBvisualizarClave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorLogin)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Panel panel2;
        private FontAwesome.Sharp.IconPictureBox IPBvisualizarClave;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Button BtnAcceder;
        private Label LblContraseña;
        private TextBox TxtUser;
        private TextBox TextPassword;
        private Label LblUsuario;
        private FontAwesome.Sharp.IconPictureBox ICMinimized;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private Panel panelTitulo;
        private PictureBox pictureBox1;
        private ErrorProvider errorLogin;
        private Label lblAcceso;
        private Panel PLadoInferior;
        private Panel panel1;
        private Panel PLadoIzquierdo;
    }
}