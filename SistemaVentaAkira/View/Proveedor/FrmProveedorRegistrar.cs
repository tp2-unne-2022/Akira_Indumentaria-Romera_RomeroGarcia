using SistemaVentaAkira.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentaAkira.View.Clases_Validacion;

namespace SistemaVentaAkira.View.Proveedor
{
    public partial class FrmProveedorRegistrar : Form
    {
        private bool razonSocial;
        private bool cuil;
        private bool descripcion;
        private bool telefono;
        private bool direccion;
        private bool nombreProv;

        public FrmProveedorRegistrar()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            restaurarCampos();
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

        private void tbCuil_TextChanged(object sender, EventArgs e)
        {
           Validaciones.ValidarCUIL(Error_proveedor, tbCuil, ref cuil);
        }

        private void tbCuil_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
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
        private void txtTelefono_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarTelefono(Error_proveedor, txtTelefono, ref telefono);
        }

        private void btnRegistrarProveedor_Click(object sender, EventArgs e)
        {
            if (this.validarCamposProv())
            {
                Proveedor_Controller newProveedor = new Proveedor_Controller();
                if(newProveedor.validacionCuit(tbCuil.Text))
                {
                    newProveedor.AgregarProveedor(tbCuil.Text, txt_NombreProv.Text, txtDescripcion.Text, txtTelefono.Text, txtDireccion.Text, txtRazonSocial.Text);
                    MessageBox.Show("Se añadió con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    restaurarCampos();
                }else
                {
                    MessageBox.Show("El Cuit ya se encuentra registrado", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Registro de proveedor", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        private void restaurarCampos()
        {
            tbCuil.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, tbCuil);
            txtRazonSocial.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtRazonSocial);
            txt_NombreProv.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txt_NombreProv);
            txtDescripcion.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtDescripcion);
            txtTelefono.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtTelefono);
            txtDireccion.Clear();
            Validaciones.LimpiarProvider(Error_proveedor, txtDireccion);
        }

        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validarCamposProv()
        {
            return (razonSocial && cuil && descripcion && telefono && direccion && nombreProv);
        }

        private void txt_NombreProv_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCadena(Error_proveedor, txt_NombreProv, ref nombreProv);
        }

    }
}
