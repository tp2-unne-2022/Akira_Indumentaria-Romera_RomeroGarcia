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
    public partial class FrmCategoriaOperacion : Form
    {
        private bool nombreCategoria;
        private bool descripcion;
        private bool estadoCategoria;
        public FrmCategoriaOperacion()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Cerrar Registro?", "Registro de categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
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

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
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

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            if (this.validacionesCampo())
            {
                Categoria_Controller newCategory = new Categoria_Controller();
                if (newCategory.validacionName(tbNombreCategoria.Text))
                {
                    newCategory.AgregarCategoria(tbNombreCategoria.Text, tbDescripcionCategoria.Text);
                    MessageBox.Show("Se añadió con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    restaurarCampos();
                }
                else
                {
                    MessageBox.Show("El nombre de la categoría ya se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Registro de categoría", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
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
            //cbEstadoCategoria.SelectedIndex = 0;
        }
    }
}
