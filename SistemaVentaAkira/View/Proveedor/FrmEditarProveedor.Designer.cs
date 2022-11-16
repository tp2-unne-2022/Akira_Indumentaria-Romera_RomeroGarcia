using System.Windows.Forms;

namespace SistemaVentaAkira.View.Proveedor
{
    partial class FrmEditarProveedor
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
            System.Windows.Forms.Label lblEditarProveedor;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_IDprov = new System.Windows.Forms.TextBox();
            this.lblIdentificador = new System.Windows.Forms.Label();
            this.txt_NombreProv = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.tbCuil = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.btnModificarProveedor = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.Error_proveedor = new System.Windows.Forms.ErrorProvider(this.components);
            lblEditarProveedor = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarProveedor
            // 
            lblEditarProveedor.AutoSize = true;
            lblEditarProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblEditarProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblEditarProveedor.Location = new System.Drawing.Point(126, 11);
            lblEditarProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEditarProveedor.Name = "lblEditarProveedor";
            lblEditarProveedor.Size = new System.Drawing.Size(209, 23);
            lblEditarProveedor.TabIndex = 46;
            lblEditarProveedor.Text = "Modificar proveedor";
            lblEditarProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_IDprov);
            this.panel1.Controls.Add(this.lblIdentificador);
            this.panel1.Controls.Add(this.txt_NombreProv);
            this.panel1.Controls.Add(this.Lbl_nombre);
            this.panel1.Controls.Add(this.txtDireccion);
            this.panel1.Controls.Add(this.btnCancelarModificacion);
            this.panel1.Controls.Add(this.txtTelefono);
            this.panel1.Controls.Add(this.txtDescripcion);
            this.panel1.Controls.Add(this.txtRazonSocial);
            this.panel1.Controls.Add(this.tbCuil);
            this.panel1.Controls.Add(this.lblDireccion);
            this.panel1.Controls.Add(this.lblTelefono);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.LblRazonSocial);
            this.panel1.Controls.Add(this.lblCuil);
            this.panel1.Controls.Add(this.btnModificarProveedor);
            this.panel1.Controls.Add(lblEditarProveedor);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 344);
            this.panel1.TabIndex = 46;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // txt_IDprov
            // 
            this.txt_IDprov.Location = new System.Drawing.Point(179, 248);
            this.txt_IDprov.Name = "txt_IDprov";
            this.txt_IDprov.Size = new System.Drawing.Size(213, 20);
            this.txt_IDprov.TabIndex = 75;
            // 
            // lblIdentificador
            // 
            this.lblIdentificador.AutoSize = true;
            this.lblIdentificador.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblIdentificador.ForeColor = System.Drawing.Color.Black;
            this.lblIdentificador.Location = new System.Drawing.Point(69, 247);
            this.lblIdentificador.Name = "lblIdentificador";
            this.lblIdentificador.Size = new System.Drawing.Size(94, 19);
            this.lblIdentificador.TabIndex = 74;
            this.lblIdentificador.Text = "Identificador:";
            // 
            // txt_NombreProv
            // 
            this.txt_NombreProv.Location = new System.Drawing.Point(180, 87);
            this.txt_NombreProv.Name = "txt_NombreProv";
            this.txt_NombreProv.Size = new System.Drawing.Size(213, 20);
            this.txt_NombreProv.TabIndex = 73;
            this.txt_NombreProv.TextChanged += new System.EventHandler(this.txt_NombreProv_TextChanged);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Calibri", 12F);
            this.Lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_nombre.Location = new System.Drawing.Point(96, 86);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(64, 19);
            this.Lbl_nombre.TabIndex = 72;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(181, 218);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(213, 20);
            this.txtDireccion.TabIndex = 59;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelarModificacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(302, 293);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarModificacion.TabIndex = 58;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(181, 186);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 20);
            this.txtTelefono.TabIndex = 56;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(181, 150);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(213, 20);
            this.txtDescripcion.TabIndex = 55;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(181, 112);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(213, 20);
            this.txtRazonSocial.TabIndex = 54;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(181, 61);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(213, 20);
            this.tbCuil.TabIndex = 53;
            this.tbCuil.TextChanged += new System.EventHandler(this.tbCuil_TextChanged);
            this.tbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCuil_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(88, 217);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 19);
            this.lblDireccion.TabIndex = 52;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(93, 187);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblTelefono.TabIndex = 51;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(73, 149);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 50;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.LblRazonSocial.Location = new System.Drawing.Point(68, 111);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(94, 19);
            this.LblRazonSocial.TabIndex = 49;
            this.LblRazonSocial.Text = "Razón social:";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCuil.ForeColor = System.Drawing.Color.Black;
            this.lblCuil.Location = new System.Drawing.Point(97, 60);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(43, 19);
            this.lblCuil.TabIndex = 48;
            this.lblCuil.Text = "CUIL:";
            // 
            // btnModificarProveedor
            // 
            this.btnModificarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnModificarProveedor.FlatAppearance.BorderSize = 0;
            this.btnModificarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnModificarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProveedor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnModificarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnModificarProveedor.Location = new System.Drawing.Point(52, 293);
            this.btnModificarProveedor.Name = "btnModificarProveedor";
            this.btnModificarProveedor.Size = new System.Drawing.Size(146, 28);
            this.btnModificarProveedor.TabIndex = 47;
            this.btnModificarProveedor.Text = "Modificar proveedor";
            this.btnModificarProveedor.UseVisualStyleBackColor = false;
            this.btnModificarProveedor.Click += new System.EventHandler(this.btnModificarProveedor_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(463, 26);
            this.panelTitulo.TabIndex = 47;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.White;
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(430, 3);
            this.IcClose.Name = "IcClose";
            this.IcClose.Size = new System.Drawing.Size(22, 22);
            this.IcClose.TabIndex = 16;
            this.IcClose.TabStop = false;
            this.IcClose.Click += new System.EventHandler(this.IcClose_Click);
            // 
            // Error_proveedor
            // 
            this.Error_proveedor.ContainerControl = this;
            // 
            // FrmEditarProveedor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 374);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarProveedor";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_proveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnCancelarModificacion;
        private TextBox txtTelefono;
        private TextBox txtDescripcion;
        private TextBox txtRazonSocial;
        private TextBox tbCuil;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblDescripcion;
        private Label LblRazonSocial;
        private Label lblCuil;
        private Button btnModificarProveedor;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private TextBox txtDireccion;
        private ErrorProvider Error_proveedor;
        private TextBox txt_NombreProv;
        private Label Lbl_nombre;
        private TextBox txt_IDprov;
        private Label lblIdentificador;
    }
}