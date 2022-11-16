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
    public partial class FrmUsuarioOperacion : Form
    {
        private bool nombre;
        private bool usuario;
        private bool apellido;
        private bool email;
        private bool telefono;
        private bool dni;
        private bool rol;
        private bool estado;
        private bool contraseña;

        public FrmUsuarioOperacion()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e){
            DialogResult respuesta = MessageBox.Show("Cerrar Registro?", "Registro de Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        #region Código utilizado para desplazar la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Registrar usuario
        private void btnRegistrarUsuario_Click(object sender, EventArgs e)
        {
            if (this.validarCampos()){
                Usuario_controller controlador_usuario = new Usuario_controller();
                if (controlador_usuario.validacionEmailRegistro(tbEmailUsuario.Text)) {
                    controlador_usuario.AgregarUsuario(cbRolUsuario.Text, tbNombreUsuario.Text, tbApellidoUsuario.Text, tbUsuario.Text, tbEmailUsuario.Text, tbTelefonoUsuario.Text, tbClaveUsuario.Text, dtp_nacimientoUsuario.Value);
                    MessageBox.Show("Se añadió con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    restaurarCampos();
                }
                else
                {
                    MessageBox.Show("E-mail ya existente dentro del sistema", "Operación inválida", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }
                    
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Registro de usuario", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }
        #endregion

        #region Validaciones de campos
        private void tbNombreUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarNombreCompleto(ErrorUser, tbNombreUsuario, ref nombre);
        }

        private void tbNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

        }

        private void tbApellidoUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarNombreCompleto(ErrorUser, tbApellidoUsuario, ref apellido);
        }

        private void tbApellidoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCadena(ErrorUser, tbUsuario, ref usuario);
        }

        private void tbDNIUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void tbEmailUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarEmail(ErrorUser, tbEmailUsuario, ref email);
        }

        private void tbTelefonoUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarTelefono(ErrorUser, tbTelefonoUsuario, ref telefono);
        }

        private void tbClaveUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarClave(ErrorUser, tbClaveUsuario, ref contraseña);
        }

        private void cbRolUsuario_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarComboBox(ErrorUser, cbRolUsuario, ref rol);
        }

        
        private bool validarCampos()
        {
            return (nombre && apellido &&  usuario && contraseña && email && telefono);
        }
        #endregion

        #region Restauración de campos (limpieza de errores)
        private void restaurarCampos()
        {
            tbNombreUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbNombreUsuario);
            tbApellidoUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbApellidoUsuario);
            tbUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbUsuario);
            tbEmailUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbEmailUsuario);
            tbTelefonoUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbTelefonoUsuario);
            tbClaveUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbClaveUsuario);
            //cbEstadoUsuario.SelectedIndex = 0;
            //cbRolUsuario.SelectedIndex = 0;
        }
        #endregion

        #region Carga de comboBox
        private void cargarComBoxRol()
        {
            Usuario_controller controlador_usuario = new Usuario_controller();
            List<object> roles = controlador_usuario.ConsultarRoles();
            foreach (var rol in roles)
            {
                cbRolUsuario.Items.Add(rol.ToString());
            }
            this.cbRolUsuario.SelectedIndex = 0;
        }

        private void FrmUsuarioOperacion_Load(object sender, EventArgs e)
        {
            cargarComBoxRol();
        }

        #endregion

        #region Btn cancelar operación
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            restaurarCampos();
        }
        #endregion

       
    }
}
