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
    public partial class FrmEditarUsuario : Form
    {
        private bool nombre;
        private bool apellido;
        private bool email;
        private bool telefono;
        private bool dni;
        private bool rol;
        private bool estado;
        private bool contraseña;
        public FrmEditarUsuario(int p_index)
        {
            InitializeComponent();
            this.cargarCampos(p_index);
        }

        #region Código que permite el desplazamiento de la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e){
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion

        #region Cerrar ventana
        private void IcClose_Click(object sender, EventArgs e){
            DialogResult respuesta = MessageBox.Show("Cerrar Modificación de usuario?", "Modificar Usuario", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
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
            return (nombre && apellido && contraseña && email && telefono);
        }

        #endregion

        #region Modificar usuario
        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (this.validarCampos())
            {
                Usuario_controller controlador_usuario = new Usuario_controller();
                if (controlador_usuario.validacionEmailEdit(Convert.ToInt32(tbIDUser.Text), tbEmailUsuario.Text)) {
                    controlador_usuario.modificarUsuario(Convert.ToInt32(tbIDUser.Text), cbRolUsuario.Text, tbNombreUsuario.Text, tbApellidoUsuario.Text, tbUsuario.Text, tbEmailUsuario.Text, tbTelefonoUsuario.Text, tbClaveUsuario.Text, dtp_nacimientoUsuario.Value);
                    MessageBox.Show("Se modificó al usuario con éxito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarCampos(Convert.ToInt32(tbIDUser.Text));
                }
                else
                {
                    MessageBox.Show("E-mail ya existente dentro del sistema", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                }
                
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Operación fallida", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }
        #endregion

        #region Restauración de campos (limpiar campos)
        private void restaurarCampos()
        {
            tbNombreUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbNombreUsuario);
            tbApellidoUsuario.Clear();
            Validaciones.LimpiarProvider(ErrorUser, tbApellidoUsuario);
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

        #region Cargar campos
        private void cargarCampos(int p_index)
        {
            Usuario_controller controlador_usuario = new Usuario_controller();
            object[] usuario = controlador_usuario.consultarUsuario(p_index);

            cargarComBoxRol();
            
            tbIDUser.Text = usuario[0].ToString();

            for(int i = 0; i < cbRolUsuario.Items.Count; i++)
            {
                if (usuario[1].ToString() == cbRolUsuario.Items[i].ToString())
                {
                    cbRolUsuario.SelectedIndex = i;
                }
            }

            tbNombreUsuario.Text = usuario[2].ToString();
            tbApellidoUsuario.Text = usuario[3].ToString();
            tbUsuario.Text = usuario[4].ToString();
            tbEmailUsuario.Text = usuario[5].ToString();
            tbTelefonoUsuario.Text = usuario[6].ToString();
            tbClaveUsuario.Text = usuario[7].ToString();
            dtp_nacimientoUsuario.Text = usuario[8].ToString();

        }
        #endregion

        #region Cargar combobox Rol
        private void cargarComBoxRol()
        {
            Usuario_controller controlador_usuario = new Usuario_controller();
            List<object> roles = controlador_usuario.ConsultarRoles();
            foreach (var rol in roles)
            {
                cbRolUsuario.Items.Add(rol.ToString());
            }
        }

        #endregion

        #region Cancelar edición
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            cargarCampos(Convert.ToInt32(tbIDUser.Text));
        }

        #endregion

        
    }
}
