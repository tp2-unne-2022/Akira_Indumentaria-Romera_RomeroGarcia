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
using SistemaVentaAkira.Controller;

namespace SistemaVentaAkira.View
{
    public partial class FrmClienteOperacion : Form
    {
        //Variables utilizadas para validar el ingreso en los campos
        private bool cl_dni;
        private bool nombre;
        private bool apellido;
        private bool email;
        private bool cbEstado;
        private bool telefono;

        public FrmClienteOperacion()
        {
            InitializeComponent();
        }

        #region Código que permite desplazar la ventana
        private void IcClose_Click(object sender, EventArgs e){

            DialogResult respuesta = MessageBox.Show("Cerrar Registro?", "Registro de cliente", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e){
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

        #region Restauración de campos (limpia errores)
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

        #region Registrar cliente
        private void btnRegistrarCliente_Click(object sender, EventArgs e)
        {
            if (this.validacionesCampos())
            {
                Cliente_Controller controlador_cliente = new Cliente_Controller();
                if (controlador_cliente.validacionDNIRegistro(tbDNICliente.Text))
                {
                    controlador_cliente.AgregarCliente(tbNombreCliente.Text, tbApellidoCliente.Text, tbDNICliente.Text, tbEmailCliente.Text, tbTelefonoCliente.Text, dtp_nacimientoCliente.Value);
                    MessageBox.Show("Se añadió con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    restaurarCampos();
                }
                else
                {
                    MessageBox.Show("DNI ya existente dentro del sistema", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                }
                
            }
            else
            {
               MessageBox.Show("Campos incorrectos", "Registro de cliente", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            }
        }
        #endregion

    }
}
