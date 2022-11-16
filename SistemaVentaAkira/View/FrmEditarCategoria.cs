using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentaAkira.Controller;
using SistemaVentaAkira.View.Clases_Validacion;

namespace SistemaVentaAkira.View
{
    public partial class FrmEditarCategoria : Form
    {
        private bool nombreCategoria;
        private bool descripcion;
        public FrmEditarCategoria(int p_index)
        {
            InitializeComponent();
            cargarCampos(p_index);
        }

        private void cargarCampos(int p_index)
        {
            Categoria_Controller editCate = new Categoria_Controller();
            Object[] infoCate = editCate.buscarCategoria(p_index);

            txt_idcate.Text = infoCate[0].ToString();
            txt_idcate.Visible = false;
            ID_categoria.Visible = false;
            tbNombreCategoria.Text = infoCate[1].ToString();
            tbDescripcionCategoria.Text = infoCate[2].ToString();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Cerrar Modificación de categoría?", "Modificar categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        //Para desplazar form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbNombreCategoria_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCadena(ErrorCategoria, tbNombreCategoria, ref nombreCategoria);
        }

        private void tbDescripcionCategoria_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCaracterCad(ErrorCategoria, tbDescripcionCategoria, ref descripcion);
        }

        private bool validacionesCampo()
        {
            return (descripcion && nombreCategoria);
        }

        private void tbNombreCategoria_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void restaurarCampos()
        {
            tbNombreCategoria.Clear();
            Validaciones.LimpiarProvider(ErrorCategoria, tbNombreCategoria);
            tbDescripcionCategoria.Clear();
            Validaciones.LimpiarProvider(ErrorCategoria, tbDescripcionCategoria);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (this.validacionesCampo())
            {
                Categoria_Controller editCate = new Categoria_Controller();
                editCate.actualizarCategoria(Convert.ToInt32(txt_idcate.Text), tbNombreCategoria.Text, tbDescripcionCategoria.Text);
                MessageBox.Show("Se Modificó la categoría con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarCampos(Convert.ToInt32(txt_idcate.Text));
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Modificar categoría", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

    }
}
