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
using SistemaVentaAkira.View.Clases_Validacion;
using SistemaVentaAkira.Controller;

namespace SistemaVentaAkira.View
{
    public partial class FrmEditarCliente : Form
    {
        //Variables utilizadas para validar el ingreso en los campos
        private bool cl_dni;
        private bool nombre;
        private bool apellido;
        private bool email;
        private bool cbEstado;
        private bool telefono;

        public FrmEditarCliente(int p_index)
        {
            InitializeComponent();
            this.cargarCampos(p_index);
        }

        #region Btn cerrar
        private void IcClose_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Cerrar Modificar Cliente?", "Modificar cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Código que permite desplazar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Validaciones de campos
        private void tbNombreCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbApellidoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbTelefonoCliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void tbDNICliente_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbNombreCliente_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarNombreCompleto(ErrorCliente, tbNombreCliente, ref nombre);
        }

        private void tbEmailCliente_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarEmail(ErrorCliente, tbEmailCliente, ref email);
        }

        private void tbApellidoCliente_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarNombreCompleto(ErrorCliente, tbApellidoCliente, ref apellido);
        }

        private void tbDNICliente_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarDNI(ErrorCliente, tbDNICliente, ref cl_dni);
        }

        private void tbTelefonoCliente_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarTelefono(ErrorCliente, tbTelefonoCliente, ref telefono);
        }

        //El metodo retorna true en caso que los campos fueron rellenados correctamente
        private bool validacionesCampos()
        {
            return (cl_dni && nombre && apellido && email && telefono);
        }

        #endregion

        #region Restauracion de campos (limpiador de errores)
        private void restaurarCampos()
        {
            tbNombreCliente.Clear();
            Validaciones.LimpiarProvider(ErrorCliente, tbNombreCliente);
            tbApellidoCliente.Clear();
            Validaciones.LimpiarProvider(ErrorCliente, tbApellidoCliente);
            tbDNICliente.Clear();
            Validaciones.LimpiarProvider(ErrorCliente, tbDNICliente);
            tbEmailCliente.Clear();
            Validaciones.LimpiarProvider(ErrorCliente, tbEmailCliente);
            tbTelefonoCliente.Clear();
            Validaciones.LimpiarProvider(ErrorCliente, tbTelefonoCliente);
            tbTelefonoCliente.Clear();
            Validaciones.LimpiarProvider(ErrorCliente, tbTelefonoCliente);
            //cbEstadoCliente.SelectedIndex = 0;
        }
        #endregion

        #region Cargar campos
        private void cargarCampos(int p_index) {
            Cliente_Controller controlador_cliente = new Cliente_Controller();
            Object[] cliente = controlador_cliente.consultarCliente(p_index);

            tbIDCliente.Text = cliente[0].ToString();
            tbNombreCliente.Text = cliente[1].ToString();
            tbApellidoCliente.Text = cliente[2].ToString();
            tbDNICliente.Text = cliente[3].ToString();
            tbEmailCliente.Text = cliente[4].ToString();
            tbTelefonoCliente.Text = cliente[5].ToString();
            dtp_nacimientoCliente.Text = cliente[6].ToString();

        }
        #endregion

        #region Modificar cliente
        private void btnModificarCliente_Click(object sender, EventArgs e)
        {
            if (this.validacionesCampos())
            {
                Cliente_Controller controlador_cliente = new Cliente_Controller();
                //Se verifica que el DNI del cliente no se encuentre ya resgistrado
                if (controlador_cliente.validacionDNIEdit(Convert.ToInt32(tbIDCliente.Text), tbDNICliente.Text))
                {
                    controlador_cliente.modificarCliente(Convert.ToInt32(tbIDCliente.Text), tbNombreCliente.Text, tbApellidoCliente.Text, tbDNICliente.Text, tbEmailCliente.Text, tbTelefonoCliente.Text, dtp_nacimientoCliente.Value);
                    MessageBox.Show("Se modificó al cliente con éxito", "Opeación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarCampos(Convert.ToInt32(tbIDCliente.Text));
                }
                else
                {
                    MessageBox.Show("DNI ya existente dentro del sistema", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Operación inválida", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }
        #endregion

        #region Cancelar edición
        private void btnCancelarEdicion_Click(object sender, EventArgs e)
        {
            this.cargarCampos(Convert.ToInt32(tbIDCliente.Text));
        }
        #endregion
    }
}
