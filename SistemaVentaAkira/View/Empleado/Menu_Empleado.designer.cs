using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class Menu_Empleado
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
            this.IBInformeVentas = new FontAwesome.Sharp.IconButton();
            this.subMenuClientes = new System.Windows.Forms.Panel();
            this.IBClientesElim = new FontAwesome.Sharp.IconButton();
            this.IBGrillaCliente = new FontAwesome.Sharp.IconButton();
            this.ICclientes = new FontAwesome.Sharp.IconButton();
            this.IconVentas = new FontAwesome.Sharp.IconButton();
            this.subMenuProductos = new System.Windows.Forms.Panel();
            this.IBProductosElim = new FontAwesome.Sharp.IconButton();
            this.IBGrillaProductos = new FontAwesome.Sharp.IconButton();
            this.ICProductos = new FontAwesome.Sharp.IconButton();
            this.ICsalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblemailtxt = new System.Windows.Forms.Label();
            this.lblroltxt = new System.Windows.Forms.Label();
            this.lblnombretxt = new System.Windows.Forms.Label();
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
            this.subMenuClientes.SuspendLayout();
            this.subMenuProductos.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.IBInformeVentas);
            this.panelMenu.Controls.Add(this.subMenuClientes);
            this.panelMenu.Controls.Add(this.ICclientes);
            this.panelMenu.Controls.Add(this.IconVentas);
            this.panelMenu.Controls.Add(this.subMenuProductos);
            this.panelMenu.Controls.Add(this.ICProductos);
            this.panelMenu.Controls.Add(this.ICsalir);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 506);
            this.panelMenu.TabIndex = 0;
            // 
            // IBInformeVentas
            // 
            this.IBInformeVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBInformeVentas.FlatAppearance.BorderSize = 0;
            this.IBInformeVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBInformeVentas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.IBInformeVentas.ForeColor = System.Drawing.Color.White;
            this.IBInformeVentas.IconChar = FontAwesome.Sharp.IconChar.FileInvoice;
            this.IBInformeVentas.IconColor = System.Drawing.Color.White;
            this.IBInformeVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBInformeVentas.IconSize = 40;
            this.IBInformeVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBInformeVentas.Location = new System.Drawing.Point(0, 390);
            this.IBInformeVentas.Name = "IBInformeVentas";
            this.IBInformeVentas.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.IBInformeVentas.Size = new System.Drawing.Size(180, 52);
            this.IBInformeVentas.TabIndex = 20;
            this.IBInformeVentas.Text = "Informe ventas";
            this.IBInformeVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IBInformeVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IBInformeVentas.UseVisualStyleBackColor = true;
            this.IBInformeVentas.Click += new System.EventHandler(this.IBInformeVentas_Click);
            // 
            // subMenuClientes
            // 
            this.subMenuClientes.Controls.Add(this.IBClientesElim);
            this.subMenuClientes.Controls.Add(this.IBGrillaCliente);
            this.subMenuClientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuClientes.Location = new System.Drawing.Point(0, 315);
            this.subMenuClientes.Name = "subMenuClientes";
            this.subMenuClientes.Size = new System.Drawing.Size(180, 75);
            this.subMenuClientes.TabIndex = 19;
            // 
            // IBClientesElim
            // 
            this.IBClientesElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBClientesElim.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBClientesElim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBClientesElim.FlatAppearance.BorderSize = 0;
            this.IBClientesElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.IBClientesElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBClientesElim.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBClientesElim.ForeColor = System.Drawing.Color.White;
            this.IBClientesElim.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBClientesElim.IconColor = System.Drawing.Color.Black;
            this.IBClientesElim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBClientesElim.Location = new System.Drawing.Point(0, 38);
            this.IBClientesElim.Margin = new System.Windows.Forms.Padding(0);
            this.IBClientesElim.Name = "IBClientesElim";
            this.IBClientesElim.Size = new System.Drawing.Size(180, 42);
            this.IBClientesElim.TabIndex = 2;
            this.IBClientesElim.Text = "Clientes eliminados";
            this.IBClientesElim.UseVisualStyleBackColor = false;
            this.IBClientesElim.Click += new System.EventHandler(this.IBClientesElim_Click);
            // 
            // IBGrillaCliente
            // 
            this.IBGrillaCliente.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBGrillaCliente.Dock = System.Windows.Forms.DockStyle.Top;
            this.IBGrillaCliente.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBGrillaCliente.FlatAppearance.BorderSize = 0;
            this.IBGrillaCliente.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.IBGrillaCliente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGrillaCliente.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBGrillaCliente.ForeColor = System.Drawing.Color.White;
            this.IBGrillaCliente.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBGrillaCliente.IconColor = System.Drawing.Color.Black;
            this.IBGrillaCliente.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGrillaCliente.Location = new System.Drawing.Point(0, 0);
            this.IBGrillaCliente.Margin = new System.Windows.Forms.Padding(0);
            this.IBGrillaCliente.Name = "IBGrillaCliente";
            this.IBGrillaCliente.Size = new System.Drawing.Size(180, 38);
            this.IBGrillaCliente.TabIndex = 2;
            this.IBGrillaCliente.Text = "Gestión de clientes";
            this.IBGrillaCliente.UseVisualStyleBackColor = false;
            this.IBGrillaCliente.Click += new System.EventHandler(this.IBGrillaCliente_Click);
            // 
            // ICclientes
            // 
            this.ICclientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICclientes.FlatAppearance.BorderSize = 0;
            this.ICclientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICclientes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICclientes.ForeColor = System.Drawing.Color.White;
            this.ICclientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.ICclientes.IconColor = System.Drawing.Color.White;
            this.ICclientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICclientes.IconSize = 40;
            this.ICclientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICclientes.Location = new System.Drawing.Point(0, 263);
            this.ICclientes.Name = "ICclientes";
            this.ICclientes.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICclientes.Size = new System.Drawing.Size(180, 52);
            this.ICclientes.TabIndex = 18;
            this.ICclientes.Text = "Clientes";
            this.ICclientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICclientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICclientes.UseVisualStyleBackColor = true;
            this.ICclientes.Click += new System.EventHandler(this.ICclientes_Click);
            // 
            // IconVentas
            // 
            this.IconVentas.Dock = System.Windows.Forms.DockStyle.Top;
            this.IconVentas.FlatAppearance.BorderSize = 0;
            this.IconVentas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IconVentas.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.IconVentas.ForeColor = System.Drawing.Color.White;
            this.IconVentas.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.IconVentas.IconColor = System.Drawing.Color.White;
            this.IconVentas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconVentas.IconSize = 40;
            this.IconVentas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconVentas.Location = new System.Drawing.Point(0, 211);
            this.IconVentas.Name = "IconVentas";
            this.IconVentas.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.IconVentas.Size = new System.Drawing.Size(180, 52);
            this.IconVentas.TabIndex = 17;
            this.IconVentas.Text = "Ventas";
            this.IconVentas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.IconVentas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IconVentas.UseVisualStyleBackColor = true;
            this.IconVentas.Click += new System.EventHandler(this.IconVentas_Click);
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.Controls.Add(this.IBProductosElim);
            this.subMenuProductos.Controls.Add(this.IBGrillaProductos);
            this.subMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProductos.Location = new System.Drawing.Point(0, 140);
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(180, 71);
            this.subMenuProductos.TabIndex = 16;
            // 
            // IBProductosElim
            // 
            this.IBProductosElim.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBProductosElim.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBProductosElim.FlatAppearance.BorderSize = 0;
            this.IBProductosElim.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.IBProductosElim.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBProductosElim.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBProductosElim.ForeColor = System.Drawing.Color.White;
            this.IBProductosElim.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBProductosElim.IconColor = System.Drawing.Color.Black;
            this.IBProductosElim.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBProductosElim.Location = new System.Drawing.Point(-3, 36);
            this.IBProductosElim.Margin = new System.Windows.Forms.Padding(0);
            this.IBProductosElim.Name = "IBProductosElim";
            this.IBProductosElim.Size = new System.Drawing.Size(183, 35);
            this.IBProductosElim.TabIndex = 1;
            this.IBProductosElim.Text = "Productos eliminados";
            this.IBProductosElim.UseVisualStyleBackColor = false;
            this.IBProductosElim.Click += new System.EventHandler(this.IBProductosElim_Click);
            // 
            // IBGrillaProductos
            // 
            this.IBGrillaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBGrillaProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.IBGrillaProductos.FlatAppearance.BorderSize = 0;
            this.IBGrillaProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.IBGrillaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IBGrillaProductos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IBGrillaProductos.ForeColor = System.Drawing.Color.White;
            this.IBGrillaProductos.IconChar = FontAwesome.Sharp.IconChar.None;
            this.IBGrillaProductos.IconColor = System.Drawing.Color.Black;
            this.IBGrillaProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IBGrillaProductos.Location = new System.Drawing.Point(-3, 0);
            this.IBGrillaProductos.Margin = new System.Windows.Forms.Padding(0);
            this.IBGrillaProductos.Name = "IBGrillaProductos";
            this.IBGrillaProductos.Size = new System.Drawing.Size(183, 36);
            this.IBGrillaProductos.TabIndex = 0;
            this.IBGrillaProductos.Text = "Gestión de productos";
            this.IBGrillaProductos.UseVisualStyleBackColor = false;
            this.IBGrillaProductos.Click += new System.EventHandler(this.IBGrillaProductos_Click);
            // 
            // ICProductos
            // 
            this.ICProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICProductos.FlatAppearance.BorderSize = 0;
            this.ICProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICProductos.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICProductos.ForeColor = System.Drawing.Color.White;
            this.ICProductos.IconChar = FontAwesome.Sharp.IconChar.ProductHunt;
            this.ICProductos.IconColor = System.Drawing.Color.White;
            this.ICProductos.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICProductos.IconSize = 40;
            this.ICProductos.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICProductos.Location = new System.Drawing.Point(0, 88);
            this.ICProductos.Name = "ICProductos";
            this.ICProductos.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICProductos.Size = new System.Drawing.Size(180, 52);
            this.ICProductos.TabIndex = 14;
            this.ICProductos.Text = "Productos";
            this.ICProductos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICProductos.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICProductos.UseVisualStyleBackColor = true;
            this.ICProductos.Click += new System.EventHandler(this.ICProductos_Click);
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
            this.ICsalir.Location = new System.Drawing.Point(0, 453);
            this.ICsalir.Name = "ICsalir";
            this.ICsalir.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.ICsalir.Size = new System.Drawing.Size(180, 53);
            this.ICsalir.TabIndex = 7;
            this.ICsalir.Text = "Salir";
            this.ICsalir.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICsalir.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICsalir.UseVisualStyleBackColor = true;
            this.ICsalir.Click += new System.EventHandler(this.ICsalir_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(180, 88);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox2.Image = global::SistemaVentaAkira.Properties.Resources.logoMenu;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(180, 88);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.lblemailtxt);
            this.panelTitulo.Controls.Add(this.lblroltxt);
            this.panelTitulo.Controls.Add(this.lblnombretxt);
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
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblemailtxt
            // 
            this.lblemailtxt.AutoSize = true;
            this.lblemailtxt.ForeColor = System.Drawing.Color.White;
            this.lblemailtxt.Location = new System.Drawing.Point(110, 25);
            this.lblemailtxt.Name = "lblemailtxt";
            this.lblemailtxt.Size = new System.Drawing.Size(0, 13);
            this.lblemailtxt.TabIndex = 21;
            // 
            // lblroltxt
            // 
            this.lblroltxt.AutoSize = true;
            this.lblroltxt.ForeColor = System.Drawing.Color.White;
            this.lblroltxt.Location = new System.Drawing.Point(110, 0);
            this.lblroltxt.Name = "lblroltxt";
            this.lblroltxt.Size = new System.Drawing.Size(0, 13);
            this.lblroltxt.TabIndex = 20;
            // 
            // lblnombretxt
            // 
            this.lblnombretxt.AutoSize = true;
            this.lblnombretxt.ForeColor = System.Drawing.Color.White;
            this.lblnombretxt.Location = new System.Drawing.Point(110, 12);
            this.lblnombretxt.Name = "lblnombretxt";
            this.lblnombretxt.Size = new System.Drawing.Size(0, 13);
            this.lblnombretxt.TabIndex = 19;
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
            this.panelFormularios.Location = new System.Drawing.Point(180, 47);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(686, 459);
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
            this.pictureBox1.Size = new System.Drawing.Size(686, 459);
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
            // Menu_Empleado
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 506);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Menu_Empleado";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Empleado";
            this.panelMenu.ResumeLayout(false);
            this.subMenuClientes.ResumeLayout(false);
            this.subMenuProductos.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
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
        public Label lblemailtxt;
        public Label lblroltxt;
        public Label lblnombretxt;
        private FontAwesome.Sharp.IconButton ICProductos;
        private Panel subMenuProductos;
        private FontAwesome.Sharp.IconButton IBProductosElim;
        private FontAwesome.Sharp.IconButton IBGrillaProductos;
        private FontAwesome.Sharp.IconButton IconVentas;
        private FontAwesome.Sharp.IconButton ICclientes;
        private Panel subMenuClientes;
        private FontAwesome.Sharp.IconButton IBClientesElim;
        private FontAwesome.Sharp.IconButton IBGrillaCliente;
        private FontAwesome.Sharp.IconButton IBInformeVentas;
    }
}