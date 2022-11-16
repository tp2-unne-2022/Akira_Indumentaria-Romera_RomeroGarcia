using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    partial class FrmCategoriaOperacion
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
            System.Windows.Forms.Label lblRegistrarCategoria;
            this.panelAgregarCategoria = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.tbDescripcionCategoria = new System.Windows.Forms.TextBox();
            this.tbNombreCategoria = new System.Windows.Forms.TextBox();
            this.lblDescripcion = new System.Windows.Forms.Label();
            this.lblNombreCategoria = new System.Windows.Forms.Label();
            this.panelTitulo = new System.Windows.Forms.Panel();
            this.IcClose = new FontAwesome.Sharp.IconPictureBox();
            this.ErrorCategoria = new System.Windows.Forms.ErrorProvider(this.components);
            lblRegistrarCategoria = new System.Windows.Forms.Label();
            this.panelAgregarCategoria.SuspendLayout();
            this.panelTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCategoria)).BeginInit();
            this.SuspendLayout();
            // 
            // lblRegistrarCategoria
            // 
            lblRegistrarCategoria.AutoSize = true;
            lblRegistrarCategoria.Font = new System.Drawing.Font("Century Gothic", 15F, System.Drawing.FontStyle.Bold);
            lblRegistrarCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            lblRegistrarCategoria.Location = new System.Drawing.Point(135, 23);
            lblRegistrarCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            lblRegistrarCategoria.Name = "lblRegistrarCategoria";
            lblRegistrarCategoria.Size = new System.Drawing.Size(194, 23);
            lblRegistrarCategoria.TabIndex = 1;
            lblRegistrarCategoria.Text = "Registrar categoría";
            lblRegistrarCategoria.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panelAgregarCategoria
            // 
            this.panelAgregarCategoria.Controls.Add(this.btnRegistrar);
            this.panelAgregarCategoria.Controls.Add(this.tbDescripcionCategoria);
            this.panelAgregarCategoria.Controls.Add(this.tbNombreCategoria);
            this.panelAgregarCategoria.Controls.Add(this.lblDescripcion);
            this.panelAgregarCategoria.Controls.Add(this.lblNombreCategoria);
            this.panelAgregarCategoria.Controls.Add(lblRegistrarCategoria);
            this.panelAgregarCategoria.Location = new System.Drawing.Point(0, 26);
            this.panelAgregarCategoria.Name = "panelAgregarCategoria";
            this.panelAgregarCategoria.Size = new System.Drawing.Size(446, 287);
            this.panelAgregarCategoria.TabIndex = 0;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.btnRegistrar.FlatAppearance.BorderSize = 0;
            this.btnRegistrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(142)))), ((int)(((byte)(116)))));
            this.btnRegistrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRegistrar.Font = new System.Drawing.Font("Calibri", 11.25F);
            this.btnRegistrar.ForeColor = System.Drawing.Color.White;
            this.btnRegistrar.Location = new System.Drawing.Point(156, 239);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(134, 28);
            this.btnRegistrar.TabIndex = 30;
            this.btnRegistrar.Text = "Registrar categoría";
            this.btnRegistrar.UseVisualStyleBackColor = false;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // tbDescripcionCategoria
            // 
            this.tbDescripcionCategoria.Location = new System.Drawing.Point(199, 132);
            this.tbDescripcionCategoria.Name = "tbDescripcionCategoria";
            this.tbDescripcionCategoria.Size = new System.Drawing.Size(213, 20);
            this.tbDescripcionCategoria.TabIndex = 24;
            this.tbDescripcionCategoria.TextChanged += new System.EventHandler(this.tbDescripcionCategoria_TextChanged);
            // 
            // tbNombreCategoria
            // 
            this.tbNombreCategoria.Location = new System.Drawing.Point(199, 85);
            this.tbNombreCategoria.Name = "tbNombreCategoria";
            this.tbNombreCategoria.Size = new System.Drawing.Size(213, 20);
            this.tbNombreCategoria.TabIndex = 23;
            this.tbNombreCategoria.TextChanged += new System.EventHandler(this.tbNombreCategoria_TextChanged);
            this.tbNombreCategoria.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbNombreCategoria_KeyPress);
            // 
            // lblDescripcion
            // 
            this.lblDescripcion.AutoSize = true;
            this.lblDescripcion.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblDescripcion.ForeColor = System.Drawing.Color.Black;
            this.lblDescripcion.Location = new System.Drawing.Point(57, 136);
            this.lblDescripcion.Name = "lblDescripcion";
            this.lblDescripcion.Size = new System.Drawing.Size(89, 19);
            this.lblDescripcion.TabIndex = 17;
            this.lblDescripcion.Text = "Descripción:";
            // 
            // lblNombreCategoria
            // 
            this.lblNombreCategoria.AutoSize = true;
            this.lblNombreCategoria.Font = new System.Drawing.Font("Calibri", 12F);
            this.lblNombreCategoria.ForeColor = System.Drawing.Color.Black;
            this.lblNombreCategoria.Location = new System.Drawing.Point(25, 88);
            this.lblNombreCategoria.Name = "lblNombreCategoria";
            this.lblNombreCategoria.Size = new System.Drawing.Size(169, 19);
            this.lblNombreCategoria.TabIndex = 16;
            this.lblNombreCategoria.Text = "Nombre de la categoría: ";
            // 
            // panelTitulo
            // 
            this.panelTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(154)))), ((int)(((byte)(103)))), ((int)(((byte)(78)))));
            this.panelTitulo.Controls.Add(this.IcClose);
            this.panelTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitulo.Location = new System.Drawing.Point(0, 0);
            this.panelTitulo.Name = "panelTitulo";
            this.panelTitulo.Size = new System.Drawing.Size(446, 26);
            this.panelTitulo.TabIndex = 34;
            this.panelTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitulo_MouseDown);
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
            // FrmCategoriaOperacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(446, 313);
            this.Controls.Add(this.panelTitulo);
            this.Controls.Add(this.panelAgregarCategoria);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmCategoriaOperacion";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registrar categoría";
            this.panelAgregarCategoria.ResumeLayout(false);
            this.panelAgregarCategoria.PerformLayout();
            this.panelTitulo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IcClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorCategoria)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panelAgregarCategoria;
        private TextBox tbDescripcionCategoria;
        private TextBox tbNombreCategoria;
        private Label lblDescripcion;
        private Label lblNombreCategoria;
        private Button btnRegistrar;
        private Panel panelTitulo;
        private FontAwesome.Sharp.IconPictureBox IcClose;
        private ErrorProvider ErrorCategoria;
    }
}