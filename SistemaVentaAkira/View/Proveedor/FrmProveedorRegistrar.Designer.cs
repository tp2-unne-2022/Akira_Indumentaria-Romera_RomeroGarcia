using System.Windows.Forms;

namespace SistemaVentaAkira.View.Proveedor
{
    partial class FrmProveedorRegistrar
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
            System.Windows.Forms.Label LblRegistroProveedor;
            this.panel_Contenido = new System.Windows.Forms.Panel();
            this.txt_NombreProv = new System.Windows.Forms.TextBox();
            this.Lbl_nombre = new System.Windows.Forms.Label();
            this.txtDireccion = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.txtRazonSocial = new System.Windows.Forms.TextBox();
            this.tbCuil = new System.Windows.Forms.TextBox();
            this.lblDireccion = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.LblRazonSocial = new System.Windows.Forms.Label();
            this.lblCuil = new System.Windows.Forms.Label();
            this.btnCancelarRegistro = new System.Windows.Forms.Button();
            this.btnRegistrarProveedor = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.Error_proveedor = new System.Windows.Forms.ErrorProvider(this.components);
            LblRegistroProveedor = new System.Windows.Forms.Label();
            this.panel_Contenido.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_proveedor)).BeginInit();
            this.SuspendLayout();
            // 
            // LblRegistroProveedor
            // 
            LblRegistroProveedor.AutoSize = true;
            LblRegistroProveedor.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            LblRegistroProveedor.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            LblRegistroProveedor.Location = new System.Drawing.Point(129, 11);
            LblRegistroProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            LblRegistroProveedor.Name = "LblRegistroProveedor";
            LblRegistroProveedor.Size = new System.Drawing.Size(198, 23);
            LblRegistroProveedor.TabIndex = 16;
            LblRegistroProveedor.Text = "Registrar Proveedor";
            LblRegistroProveedor.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel_Contenido
            // 
            this.panel_Contenido.Controls.Add(this.txt_NombreProv);
            this.panel_Contenido.Controls.Add(this.Lbl_nombre);
            this.panel_Contenido.Controls.Add(this.txtDireccion);
            this.panel_Contenido.Controls.Add(this.txtTelefono);
            this.panel_Contenido.Controls.Add(this.txtDescripcion);
            this.panel_Contenido.Controls.Add(this.txtRazonSocial);
            this.panel_Contenido.Controls.Add(this.tbCuil);
            this.panel_Contenido.Controls.Add(this.lblDireccion);
            this.panel_Contenido.Controls.Add(this.lblTelefono);
            this.panel_Contenido.Controls.Add(this.lblDescripcion);
            this.panel_Contenido.Controls.Add(this.LblRazonSocial);
            this.panel_Contenido.Controls.Add(this.lblCuil);
            this.panel_Contenido.Controls.Add(this.btnCancelarRegistro);
            this.panel_Contenido.Controls.Add(this.btnRegistrarProveedor);
            this.panel_Contenido.Controls.Add(LblRegistroProveedor);
            this.panel_Contenido.Location = new System.Drawing.Point(0, 24);
            this.panel_Contenido.Name = "panel_Contenido";
            this.panel_Contenido.Size = new System.Drawing.Size(446, 346);
            this.panel_Contenido.TabIndex = 0;
            // 
            // txt_NombreProv
            // 
            this.txt_NombreProv.Location = new System.Drawing.Point(159, 86);
            this.txt_NombreProv.Name = "txt_NombreProv";
            this.txt_NombreProv.Size = new System.Drawing.Size(213, 20);
            this.txt_NombreProv.TabIndex = 71;
            this.txt_NombreProv.TextChanged += new System.EventHandler(this.txt_NombreProv_TextChanged);
            // 
            // Lbl_nombre
            // 
            this.Lbl_nombre.AutoSize = true;
            this.Lbl_nombre.Font = new System.Drawing.Font("Calibri", 12F);
            this.Lbl_nombre.ForeColor = System.Drawing.Color.Black;
            this.Lbl_nombre.Location = new System.Drawing.Point(75, 85);
            this.Lbl_nombre.Name = "Lbl_nombre";
            this.Lbl_nombre.Size = new System.Drawing.Size(64, 19);
            this.Lbl_nombre.TabIndex = 70;
            this.Lbl_nombre.Text = "Nombre:";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(160, 219);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(213, 20);
            this.txtDireccion.TabIndex = 69;
            this.txtDireccion.TextChanged += new System.EventHandler(this.txtDireccion_TextChanged);
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(160, 187);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(213, 20);
            this.txtTelefono.TabIndex = 68;
            this.txtTelefono.TextChanged += new System.EventHandler(this.txtTelefono_TextChanged);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(160, 151);
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(213, 20);
            this.txtDescripcion.TabIndex = 67;
            this.txtDescripcion.TextChanged += new System.EventHandler(this.txtDescripcion_TextChanged);
            // 
            // txtRazonSocial
            // 
            this.txtRazonSocial.Location = new System.Drawing.Point(160, 113);
            this.txtRazonSocial.Name = "txtRazonSocial";
            this.txtRazonSocial.Size = new System.Drawing.Size(213, 20);
            this.txtRazonSocial.TabIndex = 66;
            this.txtRazonSocial.TextChanged += new System.EventHandler(this.txtRazonSocial_TextChanged);
            // 
            // tbCuil
            // 
            this.tbCuil.Location = new System.Drawing.Point(160, 61);
            this.tbCuil.Name = "tbCuil";
            this.tbCuil.Size = new System.Drawing.Size(213, 20);
            this.tbCuil.TabIndex = 65;
            this.tbCuil.TextChanged += new System.EventHandler(this.tbCuil_TextChanged);
            this.tbCuil.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCuil_KeyPress);
            // 
            // lblDireccion
            // 
            this.lblDireccion.AutoSize = true;
            this.lblDireccion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDireccion.ForeColor = System.Drawing.Color.Black;
            this.lblDireccion.Location = new System.Drawing.Point(67, 218);
            this.lblDireccion.Name = "lblDireccion";
            this.lblDireccion.Size = new System.Drawing.Size(74, 19);
            this.lblDireccion.TabIndex = 64;
            this.lblDireccion.Text = "Dirección:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblTelefono.ForeColor = System.Drawing.Color.Black;
            this.lblTelefono.Location = new System.Drawing.Point(72, 188);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(69, 19);
            this.lblTelefono.TabIndex = 63;
            this.lblTelefono.Text = "Teléfono:";
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(52, 150);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 62;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // LblRazonSocial
            // 
            this.LblRazonSocial.AutoSize = true;
            this.LblRazonSocial.Font = new System.Drawing.Font("Calibri", 12F);
            this.LblRazonSocial.ForeColor = System.Drawing.Color.Black;
            this.LblRazonSocial.Location = new System.Drawing.Point(47, 112);
            this.LblRazonSocial.Name = "LblRazonSocial";
            this.LblRazonSocial.Size = new System.Drawing.Size(94, 19);
            this.LblRazonSocial.TabIndex = 61;
            this.LblRazonSocial.Text = "Razón social:";
            // 
            // lblCuil
            // 
            this.lblCuil.AutoSize = true;
            this.lblCuil.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblCuil.ForeColor = System.Drawing.Color.Black;
            this.lblCuil.Location = new System.Drawing.Point(76, 60);
            this.lblCuil.Name = "lblCuil";
            this.lblCuil.Size = new System.Drawing.Size(43, 19);
            this.lblCuil.TabIndex = 60;
            this.lblCuil.Text = "CUIL:";
            // 
            // btnCancelarRegistro
            // 
            this.btnCancelarRegistro.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelarRegistro.FlatAppearance.BorderSize = 0;
            this.btnCancelarRegistro.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelarRegistro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarRegistro.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelarRegistro.ForeColor = System.Drawing.Color.White;
            this.btnCancelarRegistro.Location = new System.Drawing.Point(295, 296);
            this.btnCancelarRegistro.Name = "btnCancelarRegistro";
            this.btnCancelarRegistro.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarRegistro.TabIndex = 32;
            this.btnCancelarRegistro.Text = "Cancelar";
            this.btnCancelarRegistro.UseVisualStyleBackColor = false;
            this.btnCancelarRegistro.Click += new System.EventHandler(this.btnCancelarRegistro_Click);
            // 
            // btnRegistrarProveedor
            // 
            this.btnRegistrarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnRegistrarProveedor.FlatAppearance.BorderSize = 0;
            this.btnRegistrarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnRegistrarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrarProveedor.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnRegistrarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnRegistrarProveedor.Location = new System.Drawing.Point(39, 296);
            this.btnRegistrarProveedor.Name = "btnRegistrarProveedor";
            this.btnRegistrarProveedor.Size = new System.Drawing.Size(140, 28);
            this.btnRegistrarProveedor.TabIndex = 17;
            this.btnRegistrarProveedor.Text = "Registrar proveedor";
            this.btnRegistrarProveedor.UseVisualStyleBackColor = false;
            this.btnRegistrarProveedor.Click += new System.EventHandler(this.btnRegistrarProveedor_Click);
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(446, 26);
            this.panelTitulo.TabIndex = 33;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown_1);
            // 
            // IcClose
            // 
            this.IcClose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.IcClose.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.IcClose.IconColor = System.Drawing.Color.White;
            this.IcClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IcClose.IconSize = 22;
            this.IcClose.Location = new System.Drawing.Point(413, 3);
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
            // FrmProveedorRegistrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 371);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel_Contenido);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmProveedorRegistrar";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel_Contenido.ResumeLayout(false);
            this.panel_Contenido.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_proveedor)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel_Contenido;
        private Button btnRegistrarProveedor;
        private Button btnCancelarRegistro;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private TextBox txtDireccion;
        private TextBox txtTelefono;
        private TextBox txtDescripcion;
        private TextBox txtRazonSocial;
        private TextBox tbCuil;
        private Label lblDireccion;
        private Label lblTelefono;
        private Label lblDescripcion;
        private Label LblRazonSocial;
        private Label lblCuil;
        private ErrorProvider Error_proveedor;
        private TextBox txt_NombreProv;
        private Label Lbl_nombre;
    }
}