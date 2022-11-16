using SistemaVentaAkira.Controller;
using SistemaVentaAkira.View.Clases_Validacion;
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

namespace SistemaVentaAkira.View.Proveedor
{
    public partial class FrmEditarProveedor : Form
    {
        private bool razonSocial;
        private bool cuil;
        private bool descripcion;
        private bool telefono;
        private bool direccion;
        private bool nombreProv;

        public FrmEditarProveedor(int p_index )
        {
            InitializeComponent();
            cargarCampos(p_index);
        }

        private void cargarCampos(int p_index)
        {
            Proveedor_Controller editProv = new Proveedor_Controller();
            Object[] infoProv = editProv.buscarProveedor(p_index);

            txt_IDprov.Text = infoProv[0].ToString();
            txt_IDprov.Visible = false;
            lblIdentificador.Visible = false;
            txt_NombreProv.Text = infoProv[1].ToString();
            txtDescripcion.Text = infoProv[2].ToString();
            txtRazonSocial.Text = infoProv[3].ToString();
            tbCuil.Text = infoProv[4].ToString();
            tbCuil.Visible = false;
            lblCuil.Visible = false;
            txtDireccion.Text = infoProv[5].ToString();
            txtTelefono.Text = infoProv[6].ToString();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            this.cargarCampos(Convert.ToInt32(txt_IDprov.Text));
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void tbCuil_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCUIL(Error_proveedor, tbCuil, ref cuil);
        }

        private void txtRazonSocial_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCadena(Error_proveedor, txtRazonSocial, ref razonSocial);
        }

        private void txtDescripcion_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCaracterCad(Error_proveedor, txtDescripcion, ref descripcion);
        }

        private void txtDireccion_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCaracterCad(Error_proveedor, txtDireccion, ref direccion);
        }

        private void tbCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarTelefono(Error_proveedor, txtTelefono, ref telefono);
        }

        private bool validarCamposProv()
        {
            return (razonSocial && cuil && descripcion && telefono && direccion && nombreProv);
        }

        private void restaurarCampos()
        {
            tbCuil.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, tbCuil);
            txtRazonSocial.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtRazonSocial);
            txtDescripcion.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtDescripcion);
            txtTelefono.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtTelefono);
            txtDireccion.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtDireccion);
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            if (validarCamposProv())
            {
                Proveedor_Controller modificarProv = new Proveedor_Controller();
                modificarProv.actualizarProveedor(Convert.ToInt32(txt_IDprov.Text), tbCuil.Text, txt_NombreProv.Text, txtDescripcion.Text, txtTelefono.Text, txtDireccion.Text, txtRazonSocial.Text);
                MessageBox.Show("Se modificó el proveedor con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarCampos(Convert.ToInt32(txt_IDprov.Text));
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Registro de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        private void txt_NombreProv_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCadena(Error_proveedor, txt_NombreProv, ref nombreProv);
        }

    }
}
