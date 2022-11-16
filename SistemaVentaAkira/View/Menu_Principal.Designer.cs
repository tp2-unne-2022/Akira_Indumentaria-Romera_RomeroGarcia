using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class Principal
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
            this.subMenuReportes = new System.Windows.Forms.Panel();
            this.btnReportesAnuales = new System.Windows.Forms.Button();
            this.btnReportesMensuales = new System.Windows.Forms.Button();
            this.btnReportesGeneral = new System.Windows.Forms.Button();
            this.ICreportes = new FontAwesome.Sharp.IconButton();
            this.subMenuProveedor = new System.Windows.Forms.Panel();
            this.btnProveedoresEliminados = new System.Windows.Forms.Button();
            this.btnGrillaProveedores = new System.Windows.Forms.Button();
            this.ICproveedores = new FontAwesome.Sharp.IconButton();
            this.subMenuCategoria = new System.Windows.Forms.Panel();
            this.btnCategoriasEliminadas = new System.Windows.Forms.Button();
            this.btnGrillaCategorias = new System.Windows.Forms.Button();
            this.ICcategorias = new FontAwesome.Sharp.IconButton();
            this.subMenuProductos = new System.Windows.Forms.Panel();
            this.btnProductosEliminados = new System.Windows.Forms.Button();
            this.btnGrillaProductos = new System.Windows.Forms.Button();
            this.ICProductos = new FontAwesome.Sharp.IconButton();
            this.ICsalir = new FontAwesome.Sharp.IconButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.lblemailtxt = new System.Windows.Forms.Label();
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
            this.subMenuReportes.SuspendLayout();
            this.subMenuProveedor.SuspendLayout();
            this.subMenuCategoria.SuspendLayout();
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
            this.panelMenu.Controls.Add(this.subMenuReportes);
            this.panelMenu.Controls.Add(this.ICreportes);
            this.panelMenu.Controls.Add(this.subMenuProveedor);
            this.panelMenu.Controls.Add(this.ICproveedores);
            this.panelMenu.Controls.Add(this.subMenuCategoria);
            this.panelMenu.Controls.Add(this.ICcategorias);
            this.panelMenu.Controls.Add(this.subMenuProductos);
            this.panelMenu.Controls.Add(this.ICProductos);
            this.panelMenu.Controls.Add(this.ICsalir);
            this.panelMenu.Controls.Add(this.panel2);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(180, 523);
            this.panelMenu.TabIndex = 0;
            // 
            // subMenuReportes
            // 
            this.subMenuReportes.Controls.Add(this.btnReportesAnuales);
            this.subMenuReportes.Controls.Add(this.btnReportesMensuales);
            this.subMenuReportes.Controls.Add(this.btnReportesGeneral);
            this.subMenuReportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuReportes.Location = new System.Drawing.Point(0, 488);
            this.subMenuReportes.Name = "subMenuReportes";
            this.subMenuReportes.Size = new System.Drawing.Size(180, 101);
            this.subMenuReportes.TabIndex = 34;
            // 
            // btnReportesAnuales
            // 
            this.btnReportesAnuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnReportesAnuales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesAnuales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnReportesAnuales.FlatAppearance.BorderSize = 0;
            this.btnReportesAnuales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnReportesAnuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesAnuales.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesAnuales.ForeColor = System.Drawing.Color.White;
            this.btnReportesAnuales.Location = new System.Drawing.Point(0, 68);
            this.btnReportesAnuales.Name = "btnReportesAnuales";
            this.btnReportesAnuales.Size = new System.Drawing.Size(180, 33);
            this.btnReportesAnuales.TabIndex = 13;
            this.btnReportesAnuales.Text = "Empleado Anual";
            this.btnReportesAnuales.UseVisualStyleBackColor = false;
            this.btnReportesAnuales.Click += new System.EventHandler(this.btnReportesAnuales_Click);
            // 
            // btnReportesMensuales
            // 
            this.btnReportesMensuales.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnReportesMensuales.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesMensuales.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnReportesMensuales.FlatAppearance.BorderSize = 0;
            this.btnReportesMensuales.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnReportesMensuales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesMensuales.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesMensuales.ForeColor = System.Drawing.Color.White;
            this.btnReportesMensuales.Location = new System.Drawing.Point(0, 34);
            this.btnReportesMensuales.Name = "btnReportesMensuales";
            this.btnReportesMensuales.Size = new System.Drawing.Size(180, 34);
            this.btnReportesMensuales.TabIndex = 12;
            this.btnReportesMensuales.Text = "Empleado mensual";
            this.btnReportesMensuales.UseVisualStyleBackColor = false;
            this.btnReportesMensuales.Click += new System.EventHandler(this.btnReportesMensuales_Click);
            // 
            // btnReportesGeneral
            // 
            this.btnReportesGeneral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnReportesGeneral.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReportesGeneral.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnReportesGeneral.FlatAppearance.BorderSize = 0;
            this.btnReportesGeneral.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnReportesGeneral.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReportesGeneral.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportesGeneral.ForeColor = System.Drawing.Color.White;
            this.btnReportesGeneral.Location = new System.Drawing.Point(0, 0);
            this.btnReportesGeneral.Margin = new System.Windows.Forms.Padding(5);
            this.btnReportesGeneral.Name = "btnReportesGeneral";
            this.btnReportesGeneral.Size = new System.Drawing.Size(180, 34);
            this.btnReportesGeneral.TabIndex = 0;
            this.btnReportesGeneral.Text = "Reportes generales";
            this.btnReportesGeneral.UseVisualStyleBackColor = false;
            this.btnReportesGeneral.Click += new System.EventHandler(this.btnReportesGeneral_Click);
            // 
            // ICreportes
            // 
            this.ICreportes.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICreportes.FlatAppearance.BorderSize = 0;
            this.ICreportes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICreportes.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICreportes.ForeColor = System.Drawing.Color.White;
            this.ICreportes.IconChar = FontAwesome.Sharp.IconChar.PieChart;
            this.ICreportes.IconColor = System.Drawing.Color.White;
            this.ICreportes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICreportes.IconSize = 40;
            this.ICreportes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICreportes.Location = new System.Drawing.Point(0, 440);
            this.ICreportes.Name = "ICreportes";
            this.ICreportes.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICreportes.Size = new System.Drawing.Size(180, 48);
            this.ICreportes.TabIndex = 31;
            this.ICreportes.Text = "Reportes";
            this.ICreportes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICreportes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICreportes.UseVisualStyleBackColor = true;
            this.ICreportes.Click += new System.EventHandler(this.ICreportes_Click);
            // 
            // subMenuProveedor
            // 
            this.subMenuProveedor.Controls.Add(this.btnProveedoresEliminados);
            this.subMenuProveedor.Controls.Add(this.btnGrillaProveedores);
            this.subMenuProveedor.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProveedor.Location = new System.Drawing.Point(0, 370);
            this.subMenuProveedor.Name = "subMenuProveedor";
            this.subMenuProveedor.Size = new System.Drawing.Size(180, 70);
            this.subMenuProveedor.TabIndex = 29;
            // 
            // btnProveedoresEliminados
            // 
            this.btnProveedoresEliminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnProveedoresEliminados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProveedoresEliminados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnProveedoresEliminados.FlatAppearance.BorderSize = 0;
            this.btnProveedoresEliminados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnProveedoresEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProveedoresEliminados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProveedoresEliminados.ForeColor = System.Drawing.Color.White;
            this.btnProveedoresEliminados.Location = new System.Drawing.Point(0, 34);
            this.btnProveedoresEliminados.Name = "btnProveedoresEliminados";
            this.btnProveedoresEliminados.Size = new System.Drawing.Size(180, 36);
            this.btnProveedoresEliminados.TabIndex = 12;
            this.btnProveedoresEliminados.Text = "Ver proveedores eliminados";
            this.btnProveedoresEliminados.UseVisualStyleBackColor = false;
            this.btnProveedoresEliminados.Click += new System.EventHandler(this.btnProveedoresEliminados_Click);
            // 
            // btnGrillaProveedores
            // 
            this.btnGrillaProveedores.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaProveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrillaProveedores.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaProveedores.FlatAppearance.BorderSize = 0;
            this.btnGrillaProveedores.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnGrillaProveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrillaProveedores.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrillaProveedores.ForeColor = System.Drawing.Color.White;
            this.btnGrillaProveedores.Location = new System.Drawing.Point(0, 0);
            this.btnGrillaProveedores.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrillaProveedores.Name = "btnGrillaProveedores";
            this.btnGrillaProveedores.Size = new System.Drawing.Size(180, 34);
            this.btnGrillaProveedores.TabIndex = 0;
            this.btnGrillaProveedores.Text = "Gestión de proveedor";
            this.btnGrillaProveedores.UseVisualStyleBackColor = false;
            this.btnGrillaProveedores.Click += new System.EventHandler(this.btnGrillaProveedores_Click);
            // 
            // ICproveedores
            // 
            this.ICproveedores.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICproveedores.FlatAppearance.BorderSize = 0;
            this.ICproveedores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICproveedores.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICproveedores.ForeColor = System.Drawing.Color.White;
            this.ICproveedores.IconChar = FontAwesome.Sharp.IconChar.TruckField;
            this.ICproveedores.IconColor = System.Drawing.Color.White;
            this.ICproveedores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICproveedores.IconSize = 40;
            this.ICproveedores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICproveedores.Location = new System.Drawing.Point(0, 322);
            this.ICproveedores.Name = "ICproveedores";
            this.ICproveedores.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICproveedores.Size = new System.Drawing.Size(180, 48);
            this.ICproveedores.TabIndex = 28;
            this.ICproveedores.Text = "Proveedores";
            this.ICproveedores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICproveedores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICproveedores.UseVisualStyleBackColor = true;
            this.ICproveedores.Click += new System.EventHandler(this.ICproveedores_Click);
            // 
            // subMenuCategoria
            // 
            this.subMenuCategoria.Controls.Add(this.btnCategoriasEliminadas);
            this.subMenuCategoria.Controls.Add(this.btnGrillaCategorias);
            this.subMenuCategoria.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuCategoria.Location = new System.Drawing.Point(0, 252);
            this.subMenuCategoria.Name = "subMenuCategoria";
            this.subMenuCategoria.Size = new System.Drawing.Size(180, 70);
            this.subMenuCategoria.TabIndex = 27;
            // 
            // btnCategoriasEliminadas
            // 
            this.btnCategoriasEliminadas.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCategoriasEliminadas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCategoriasEliminadas.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCategoriasEliminadas.FlatAppearance.BorderSize = 0;
            this.btnCategoriasEliminadas.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnCategoriasEliminadas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCategoriasEliminadas.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCategoriasEliminadas.ForeColor = System.Drawing.Color.White;
            this.btnCategoriasEliminadas.Location = new System.Drawing.Point(0, 34);
            this.btnCategoriasEliminadas.Name = "btnCategoriasEliminadas";
            this.btnCategoriasEliminadas.Size = new System.Drawing.Size(180, 36);
            this.btnCategoriasEliminadas.TabIndex = 12;
            this.btnCategoriasEliminadas.Text = "Ver categorias eliminadas";
            this.btnCategoriasEliminadas.UseVisualStyleBackColor = false;
            this.btnCategoriasEliminadas.Click += new System.EventHandler(this.btnCategoriasEliminadas_Click);
            // 
            // btnGrillaCategorias
            // 
            this.btnGrillaCategorias.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaCategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrillaCategorias.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaCategorias.FlatAppearance.BorderSize = 0;
            this.btnGrillaCategorias.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnGrillaCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrillaCategorias.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrillaCategorias.ForeColor = System.Drawing.Color.White;
            this.btnGrillaCategorias.Location = new System.Drawing.Point(0, 0);
            this.btnGrillaCategorias.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrillaCategorias.Name = "btnGrillaCategorias";
            this.btnGrillaCategorias.Size = new System.Drawing.Size(180, 34);
            this.btnGrillaCategorias.TabIndex = 0;
            this.btnGrillaCategorias.Text = "Gestión de categorias";
            this.btnGrillaCategorias.UseVisualStyleBackColor = false;
            this.btnGrillaCategorias.Click += new System.EventHandler(this.btnGrillaCategorias_Click);
            // 
            // ICcategorias
            // 
            this.ICcategorias.Dock = System.Windows.Forms.DockStyle.Top;
            this.ICcategorias.FlatAppearance.BorderSize = 0;
            this.ICcategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ICcategorias.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.ICcategorias.ForeColor = System.Drawing.Color.White;
            this.ICcategorias.IconChar = FontAwesome.Sharp.IconChar.MoneyBill;
            this.ICcategorias.IconColor = System.Drawing.Color.White;
            this.ICcategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.ICcategorias.IconSize = 40;
            this.ICcategorias.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICcategorias.Location = new System.Drawing.Point(0, 205);
            this.ICcategorias.Name = "ICcategorias";
            this.ICcategorias.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.ICcategorias.Size = new System.Drawing.Size(180, 47);
            this.ICcategorias.TabIndex = 24;
            this.ICcategorias.Text = "Categoría";
            this.ICcategorias.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ICcategorias.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ICcategorias.UseVisualStyleBackColor = true;
            this.ICcategorias.Click += new System.EventHandler(this.ICcategorias_Click);
            // 
            // subMenuProductos
            // 
            this.subMenuProductos.Controls.Add(this.btnProductosEliminados);
            this.subMenuProductos.Controls.Add(this.btnGrillaProductos);
            this.subMenuProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.subMenuProductos.Location = new System.Drawing.Point(0, 135);
            this.subMenuProductos.Name = "subMenuProductos";
            this.subMenuProductos.Size = new System.Drawing.Size(180, 70);
            this.subMenuProductos.TabIndex = 23;
            // 
            // btnProductosEliminados
            // 
            this.btnProductosEliminados.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnProductosEliminados.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnProductosEliminados.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnProductosEliminados.FlatAppearance.BorderSize = 0;
            this.btnProductosEliminados.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnProductosEliminados.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductosEliminados.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProductosEliminados.ForeColor = System.Drawing.Color.White;
            this.btnProductosEliminados.Location = new System.Drawing.Point(0, 34);
            this.btnProductosEliminados.Name = "btnProductosEliminados";
            this.btnProductosEliminados.Size = new System.Drawing.Size(180, 36);
            this.btnProductosEliminados.TabIndex = 12;
            this.btnProductosEliminados.Text = "Ver productos eliminados";
            this.btnProductosEliminados.UseVisualStyleBackColor = false;
            this.btnProductosEliminados.Click += new System.EventHandler(this.btnProductosEliminados_Click);
            // 
            // btnGrillaProductos
            // 
            this.btnGrillaProductos.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaProductos.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGrillaProductos.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnGrillaProductos.FlatAppearance.BorderSize = 0;
            this.btnGrillaProductos.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(162)))), ((int)(((byte)(117)))));
            this.btnGrillaProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGrillaProductos.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrillaProductos.ForeColor = System.Drawing.Color.White;
            this.btnGrillaProductos.Location = new System.Drawing.Point(0, 0);
            this.btnGrillaProductos.Margin = new System.Windows.Forms.Padding(5);
            this.btnGrillaProductos.Name = "btnGrillaProductos";
            this.btnGrillaProductos.Size = new System.Drawing.Size(180, 34);
            this.btnGrillaProductos.TabIndex = 0;
            this.btnGrillaProductos.Text = "Gestión de productos";
            this.btnGrillaProductos.UseVisualStyleBackColor = false;
            this.btnGrillaProductos.Click += new System.EventHandler(this.btnGrillaProductos_Click);
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
            this.ICProductos.Size = new System.Drawing.Size(180, 47);
            this.ICProductos.TabIndex = 22;
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
            this.ICsalir.Location = new System.Drawing.Point(0, 474);
            this.ICsalir.Name = "ICsalir";
            this.ICsalir.Padding = new System.Windows.Forms.Padding(9, 0, 17, 0);
            this.ICsalir.Size = new System.Drawing.Size(180, 49);
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
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
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
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // lblemailtxt
            // 
            this.lblemailtxt.AutoSize = true;
            this.lblemailtxt.ForeColor = System.Drawing.Color.White;
            this.lblemailtxt.Location = new System.Drawing.Point(115, 25);
            this.lblemailtxt.Name = "lblemailtxt";
            this.lblemailtxt.Size = new System.Drawing.Size(0, 13);
            this.lblemailtxt.TabIndex = 21;
            // 
            // lblnombretxt
            // 
            this.lblnombretxt.AutoSize = true;
            this.lblnombretxt.ForeColor = System.Drawing.Color.White;
            this.lblnombretxt.Location = new System.Drawing.Point(115, 12);
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
            this.panelFormularios.Location = new System.Drawing.Point(180, 43);
            this.panelFormularios.Name = "panelFormularios";
            this.panelFormularios.Size = new System.Drawing.Size(688, 479);
            this.panelFormularios.TabIndex = 6;
            // 
            // LblFechaAct
            // 
            this.LblFechaAct.AutoSize = true;
            this.LblFechaAct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblFechaAct.Location = new System.Drawing.Point(210, 360);
            this.LblFechaAct.Name = "LblFechaAct";
            this.LblFechaAct.Size = new System.Drawing.Size(59, 21);
            this.LblFechaAct.TabIndex = 5;
            this.LblFechaAct.Text = "Fecha";
            // 
            // LblHoraAct
            // 
            this.LblHoraAct.AutoSize = true;
            this.LblHoraAct.Font = new System.Drawing.Font("Century Gothic", 12F);
            this.LblHoraAct.Location = new System.Drawing.Point(310, 403);
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
            this.pictureBox1.Size = new System.Drawing.Size(688, 479);
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
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(868, 523);
            this.Controls.Add(this.panelFormularios);
            this.Controls.Add(this.LblFecha);
            this.Controls.Add(this.LblHora);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Principal";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Administrador";
            this.panelMenu.ResumeLayout(false);
            this.subMenuReportes.ResumeLayout(false);
            this.subMenuProveedor.ResumeLayout(false);
            this.subMenuCategoria.ResumeLayout(false);
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
        public Label lblnombretxt;
        public Label lblroltxt;
        private FontAwesome.Sharp.IconButton ICProductos;
        private Panel subMenuProductos;
        private Button btnProductosEliminados;
        private Button btnGrillaProductos;
        private FontAwesome.Sharp.IconButton ICcategorias;
        private Panel subMenuCategoria;
        private Button btnCategoriasEliminadas;
        private Button btnGrillaCategorias;
        private FontAwesome.Sharp.IconButton ICproveedores;
        private Panel subMenuProveedor;
        private Button btnProveedoresEliminados;
        private Button btnGrillaProveedores;
        private FontAwesome.Sharp.IconButton ICreportes;
        private Panel subMenuReportes;
        private Button btnReportesMensuales;
        private Button btnReportesGeneral;
        private Button btnReportesAnuales;
    }
}