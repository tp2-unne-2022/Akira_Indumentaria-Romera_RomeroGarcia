using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class Menu_Supervisor
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
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.ICRestore = new FontAwesome.Sharp.IconButton();
            this.ICBackUp = new FontAwesome.Sharp.IconButton();
            this.subMenuUsuarios = new System.Windows.Forms.Panel();
            this.btnUsuariosEliminados = new System.Windows.Forms.Button();
            this.btnGrillaUsuarios = new System.Windows.Forms.Button();
            this.ICusuarios = new FontAwesome.Sharp.IconButton();
            this.ICsalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.PLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblUsuarioTxt = new System.Windows.Forms.Label();
            this.lblnombretxt = new System.Windows.Forms.Label();
            this.lblroltxt = new System.Windows.Forms.Label();
            this.ICuseractivo = new FontAwesome.Sharp.IconPictureBox();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.LblNombre = new System.Windows.Forms.Label();
            this.LblRol = new System.Windows.Forms.Label();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.ICMinimized = new FontAwesome.Sharp.IconPictureBox();
            this.panelFormularios = new System.Windows.Forms.Panel();
            this.LblFechaAct = new System.Windows.Forms.Label();
            this.LblHoraAct = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LblHora = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.Horario = new System.Windows.Forms.Timer(this.components);
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            this.subMenuUsuarios.SuspendLayout();
            this.panel2.SuspendLayout();
            this.PLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICuseractivo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICMinimized)).BeginInit();
            this.panelFormularios.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.ICsalir);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 488);
            this.panelMenu.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ICRestore);
            this.panel1.Controls.Add(this.ICBackUp);
            this.panel1.Controls.Add(this.subMenuUsuarios);
            this.panel1.Controls.Add(this.ICusuarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 88);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(180, 341);
            this.panel1.TabIndex = 8;
            // 
            // ICRestore
            // 
            this.ICRestore.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICRestore.FlatAppearance.BorderSize = 0;
            this.ICRestore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICRestore.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICRestore.ForeColor = System.Drawing.Color.White;
            this.ICRestore.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ICRestore.IconColor = System.Drawing.Color.White;
            this.ICRestore.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICRestore.IconSize = 40;
            this.ICRestore.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICRestore.Location = new System.Drawing.Point(0, 214);
            this.ICRestore.Name = "ICRestore";
            this.ICRestore.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICRestore.Size = new System.Drawing.Size(180, 70);
            this.ICRestore.TabIndex = 18;
            this.ICRestore.Text = "Restore";
            this.ICRestore.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICRestore.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICRestore.UseVisualStyleBackColor = true;
            this.ICRestore.Click += new System.EventHandler(this.ICRestore_Click);
            // 
            // ICBackUp
            // 
            this.ICBackUp.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICBackUp.FlatAppearance.BorderSize = 0;
            this.ICBackUp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICBackUp.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICBackUp.ForeColor = System.Drawing.Color.White;
            this.ICBackUp.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.ICBackUp.IconColor = System.Drawing.Color.White;
            this.ICBackUp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICBackUp.IconSize = 40;
            this.ICBackUp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICBackUp.Location = new System.Drawing.Point(0, 144);
            this.ICBackUp.Name = "ICBackUp";
            this.ICBackUp.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICBackUp.Size = new System.Drawing.Size(180, 70);
            this.ICBackUp.TabIndex = 17;
            this.ICBackUp.Text = "Back Up";
            this.ICBackUp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICBackUp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICBackUp.UseVisualStyleBackColor = true;
            this.ICBackUp.Click += new System.EventHandler(this.ICBackUp_Click);
            // 
            // subMenuUsuarios
            // 
            this.subMenuUsuarios.Controls.Add(this.btnUsuariosEliminados);
            this.subMenuUsuarios.Controls.Add(this.btnGrillaUsuarios);
            this.subMenuUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuUsuarios.Location = new System.Drawing.Point(0, 74);
            this.subMenuUsuarios.Name = "subMenuUsuarios";
            this.subMenuUsuarios.Size = new System.Drawing.Size(180, 70);
            this.subMenuUsuarios.TabIndex = 16;
            // 
            // btnUsuariosEliminados
            // 
            this.btnUsuariosEliminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnUsuariosEliminados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnUsuariosEliminados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnUsuariosEliminados.FlatAppearance.BorderSize = 0;
            this.btnUsuariosEliminados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnUsuariosEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUsuariosEliminados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuariosEliminados.ForeColor = System.Drawing.Color.White;
            this.btnUsuariosEliminados.Location = new System.Drawing.Point(0, 34);
            this.btnUsuariosEliminados.Name = "btnUsuariosEliminados";
            this.btnUsuariosEliminados.Size = new System.Drawing.Size(180, 34);
            this.btnUsuariosEliminados.TabIndex = 12;
            this.btnUsuariosEliminados.Text = "Ver usuarios eliminados";
            this.btnUsuariosEliminados.UseVisualStyleBackColor = false;
            this.btnUsuariosEliminados.Click += new System.EventHandler(this.btnUsuariosEliminados_Click);
            // 
            // btnGrillaUsuarios
            // 
            this.btnGrillaUsuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaUsuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrillaUsuarios.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaUsuarios.FlatAppearance.BorderSize = 0;
            this.btnGrillaUsuarios.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnGrillaUsuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrillaUsuarios.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrillaUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnGrillaUsuarios.Location = new System.Drawing.Point(0, 0);
            this.btnGrillaUsuarios.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrillaUsuarios.Name = "btnGrillaUsuarios";
            this.btnGrillaUsuarios.Size = new System.Drawing.Size(180, 34);
            this.btnGrillaUsuarios.TabIndex = 0;
            this.btnGrillaUsuarios.Text = "Gestión de usuarios";
            this.btnGrillaUsuarios.UseVisualStyleBackColor = false;
            this.btnGrillaUsuarios.Click += new System.EventHandler(this.btnGrillaUsuarios_Click);
            // 
            // ICusuarios
            // 
            this.ICusuarios.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.ICusuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICusuarios.FlatAppearance.BorderSize = 0;
            this.ICusuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICusuarios.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICusuarios.ForeColor = System.Drawing.Color.White;
            this.ICusuarios.IconChar = FontAwesome.Sharp.IconChar.UserPen;
            this.ICusuarios.IconColor = System.Drawing.Color.White;
            this.ICusuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICusuarios.IconSize = 40;
            this.ICusuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICusuarios.Location = new System.Drawing.Point(0, 0);
            this.ICusuarios.Name = "ICusuarios";
            this.ICusuarios.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICusuarios.Size = new System.Drawing.Size(180, 74);
            this.ICusuarios.TabIndex = 15;
            this.ICusuarios.Text = "Usuarios";
            this.ICusuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICusuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICusuarios.UseVisualStyleBackColor = false;
            this.ICusuarios.Click += new System.EventHandler(this.ICusuarios_Click);
            // 
            // ICsalir
            // 
            this.ICsalir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ICsalir.FlatAppearance.BorderSize = 0;
            this.ICsalir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICsalir.Font = new System.Drawing.Font("Ebrima", 12F);
            this.ICsalir.ForeColor = System.Drawing.Color.White;
            this.ICsalir.IconChar = FontAwesome.Sharp.IconChar.SignInAlt;
            this.ICsalir.IconColor = System.Drawing.Color.White;
            this.ICsalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICsalir.IconSize = 40;
            this.ICsalir.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICsalir.Location = new System.Drawing.Point(0, 429);
            this.ICsalir.Name = "ICsalir";
            this.ICsalir.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.ICsalir.Size = new System.Drawing.Size(180, 59);
            this.ICsalir.TabIndex = 7;
            this.ICsalir.Text = "Salir";
            this.ICsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICsalir.UseVisualStyleBackColor = true;
            this.ICsalir.Click += new System.EventHandler(this.ICsalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.PLogo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 88);
            this.panel2.TabIndex = 0;
            // 
            // PLogo
            // 
            this.PLogo.Controls.Add(this.pictureBox2);
            this.PLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PLogo.Location = new System.Drawing.Point(0, 0);
            this.PLogo.Name = "PLogo";
            this.PLogo.Size = new System.Drawing.Size(180, 89);
            this.PLogo.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::SistemaVentaAkira.Properties.Resources.logoMenu;
            this.pictureBox2.Location = new System.Drawing.Point(0, -2);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.lblUsuarioTxt);
            this.panelTitulo.Controls.Add(this.lblnombretxt);
            this.panelTitulo.Controls.Add(this.lblroltxt);
            this.panelTitulo.Controls.Add(this.ICuseractivo);
            this.panelTitulo.Controls.Add(this.lblUsuario);
            this.panelTitulo.Controls.Add(this.LblNombre);
            this.panelTitulo.Controls.Add(this.LblRol);
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Controls.Add(this.ICMinimized);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(180, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(688, 46);
            this.panelTitulo.TabIndex = 2;
            this.panelTitulo.Paint += new System.Windows.Forms.PaintEventHandler(this.panelTitulo_Paint);
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblUsuarioTxt
            // 
            this.lblUsuarioTxt.AutoSize = true;
            this.lblUsuarioTxt.ForeColor = System.Drawing.Color.White;
            this.lblUsuarioTxt.Location = new System.Drawing.Point(110, 26);
            this.lblUsuarioTxt.Name = "lblUsuarioTxt";
            this.lblUsuarioTxt.Size = new System.Drawing.Size(0, 13);
            this.lblUsuarioTxt.TabIndex = 21;
            // 
            // lblnombretxt
            // 
            this.lblnombretxt.AutoSize = true;
            this.lblnombretxt.ForeColor = System.Drawing.Color.White;
            this.lblnombretxt.Location = new System.Drawing.Point(110, 13);
            this.lblnombretxt.Name = "lblnombretxt";
            this.lblnombretxt.Size = new System.Drawing.Size(0, 13);
            this.lblnombretxt.TabIndex = 20;
            // 
            // lblroltxt
            // 
            this.lblroltxt.AutoSize = true;
            this.lblroltxt.ForeColor = System.Drawing.Color.White;
            this.lblroltxt.Location = new System.Drawing.Point(110, 0);
            this.lblroltxt.Name = "lblroltxt";
            this.lblroltxt.Size = new System.Drawing.Size(0, 13);
            this.lblroltxt.TabIndex = 19;
            // 
            // ICuseractivo
            // 
            this.ICuseractivo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.ICuseractivo.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.ICuseractivo.IconColor = System.Drawing.Color.White;
            this.ICuseractivo.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICuseractivo.IconSize = 34;
            this.ICuseractivo.Location = new System.Drawing.Point(6, 3);
            this.ICuseractivo.Name = "ICuseractivo";
            this.ICuseractivo.Size = new System.Drawing.Size(45, 34);
            this.ICuseractivo.TabIndex = 18;
            this.ICuseractivo.TabStop = false;
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.ForeColor = System.Drawing.Color.White;
            this.lblUsuario.Location = new System.Drawing.Point(57, 24);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(46, 13);
            this.lblUsuario.TabIndex = 17;
            this.lblUsuario.Text = "Usuario:";
            this.lblUsuario.Click += new System.EventHandler(this.lblUsuario_Click);
            // 
            // LblNombre
            // 
            this.LblNombre.AutoSize = true;
            this.LblNombre.ForeColor = System.Drawing.Color.White;
            this.LblNombre.Location = new System.Drawing.Point(57, 12);
            this.LblNombre.Name = "LblNombre";
            this.LblNombre.Size = new System.Drawing.Size(47, 13);
            this.LblNombre.TabIndex = 16;
            this.LblNombre.Text = "Nombre:";
            // 
            // LblRol
            // 
            this.LblRol.AutoSize = true;
            this.LblRol.ForeColor = System.Drawing.Color.White;
            this.LblRol.Location = new System.Drawing.Point(57, 0);
            this.LblRol.Name = "LblRol";
            this.LblRol.Size = new System.Drawing.Size(26, 13);
            this.LblRol.TabIndex = 15;
            this.LblRol.Text = "Rol:";
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.White;
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(663, 7);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 14;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // ICMinimized
            // 
            this.ICMinimized.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.ICMinimized.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.ICMinimized.IconColor = System.Drawing.Color.White;
            this.ICMinimized.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICMinimized.IconSize = 22;
            this.ICMinimized.Location = new System.Drawing.Point(623, 7);
            this.ICMinimized.Name = "ICMinimized";
            this.ICMinimized.Size = new System.Drawing.Size(22, 22);
            this.ICMinimized.TabIndex = 13;
            this.ICMinimized.TabStop = false;
            this.ICMinimized.Click += new System.EventHandler(this.ICMinimized_Click);
            // 
            // panelFormularios
            // 
            this.panelFormularios.Controls.Add(this.LblFechaAct);
            this.panelFormularios.Controls.Add(this.LblHoraAct);
            this.panelFormularios.Controls.Add(this.pictureBox1);
            this.panelFormularios.Location = new System.Drawing.Point(180, 49);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(686, 436);
            this.panelFormularios.TabIndex = 6;
            // 
            // LblFechaAct
            // 
            this.LblFechaAct.AutoSize = true;
            this.LblFechaAct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblFechaAct.Location = new System.Drawing.Point(210, 331);
            this.LblFechaAct.Name = "LblFechaAct";
            this.LblFechaAct.Size = new System.Drawing.Size(59, 21);
            this.LblFechaAct.TabIndex = 5;
            this.LblFechaAct.Text = "Fecha";
            // 
            // LblHoraAct
            // 
            this.LblHoraAct.AutoSize = true;
            this.LblHoraAct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblHoraAct.Location = new System.Drawing.Point(312, 364);
            this.LblHoraAct.Name = "LblHoraAct";
            this.LblHoraAct.Size = new System.Drawing.Size(47, 21);
            this.LblHoraAct.TabIndex = 4;
            this.LblHoraAct.Text = "Hora";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::SistemaVentaAkira.Properties.Resources.logoParaElCentro;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(686, 436);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // LblHora
            // 
            this.LblHora.AutoSize = true;
            this.LblHora.Font = new System.Drawing.Font("Ebrima", 21.75F);
            this.LblHora.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblHora.Location = new System.Drawing.Point(387, 280);
            this.LblHora.Name = "LblHora";
            this.LblHora.Size = new System.Drawing.Size(0, 40);
            this.LblHora.TabIndex = 4;
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.Font = new System.Drawing.Font("Ebrima", 21.75F);
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblFecha.Location = new System.Drawing.Point(291, 313);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(0, 40);
            this.LblFecha.TabIndex = 5;
            // 
            // Horario
            // 
            this.Horario.Enabled = true;
            this.Horario.Tick += new System.EventHandler(this.Horario_Tick);
            // 
            // Menu_Supervisor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 488);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Supervisor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menu Supervisor";
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.subMenuUsuarios.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.PLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTitulo.ResumeLayout(false);
            this.panelTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ICuseractivo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ICMinimized)).EndInit();
            this.panelFormularios.ResumeLayout(false);
            this.panelFormularios.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Panel panelMenu;
        private FontAwesome.Sharp.IconButton ICsalir;
        private Panel panel2;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox ICMinimized;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private PictureBox pictureBox1;
        private Label LblHora;
        private Label LblFecha;
        private System.Windows.Forms.Timer Horario;
        private Panel panelFormularios;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox ICuseractivo;
        private Label lblUsuario;
        private Label LblNombre;
        private Label LblRol;
        private Label LblFechaAct;
        private Label LblHoraAct;
        public Label lblUsuarioTxt;
        public Label lblnombretxt;
        public Label lblroltxt;
        private Panel panel1;
        private Panel PLogo;
        private FontAwesome.Sharp.IconButton ICusuarios;
        private Panel subMenuUsuarios;
        private Button btnUsuariosEliminados;
        private Button btnGrillaUsuarios;
        private FontAwesome.Sharp.IconButton ICBackUp;
        private FontAwesome.Sharp.IconButton ICRestore;
    }
}