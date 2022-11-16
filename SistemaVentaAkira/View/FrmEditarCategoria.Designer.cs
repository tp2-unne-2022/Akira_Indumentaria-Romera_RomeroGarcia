using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class FrmEditarCategoria
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
            System.Windows.Forms.Label lblEditarCategoria;
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt_idcate = new System.Windows.Forms.TextBox();
            this.ID_categoria = new System.Windows.Forms.Label();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.tbDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.tbNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.ErrorCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            lblEditarCategoria = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblEditarCategoria
            // 
            lblEditarCategoria.AutoSize = true;
            lblEditarCategoria.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblEditarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblEditarCategoria.Location = new System.Drawing.Point(140, 14);
            lblEditarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblEditarCategoria.Name = "lblEditarCategoria";
            lblEditarCategoria.Size = new System.Drawing.Size(167, 23);
            lblEditarCategoria.TabIndex = 6;
            lblEditarCategoria.Text = "Editar Categoria";
            lblEditarCategoria.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txt_idcate);
            this.panel1.Controls.Add(this.ID_categoria);
            this.panel1.Controls.Add(this.btnCancelar);
            this.panel1.Controls.Add(this.btnModificar);
            this.panel1.Controls.Add(this.tbDescripcionCategoria);
            this.panel1.Controls.Add(this.tbNombreCategoria);
            this.panel1.Controls.Add(this.lblDescripcion);
            this.panel1.Controls.Add(this.lblNombreCategoria);
            this.panel1.Controls.Add(lblEditarCategoria);
            this.panel1.Location = new System.Drawing.Point(0, 29);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(446, 309);
            this.panel1.TabIndex = 7;
            // 
            // txt_idcate
            // 
            this.txt_idcate.Location = new System.Drawing.Point(207, 59);
            this.txt_idcate.Name = "txt_idcate";
            this.txt_idcate.Size = new System.Drawing.Size(213, 20);
            this.txt_idcate.TabIndex = 40;
            // 
            // ID_categoria
            // 
            this.ID_categoria.AutoSize = true;
            this.ID_categoria.Font = new System.Drawing.Font("Calibri", 12F);
            this.ID_categoria.ForeColor = System.Drawing.Color.Black;
            this.ID_categoria.Location = new System.Drawing.Point(103, 60);
            this.ID_categoria.Name = "ID_categoria";
            this.ID_categoria.Size = new System.Drawing.Size(94, 19);
            this.ID_categoria.TabIndex = 39;
            this.ID_categoria.Text = "Identificador:";
            // 
            // btnCancelar
            // 
            this.btnCancelar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnCancelar.FlatAppearance.BorderSize = 0;
            this.btnCancelar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnCancelar.ForeColor = System.Drawing.Color.White;
            this.btnCancelar.Location = new System.Drawing.Point(301, 222);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(119, 28);
            this.btnCancelar.TabIndex = 38;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = false;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnModificar.FlatAppearance.BorderSize = 0;
            this.btnModificar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnModificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnModificar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnModificar.ForeColor = System.Drawing.Color.White;
            this.btnModificar.Location = new System.Drawing.Point(33, 222);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(139, 28);
            this.btnModificar.TabIndex = 37;
            this.btnModificar.Text = "Modficar categoría";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // tbDescripcionCategoria
            // 
            this.tbDescripcionCategoria.Location = new System.Drawing.Point(207, 156);
            this.tbDescripcionCategoria.Name = "tbDescripcionCategoria";
            this.tbDescripcionCategoria.Size = new System.Drawing.Size(213, 20);
            this.tbDescripcionCategoria.TabIndex = 35;
            this.tbDescripcionCategoria.TextChanged += new System.EventHandler(this.tbDescripcionCategoria_TextChanged);
            // 
            // tbNombreCategoria
            // 
            this.tbNombreCategoria.Location = new System.Drawing.Point(207, 108);
            this.tbNombreCategoria.Name = "tbNombreCategoria";
            this.tbNombreCategoria.Size = new System.Drawing.Size(213, 20);
            this.tbNombreCategoria.TabIndex = 34;
            this.tbNombreCategoria.TextChanged += new System.EventHandler(this.tbNombreCategoria_TextChanged);
            this.tbNombreCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreCategoria_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(65, 159);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 32;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCategoria.Location = new System.Drawing.Point(33, 112);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(169, 19);
            this.lblNombreCategoria.TabIndex = 31;
            this.lblNombreCategoria.Text = "Nombre de la categoría: ";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(446, 23);
            this.panelTitulo.TabIndex = 35;
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
            // ErrorCategoria
            // 
            this.ErrorCategoria.ContainerControl = this;
            // 
            // FrmEditarCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 342);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmEditarCategoria";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Editar Categoria";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Button btnCancelar;
        private Button btnModificar;
        private TextBox tbDescripcionCategoria;
        private TextBox tbNombreCategoria;
        private Label lblDescripcion;
        private Label lblNombreCategoria;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private ErrorProvider ErrorCategoria;
        private TextBox txt_idcate;
        private Label ID_categoria;
    }
}