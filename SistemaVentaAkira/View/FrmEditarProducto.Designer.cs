using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class FrmEditarProducto
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
            System.Windows.Forms.Label lblEditarProducto;
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbProveedor = new System.Windows.Forms.ComboBox();
            this.lblProveedor = new System.Windows.Forms.Label();
            this.txtStockMinimo = new System.Windows.Forms.TextBox();
            this.lblStockMinimo = new System.Windows.Forms.Label();
            this.btnCancelarModificacion = new System.Windows.Forms.Button();
            this.cbCategoríaProducto = new System.Windows.Forms.ComboBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtPrecioVenta = new System.Windows.Forms.TextBox();
            this.txtPrecioCompra = new System.Windows.Forms.TextBox();
            this.tbNombreProducto = new System.Windows.Forms.TextBox();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblPrecioVenta = new System.Windows.Forms.Label();
            this.lblPrecioCompra = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNombreProducto = new System.Windows.Forms.Label();
            this.btnModificarProducto = new System.Windows.Forms.Button();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.Error_producto = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbIDProd = new System.Windows.Forms.TextBox();
            lblEditarProducto = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_producto)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarProducto
            // 
            lblEditarProducto.AutoSize = true;
            lblEditarProducto.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblEditarProducto.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblEditarProducto.Location = new System.Drawing.Point(152, 8);
            lblEditarProducto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEditarProducto.Name = "lblEditarProducto";
            lblEditarProducto.Size = new System.Drawing.Size(197, 23);
            lblEditarProducto.TabIndex = 46;
            lblEditarProducto.Text = "Modificar producto";
            lblEditarProducto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbIDProd);
            this.panel1.Controls.Add(this.cbProveedor);
            this.panel1.Controls.Add(this.lblProveedor);
            this.panel1.Controls.Add(this.txtStockMinimo);
            this.panel1.Controls.Add(this.lblStockMinimo);
            this.panel1.Controls.Add(this.btnCancelarModificacion);
            this.panel1.Controls.Add(this.cbCategoríaProducto);
            this.panel1.Controls.Add(this.txtStock);
            this.panel1.Controls.Add(this.txtPrecioVenta);
            this.panel1.Controls.Add(this.txtPrecioCompra);
            this.panel1.Controls.Add(this.tbNombreProducto);
            this.panel1.Controls.Add(this.lblStock);
            this.panel1.Controls.Add(this.lblPrecioVenta);
            this.panel1.Controls.Add(this.lblPrecioCompra);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblNombreProducto);
            this.panel1.Controls.Add(this.btnModificarProducto);
            this.panel1.Controls.Add(lblEditarProducto);
            this.panel1.Location = new System.Drawing.Point(0, 31);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(463, 411);
            this.panel1.TabIndex = 46;
            // 
            // cbProveedor
            // 
            this.cbProveedor.FormattingEnabled = true;
            this.cbProveedor.Location = new System.Drawing.Point(202, 104);
            this.cbProveedor.Name = "cbProveedor";
            this.cbProveedor.Size = new System.Drawing.Size(147, 21);
            this.cbProveedor.TabIndex = 62;
            this.cbProveedor.TextChanged += new System.EventHandler(this.cbProveedor_TextChanged);
            // 
            // lblProveedor
            // 
            this.lblProveedor.AutoSize = true;
            this.lblProveedor.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblProveedor.ForeColor = System.Drawing.Color.Black;
            this.lblProveedor.Location = new System.Drawing.Point(109, 106);
            this.lblProveedor.Name = "lblProveedor";
            this.lblProveedor.Size = new System.Drawing.Size(78, 19);
            this.lblProveedor.TabIndex = 61;
            this.lblProveedor.Text = "Proveedor:";
            // 
            // txtStockMinimo
            // 
            this.txtStockMinimo.Location = new System.Drawing.Point(202, 304);
            this.txtStockMinimo.Name = "txtStockMinimo";
            this.txtStockMinimo.Size = new System.Drawing.Size(213, 20);
            this.txtStockMinimo.TabIndex = 60;
            this.txtStockMinimo.TextChanged += new System.EventHandler(this.txtStockMinimo_TextChanged);
            this.txtStockMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStockMinimo_KeyPress);
            // 
            // lblStockMinimo
            // 
            this.lblStockMinimo.AutoSize = true;
            this.lblStockMinimo.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblStockMinimo.ForeColor = System.Drawing.Color.Black;
            this.lblStockMinimo.Location = new System.Drawing.Point(85, 303);
            this.lblStockMinimo.Name = "lblStockMinimo";
            this.lblStockMinimo.Size = new System.Drawing.Size(99, 19);
            this.lblStockMinimo.TabIndex = 59;
            this.lblStockMinimo.Text = "Stock mínimo:";
            // 
            // btnCancelarModificacion
            // 
            this.btnCancelarModificacion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelarModificacion.FlatAppearance.BorderSize = 0;
            this.btnCancelarModificacion.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelarModificacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelarModificacion.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelarModificacion.ForeColor = System.Drawing.Color.White;
            this.btnCancelarModificacion.Location = new System.Drawing.Point(302, 344);
            this.btnCancelarModificacion.Name = "btnCancelarModificacion";
            this.btnCancelarModificacion.Size = new System.Drawing.Size(100, 28);
            this.btnCancelarModificacion.TabIndex = 58;
            this.btnCancelarModificacion.Text = "Cancelar";
            this.btnCancelarModificacion.UseVisualStyleBackColor = false;
            this.btnCancelarModificacion.Click += new System.EventHandler(this.btnCancelarModificacion_Click);
            // 
            // cbCategoríaProducto
            // 
            this.cbCategoríaProducto.FormattingEnabled = true;
            this.cbCategoríaProducto.Location = new System.Drawing.Point(202, 143);
            this.cbCategoríaProducto.Name = "cbCategoríaProducto";
            this.cbCategoríaProducto.Size = new System.Drawing.Size(147, 21);
            this.cbCategoríaProducto.TabIndex = 57;
            this.cbCategoríaProducto.TextChanged += new System.EventHandler(this.cbCategoríaProducto_TextChanged);
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(202, 271);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(213, 20);
            this.txtStock.TabIndex = 56;
            this.txtStock.TextChanged += new System.EventHandler(this.txtStock_TextChanged);
            this.txtStock.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtStock_KeyPress);
            // 
            // txtPrecioVenta
            // 
            this.txtPrecioVenta.Location = new System.Drawing.Point(202, 227);
            this.txtPrecioVenta.Name = "txtPrecioVenta";
            this.txtPrecioVenta.Size = new System.Drawing.Size(213, 20);
            this.txtPrecioVenta.TabIndex = 55;
            this.txtPrecioVenta.TextChanged += new System.EventHandler(this.txtPrecioVenta_TextChanged);
            // 
            // txtPrecioCompra
            // 
            this.txtPrecioCompra.Location = new System.Drawing.Point(202, 180);
            this.txtPrecioCompra.Name = "txtPrecioCompra";
            this.txtPrecioCompra.Size = new System.Drawing.Size(213, 20);
            this.txtPrecioCompra.TabIndex = 54;
            this.txtPrecioCompra.TextChanged += new System.EventHandler(this.txtPrecioCompra_TextChanged);
            // 
            // tbNombreProducto
            // 
            this.tbNombreProducto.Location = new System.Drawing.Point(204, 69);
            this.tbNombreProducto.Name = "tbNombreProducto";
            this.tbNombreProducto.Size = new System.Drawing.Size(213, 20);
            this.tbNombreProducto.TabIndex = 53;
            this.tbNombreProducto.TextChanged += new System.EventHandler(this.tbNombreProducto_TextChanged);
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblStock.ForeColor = System.Drawing.Color.Black;
            this.lblStock.Location = new System.Drawing.Point(137, 270);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(47, 19);
            this.lblStock.TabIndex = 52;
            this.lblStock.Text = "Stock:";
            // 
            // lblPrecioVenta
            // 
            this.lblPrecioVenta.AutoSize = true;
            this.lblPrecioVenta.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPrecioVenta.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioVenta.Location = new System.Drawing.Point(74, 226);
            this.lblPrecioVenta.Name = "lblPrecioVenta";
            this.lblPrecioVenta.Size = new System.Drawing.Size(113, 19);
            this.lblPrecioVenta.TabIndex = 51;
            this.lblPrecioVenta.Text = "Precio de venta:";
            // 
            // lblPrecioCompra
            // 
            this.lblPrecioCompra.AutoSize = true;
            this.lblPrecioCompra.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblPrecioCompra.ForeColor = System.Drawing.Color.Black;
            this.lblPrecioCompra.Location = new System.Drawing.Point(63, 181);
            this.lblPrecioCompra.Name = "lblPrecioCompra";
            this.lblPrecioCompra.Size = new System.Drawing.Size(125, 19);
            this.lblPrecioCompra.TabIndex = 50;
            this.lblPrecioCompra.Text = "Precio de compra:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(108, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 19);
            this.label3.TabIndex = 49;
            this.label3.Text = "Categoría:";
            // 
            // lblNombreProducto
            // 
            this.lblNombreProducto.AutoSize = true;
            this.lblNombreProducto.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreProducto.ForeColor = System.Drawing.Color.Black;
            this.lblNombreProducto.Location = new System.Drawing.Point(45, 69);
            this.lblNombreProducto.Name = "lblNombreProducto";
            this.lblNombreProducto.Size = new System.Drawing.Size(153, 19);
            this.lblNombreProducto.TabIndex = 48;
            this.lblNombreProducto.Text = "Nombre del producto: ";
            // 
            // btnModificarProducto
            // 
            this.btnModificarProducto.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnModificarProducto.FlatAppearance.BorderSize = 0;
            this.btnModificarProducto.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnModificarProducto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificarProducto.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnModificarProducto.ForeColor = System.Drawing.Color.White;
            this.btnModificarProducto.Location = new System.Drawing.Point(49, 344);
            this.btnModificarProducto.Name = "btnModificarProducto";
            this.btnModificarProducto.Size = new System.Drawing.Size(118, 28);
            this.btnModificarProducto.TabIndex = 47;
            this.btnModificarProducto.Text = "Modificar producto";
            this.btnModificarProducto.UseVisualStyleBackColor = false;
            this.btnModificarProducto.Click += new System.EventHandler(this.btnModificarProducto_Click);
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
            // Error_producto
            // 
            this.Error_producto.ContainerControl = this;
            // 
            // tbIDProd
            // 
            this.tbIDProd.Location = new System.Drawing.Point(356, 11);
            this.tbIDProd.Name = "tbIDProd";
            this.tbIDProd.Size = new System.Drawing.Size(26, 20);
            this.tbIDProd.TabIndex = 64;
            this.tbIDProd.Visible = false;
            // 
            // FrmEditarProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(463, 442);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarProducto";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Modificar producto";
            this.Load += new System.EventHandler(this.FrmEditarProducto_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Error_producto)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnCancelarModificacion;
        private ComboBox cbCategoríaProducto;
        private TextBox txtStock;
        private TextBox txtPrecioVenta;
        private TextBox txtPrecioCompra;
        private TextBox tbNombreProducto;
        private Label lblStock;
        private Label lblPrecioVenta;
        private Label lblPrecioCompra;
        private Label label3;
        private Label lblNombreProducto;
        private Button btnModificarProducto;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private TextBox txtStockMinimo;
        private Label lblStockMinimo;
        private ErrorProvider Error_producto;
        private ComboBox cbProveedor;
        private Label lblProveedor;
        private TextBox tbIDProd;
    }
}