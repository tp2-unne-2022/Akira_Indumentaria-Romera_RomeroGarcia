namespace SistemaVentaAkira.View.Empleado
{
    partial class FrmVenta
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
            System.Windows.Forms.Label lblRealizarVenta;
            System.Windows.Forms.Label lblCliente;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle19 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle20 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnEliminar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.dgvListaVenta = new System.Windows.Forms.DataGridView();
            this.dv_CodProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_nombreProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_precioProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_cantidadProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dv_SubTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IcCobrar = new FontAwesome.Sharp.IconButton();
            this.IcCancelar = new FontAwesome.Sharp.IconButton();
            this.panel_cliente = new System.Windows.Forms.Panel();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.lblDNICliente = new System.Windows.Forms.Label();
            this.tbDNICliente = new System.Windows.Forms.TextBox();
            this.tbApellidoCliente = new System.Windows.Forms.TextBox();
            this.tbNombreCliente = new System.Windows.Forms.TextBox();
            this.lblApellidoCliente = new System.Windows.Forms.Label();
            this.lblNombreCliente = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.panel5 = new System.Windows.Forms.Panel();
            this.cbFormaPago = new System.Windows.Forms.ComboBox();
            this.LblFormaPago = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.LblCantidad = new System.Windows.Forms.Label();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.LblPrecio = new System.Windows.Forms.Label();
            this.txt_Stock = new System.Windows.Forms.TextBox();
            this.LblStock = new System.Windows.Forms.Label();
            this.IcBuscar = new FontAwesome.Sharp.IconPictureBox();
            this.txtProducto = new System.Windows.Forms.TextBox();
            this.lblProducto = new System.Windows.Forms.Label();
            this.LblTotal = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblEmpleado = new System.Windows.Forms.Label();
            this.LblFecha = new System.Windows.Forms.Label();
            this.pict_logo = new System.Windows.Forms.PictureBox();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            lblRealizarVenta = new System.Windows.Forms.Label();
            lblCliente = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenta)).BeginInit();
            this.panel_cliente.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcBuscar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_logo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRealizarVenta
            // 
            lblRealizarVenta.AutoSize = true;
            lblRealizarVenta.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblRealizarVenta.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblRealizarVenta.Location = new System.Drawing.Point(256, 11);
            lblRealizarVenta.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRealizarVenta.Name = "lblRealizarVenta";
            lblRealizarVenta.Size = new System.Drawing.Size(150, 23);
            lblRealizarVenta.TabIndex = 2;
            lblRealizarVenta.Text = "Realizar Venta";
            lblRealizarVenta.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblCliente.Location = new System.Drawing.Point(105, 0);
            lblCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new System.Drawing.Size(80, 23);
            lblCliente.TabIndex = 38;
            lblCliente.Text = "Cliente";
            lblCliente.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.BtnEliminar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.dgvListaVenta);
            this.panel1.Controls.Add(this.IcCobrar);
            this.panel1.Controls.Add(this.IcCancelar);
            this.panel1.Controls.Add(this.panel_cliente);
            this.panel1.Controls.Add(this.txtTotal);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.LblTotal);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.IcClose);
            this.panel1.Controls.Add(lblRealizarVenta);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(686, 448);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // BtnEliminar
            // 
            this.BtnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.BtnEliminar.FlatAppearance.BorderSize = 0;
            this.BtnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.BtnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnEliminar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.BtnEliminar.ForeColor = System.Drawing.Color.White;
            this.BtnEliminar.Location = new System.Drawing.Point(574, 279);
            this.BtnEliminar.Name = "BtnEliminar";
            this.BtnEliminar.Size = new System.Drawing.Size(87, 28);
            this.BtnEliminar.TabIndex = 32;
            this.BtnEliminar.Text = "Eliminar";
            this.BtnEliminar.UseVisualStyleBackColor = false;
            this.BtnEliminar.Click += new System.EventHandler(this.BtnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(574, 324);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(87, 28);
            this.btnModificar.TabIndex = 33;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // dgvListaVenta
            // 
            this.dgvListaVenta.AllowUserToAddRows = false;
            this.dgvListaVenta.AllowUserToDeleteRows = false;
            this.dgvListaVenta.AllowUserToResizeColumns = false;
            this.dgvListaVenta.AllowUserToResizeRows = false;
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaVenta.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle16;
            this.dgvListaVenta.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
            this.dgvListaVenta.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle17.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVenta.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvListaVenta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListaVenta.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dv_CodProd,
            this.dv_nombreProd,
            this.dv_precioProd,
            this.dv_cantidadProd,
            this.dv_SubTotal});
            dataGridViewCellStyle18.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle18.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle18.Font = new System.Drawing.Font("Segoe UI", 9F);
            dataGridViewCellStyle18.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle18.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle18.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle18.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVenta.DefaultCellStyle = dataGridViewCellStyle18;
            this.dgvListaVenta.EnableHeadersVisualStyles = false;
            this.dgvListaVenta.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.dgvListaVenta.Location = new System.Drawing.Point(24, 244);
            this.dgvListaVenta.MultiSelect = false;
            this.dgvListaVenta.Name = "dgvListaVenta";
            this.dgvListaVenta.ReadOnly = true;
            dataGridViewCellStyle19.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle19.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle19.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle19.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle19.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle19.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvListaVenta.RowHeadersDefaultCellStyle = dataGridViewCellStyle19;
            dataGridViewCellStyle20.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle20.Font = new System.Drawing.Font("Calibri", 11.25F);
            dataGridViewCellStyle20.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle20.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            dataGridViewCellStyle20.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaVenta.RowsDefaultCellStyle = dataGridViewCellStyle20;
            this.dgvListaVenta.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.dgvListaVenta.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            this.dgvListaVenta.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.dgvListaVenta.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.White;
            this.dgvListaVenta.RowTemplate.Height = 25;
            this.dgvListaVenta.RowTemplate.ReadOnly = true;
            this.dgvListaVenta.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvListaVenta.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvListaVenta.Size = new System.Drawing.Size(532, 127);
            this.dgvListaVenta.TabIndex = 63;
            // 
            // dv_CodProd
            // 
            this.dv_CodProd.HeaderText = "Código";
            this.dv_CodProd.Name = "dv_CodProd";
            this.dv_CodProd.ReadOnly = true;
            this.dv_CodProd.Width = 150;
            // 
            // dv_nombreProd
            // 
            this.dv_nombreProd.HeaderText = "Nombre";
            this.dv_nombreProd.Name = "dv_nombreProd";
            this.dv_nombreProd.ReadOnly = true;
            this.dv_nombreProd.Width = 160;
            // 
            // dv_precioProd
            // 
            this.dv_precioProd.HeaderText = "Precio ";
            this.dv_precioProd.Name = "dv_precioProd";
            this.dv_precioProd.ReadOnly = true;
            // 
            // dv_cantidadProd
            // 
            this.dv_cantidadProd.HeaderText = "Cantidad";
            this.dv_cantidadProd.Name = "dv_cantidadProd";
            this.dv_cantidadProd.ReadOnly = true;
            // 
            // dv_SubTotal
            // 
            this.dv_SubTotal.HeaderText = "Subtotal";
            this.dv_SubTotal.Name = "dv_SubTotal";
            this.dv_SubTotal.ReadOnly = true;
            this.dv_SubTotal.Width = 150;
            // 
            // IcCobrar
            // 
            this.IcCobrar.BackColor = System.Drawing.Color.White;
            this.IcCobrar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCobrar.FlatAppearance.BorderSize = 2;
            this.IcCobrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcCobrar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcCobrar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCobrar.IconChar = FontAwesome.Sharp.IconChar.BasketShopping;
            this.IcCobrar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCobrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcCobrar.IconSize = 20;
            this.IcCobrar.Location = new System.Drawing.Point(542, 388);
            this.IcCobrar.Name = "IcCobrar";
            this.IcCobrar.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.IcCobrar.Size = new System.Drawing.Size(119, 39);
            this.IcCobrar.TabIndex = 62;
            this.IcCobrar.Text = "Cobrar";
            this.IcCobrar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcCobrar.UseVisualStyleBackColor = false;
            this.IcCobrar.Click += new System.EventHandler(this.IcCobrar_Click);
            // 
            // IcCancelar
            // 
            this.IcCancelar.BackColor = System.Drawing.Color.White;
            this.IcCancelar.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCancelar.FlatAppearance.BorderSize = 2;
            this.IcCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IcCancelar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IcCancelar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCancelar.IconChar = FontAwesome.Sharp.IconChar.LeftLong;
            this.IcCancelar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcCancelar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcCancelar.IconSize = 20;
            this.IcCancelar.Location = new System.Drawing.Point(39, 409);
            this.IcCancelar.Name = "IcCancelar";
            this.IcCancelar.Padding = new System.Windows.Forms.Padding(9, 2, 17, 0);
            this.IcCancelar.Size = new System.Drawing.Size(127, 30);
            this.IcCancelar.TabIndex = 61;
            this.IcCancelar.Text = "Cancelar";
            this.IcCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.IcCancelar.UseVisualStyleBackColor = false;
            this.IcCancelar.Click += new System.EventHandler(this.IcCancelar_Click);
            // 
            // panel_cliente
            // 
            this.panel_cliente.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel_cliente.Controls.Add(this.btnRegistrar);
            this.panel_cliente.Controls.Add(this.btnBuscar);
            this.panel_cliente.Controls.Add(this.lblDNICliente);
            this.panel_cliente.Controls.Add(this.tbDNICliente);
            this.panel_cliente.Controls.Add(this.tbApellidoCliente);
            this.panel_cliente.Controls.Add(this.tbNombreCliente);
            this.panel_cliente.Controls.Add(this.lblApellidoCliente);
            this.panel_cliente.Controls.Add(this.lblNombreCliente);
            this.panel_cliente.Controls.Add(lblCliente);
            this.panel_cliente.Location = new System.Drawing.Point(23, 69);
            this.panel_cliente.Name = "panel_cliente";
            this.panel_cliente.Size = new System.Drawing.Size(298, 165);
            this.panel_cliente.TabIndex = 22;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnBuscar.FlatAppearance.BorderSize = 0;
            this.btnBuscar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnBuscar.ForeColor = System.Drawing.Color.White;
            this.btnBuscar.Location = new System.Drawing.Point(34, 132);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(87, 28);
            this.btnBuscar.TabIndex = 34;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = false;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // lblDNICliente
            // 
            this.lblDNICliente.AutoSize = true;
            this.lblDNICliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDNICliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.lblDNICliente.Location = new System.Drawing.Point(2, 101);
            this.lblDNICliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblDNICliente.Name = "lblDNICliente";
            this.lblDNICliente.Size = new System.Drawing.Size(49, 19);
            this.lblDNICliente.TabIndex = 59;
            this.lblDNICliente.Text = "D.N.I.:";
            // 
            // tbDNICliente
            // 
            this.tbDNICliente.Enabled = false;
            this.tbDNICliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbDNICliente.Location = new System.Drawing.Point(75, 104);
            this.tbDNICliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbDNICliente.Name = "tbDNICliente";
            this.tbDNICliente.Size = new System.Drawing.Size(207, 20);
            this.tbDNICliente.TabIndex = 58;
            // 
            // tbApellidoCliente
            // 
            this.tbApellidoCliente.Enabled = false;
            this.tbApellidoCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbApellidoCliente.Location = new System.Drawing.Point(75, 70);
            this.tbApellidoCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbApellidoCliente.Name = "tbApellidoCliente";
            this.tbApellidoCliente.Size = new System.Drawing.Size(207, 20);
            this.tbApellidoCliente.TabIndex = 57;
            // 
            // tbNombreCliente
            // 
            this.tbNombreCliente.Enabled = false;
            this.tbNombreCliente.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbNombreCliente.Location = new System.Drawing.Point(75, 38);
            this.tbNombreCliente.Margin = new System.Windows.Forms.Padding(2);
            this.tbNombreCliente.Name = "tbNombreCliente";
            this.tbNombreCliente.Size = new System.Drawing.Size(207, 20);
            this.tbNombreCliente.TabIndex = 56;
            // 
            // lblApellidoCliente
            // 
            this.lblApellidoCliente.AutoSize = true;
            this.lblApellidoCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblApellidoCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.lblApellidoCliente.Location = new System.Drawing.Point(2, 67);
            this.lblApellidoCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblApellidoCliente.Name = "lblApellidoCliente";
            this.lblApellidoCliente.Size = new System.Drawing.Size(66, 19);
            this.lblApellidoCliente.TabIndex = 55;
            this.lblApellidoCliente.Text = "Apellido:";
            // 
            // lblNombreCliente
            // 
            this.lblNombreCliente.AutoSize = true;
            this.lblNombreCliente.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreCliente.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.lblNombreCliente.Location = new System.Drawing.Point(2, 37);
            this.lblNombreCliente.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblNombreCliente.Name = "lblNombreCliente";
            this.lblNombreCliente.Size = new System.Drawing.Size(68, 19);
            this.lblNombreCliente.TabIndex = 54;
            this.lblNombreCliente.Text = "Nombre: ";
            // 
            // txtTotal
            // 
            this.txtTotal.Enabled = false;
            this.txtTotal.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(397, 394);
            this.txtTotal.Margin = new System.Windows.Forms.Padding(2);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(127, 27);
            this.txtTotal.TabIndex = 60;
            this.txtTotal.Text = "$";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(325, 69);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(336, 165);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.btnAgregar);
            this.panel6.Location = new System.Drawing.Point(3, 127);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(330, 36);
            this.panel6.TabIndex = 2;
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnAgregar.FlatAppearance.BorderSize = 0;
            this.btnAgregar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnAgregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgregar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnAgregar.ForeColor = System.Drawing.Color.White;
            this.btnAgregar.Location = new System.Drawing.Point(119, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(94, 28);
            this.btnAgregar.TabIndex = 31;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.cbFormaPago);
            this.panel5.Controls.Add(this.LblFormaPago);
            this.panel5.Location = new System.Drawing.Point(3, 90);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(330, 31);
            this.panel5.TabIndex = 1;
            // 
            // cbFormaPago
            // 
            this.cbFormaPago.FormattingEnabled = true;
            this.cbFormaPago.Location = new System.Drawing.Point(119, 5);
            this.cbFormaPago.Name = "cbFormaPago";
            this.cbFormaPago.Size = new System.Drawing.Size(147, 21);
            this.cbFormaPago.TabIndex = 30;
            // 
            // LblFormaPago
            // 
            this.LblFormaPago.AutoSize = true;
            this.LblFormaPago.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblFormaPago.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblFormaPago.Location = new System.Drawing.Point(8, 5);
            this.LblFormaPago.Name = "LblFormaPago";
            this.LblFormaPago.Size = new System.Drawing.Size(105, 19);
            this.LblFormaPago.TabIndex = 25;
            this.LblFormaPago.Text = "Forma de pago";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.txtCantidad);
            this.panel4.Controls.Add(this.LblCantidad);
            this.panel4.Controls.Add(this.txtPrecio);
            this.panel4.Controls.Add(this.LblPrecio);
            this.panel4.Controls.Add(this.txt_Stock);
            this.panel4.Controls.Add(this.LblStock);
            this.panel4.Controls.Add(this.IcBuscar);
            this.panel4.Controls.Add(this.txtProducto);
            this.panel4.Controls.Add(this.lblProducto);
            this.panel4.Location = new System.Drawing.Point(3, 3);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(330, 81);
            this.panel4.TabIndex = 0;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(237, 55);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(71, 20);
            this.txtCantidad.TabIndex = 31;
            this.txtCantidad.TextChanged += new System.EventHandler(this.txtCantidad_TextChanged);
            // 
            // LblCantidad
            // 
            this.LblCantidad.AutoSize = true;
            this.LblCantidad.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblCantidad.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblCantidad.Location = new System.Drawing.Point(233, 33);
            this.LblCantidad.Name = "LblCantidad";
            this.LblCantidad.Size = new System.Drawing.Size(67, 19);
            this.LblCantidad.TabIndex = 30;
            this.LblCantidad.Text = "Cantidad";
            // 
            // txtPrecio
            // 
            this.txtPrecio.Enabled = false;
            this.txtPrecio.Location = new System.Drawing.Point(121, 55);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(71, 20);
            this.txtPrecio.TabIndex = 29;
            // 
            // LblPrecio
            // 
            this.LblPrecio.AutoSize = true;
            this.LblPrecio.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblPrecio.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblPrecio.Location = new System.Drawing.Point(131, 33);
            this.LblPrecio.Name = "LblPrecio";
            this.LblPrecio.Size = new System.Drawing.Size(49, 19);
            this.LblPrecio.TabIndex = 28;
            this.LblPrecio.Text = "Precio";
            // 
            // txt_Stock
            // 
            this.txt_Stock.Enabled = false;
            this.txt_Stock.Location = new System.Drawing.Point(7, 57);
            this.txt_Stock.Name = "txt_Stock";
            this.txt_Stock.Size = new System.Drawing.Size(71, 20);
            this.txt_Stock.TabIndex = 27;
            // 
            // LblStock
            // 
            this.LblStock.AutoSize = true;
            this.LblStock.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblStock.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblStock.Location = new System.Drawing.Point(16, 33);
            this.LblStock.Name = "LblStock";
            this.LblStock.Size = new System.Drawing.Size(43, 19);
            this.LblStock.TabIndex = 26;
            this.LblStock.Text = "Stock";
            // 
            // IcBuscar
            // 
            this.IcBuscar.BackColor = System.Drawing.Color.White;
            this.IcBuscar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcBuscar.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.IcBuscar.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcBuscar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcBuscar.IconSize = 22;
            this.IcBuscar.Location = new System.Drawing.Point(298, 8);
            this.IcBuscar.Name = "IcBuscar";
            this.IcBuscar.Size = new System.Drawing.Size(22, 22);
            this.IcBuscar.TabIndex = 22;
            this.IcBuscar.TabStop = false;
            this.IcBuscar.Click += new System.EventHandler(this.IcBuscar_Click);
            // 
            // txtProducto
            // 
            this.txtProducto.Enabled = false;
            this.txtProducto.Location = new System.Drawing.Point(79, 8);
            this.txtProducto.Name = "txtProducto";
            this.txtProducto.Size = new System.Drawing.Size(213, 20);
            this.txtProducto.TabIndex = 25;
            // 
            // lblProducto
            // 
            this.lblProducto.AutoSize = true;
            this.lblProducto.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.lblProducto.Location = new System.Drawing.Point(3, 7);
            this.lblProducto.Name = "lblProducto";
            this.lblProducto.Size = new System.Drawing.Size(70, 19);
            this.lblProducto.TabIndex = 24;
            this.lblProducto.Text = "Producto:";
            // 
            // LblTotal
            // 
            this.LblTotal.AutoSize = true;
            this.LblTotal.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotal.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblTotal.Location = new System.Drawing.Point(328, 394);
            this.LblTotal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.LblTotal.Name = "LblTotal";
            this.LblTotal.Size = new System.Drawing.Size(53, 22);
            this.LblTotal.TabIndex = 60;
            this.LblTotal.Text = "Total";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.LblEmpleado);
            this.panel2.Controls.Add(this.LblFecha);
            this.panel2.Controls.Add(this.pict_logo);
            this.panel2.Location = new System.Drawing.Point(23, 40);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 24);
            this.panel2.TabIndex = 18;
            // 
            // LblEmpleado
            // 
            this.LblEmpleado.AutoSize = true;
            this.LblEmpleado.BackColor = System.Drawing.Color.White;
            this.LblEmpleado.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblEmpleado.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblEmpleado.Location = new System.Drawing.Point(328, 0);
            this.LblEmpleado.Name = "LblEmpleado";
            this.LblEmpleado.Size = new System.Drawing.Size(94, 21);
            this.LblEmpleado.TabIndex = 2;
            this.LblEmpleado.Text = "Empleado:";
            // 
            // LblFecha
            // 
            this.LblFecha.AutoSize = true;
            this.LblFecha.BackColor = System.Drawing.Color.White;
            this.LblFecha.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblFecha.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.LblFecha.Location = new System.Drawing.Point(106, 0);
            this.LblFecha.Name = "LblFecha";
            this.LblFecha.Size = new System.Drawing.Size(63, 21);
            this.LblFecha.TabIndex = 1;
            this.LblFecha.Text = "Fecha:";
            // 
            // pict_logo
            // 
            this.pict_logo.Dock = System.Windows.Forms.DockStyle.Left;
            this.pict_logo.Image = global::SistemaVentaAkira.Properties.Resources.logoParaElCentro;
            this.pict_logo.Location = new System.Drawing.Point(0, 0);
            this.pict_logo.Name = "pict_logo";
            this.pict_logo.Size = new System.Drawing.Size(100, 22);
            this.pict_logo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pict_logo.TabIndex = 0;
            this.pict_logo.TabStop = false;
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.White;
            this.IcClose.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(27, 12);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 17;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(185, 132);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(87, 28);
            this.btnRegistrar.TabIndex = 60;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // FrmVenta
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(686, 448);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmVenta";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FrmVenta_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListaVenta)).EndInit();
            this.panel_cliente.ResumeLayout(false);
            this.panel_cliente.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcBuscar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pict_logo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pict_logo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private System.Windows.Forms.Label LblFecha;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label LblEmpleado;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel4;
        public System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label LblCantidad;
        public System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.Label LblPrecio;
        public System.Windows.Forms.TextBox txt_Stock;
        private System.Windows.Forms.Label LblStock;
        private FontAwesome.Sharp.IconPictureBox IcBuscar;
        public System.Windows.Forms.TextBox txtProducto;
        private System.Windows.Forms.Label lblProducto;
        private System.Windows.Forms.Label LblFormaPago;
        private System.Windows.Forms.ComboBox cbFormaPago;
        private System.Windows.Forms.Panel panel_cliente;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button BtnEliminar;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label LblTotal;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.Label lblDNICliente;
        public System.Windows.Forms.TextBox tbDNICliente;
        public System.Windows.Forms.TextBox tbApellidoCliente;
        public System.Windows.Forms.TextBox tbNombreCliente;
        private System.Windows.Forms.Label lblApellidoCliente;
        private System.Windows.Forms.Label lblNombreCliente;
        private FontAwesome.Sharp.IconButton IcCobrar;
        private FontAwesome.Sharp.IconButton IcCancelar;
        private System.Windows.Forms.DataGridView dgvListaVenta;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_CodProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_nombreProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_precioProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_cantidadProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn dv_SubTotal;
        private System.Windows.Forms.Button btnRegistrar;
    }
}