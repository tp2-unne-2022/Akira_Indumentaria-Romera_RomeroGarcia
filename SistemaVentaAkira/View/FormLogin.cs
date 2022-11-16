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
using SistemaVentaAkira.View;
using SistemaVentaAkira.View.Empleado;
using SistemaVentaAkira.View.Supervisor;
using SistemaVentaAkira.View.Clases_Validacion;
using SistemaVentaAkira.Controller;

namespace SistemaVentaAkira.View
{
    public partial class FormLogin : Form
    {
        //Variables que se utilizarán para la validación
        private bool usuario;
        private bool clave;
        public FormLogin()
        {
            InitializeComponent();
            TextPassword.UseSystemPasswordChar = true;
        }

        #region Validaciones de campos
        
        private void TextPassword_KeyPress(object sender, KeyPressEventArgs e)
        {/*
            bool estado = false;
             if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
             {
                 e.Handled = true;
                 estado = true;
             }

               if (estado){
                     errorLogin.SetError(TextPassword, "Se introdujo un caracter no numérico");
               }else{
                     errorLogin.Clear();
               }

            if(TextPassword.Text.Length > 4)
            {
                errorLogin.SetError(TextPassword, "La contraseña debe contener 5 caracteres");
            }
            else
            {
                errorLogin.Clear();
            }
            */
        }

        private void TxtUser_KeyPress(object sender, KeyPressEventArgs e)
        {
           /* bool estado = false;

             if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
             {
                 e.Handled = true;
                 estado = true;
             }


             if (estado)
             {
                 errorLogin.SetError(TxtUser, "Se introdujo un caracter no válido");
             }else{
                 errorLogin.Clear();
             }
             else if (TxtUser.Text.Length < 5)
             {
                 errorLogin.SetError(TxtUser, "El nombre de usuario tiene menos de 5 caracteres");
             }
             else
             {
                 errorLogin.Clear();
             }
           */
        }

        private void TextPassword_TextChanged(object sender, EventArgs e){
            
            if (TextPassword.Text.Length > 5)
            {
                errorLogin.SetError(TextPassword, "La contraseña debe contener 5 caracteres");
                clave = false;
            }
            else
            {
                errorLogin.Clear();
                clave = true;
            }
        }

        private void TxtUser_TextChanged(object sender, EventArgs e)
        {
           Validaciones.ValidarCadena(errorLogin, TxtUser, ref usuario);
        }

        private bool camposValidados(){
            return (usuario && clave);
        }
            #endregion

        #region Cerrar la ventana de inicio de sesión
        private void IcClose_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Confirmar cierre", "¿Desea cerrar la ventana?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(respuesta == DialogResult.OK)
            {
                Application.Exit();
            }
        }
        #endregion

        #region Minimizar la ventana de inicio de sesión
        private void ICMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState=FormWindowState.Minimized;
        }

        //Permite desplazar la venta de inicio de sesión
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

        #region Ingresar
        private void BtnAcceder_Click(object sender, EventArgs e){
            //Se evalúa si los campos están vacíos
            if (TxtUser.Text == string.Empty || TextPassword.Text == string.Empty){
                MessageBox.Show("Para acceder al sistema debe completar todos los campos", "Acceso inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (camposValidados()){ //Se evalúa si los campos tienen el formato correcto
                Usuario_controller controlador_usuario = new Usuario_controller();
                if (controlador_usuario.verificarLoggin(TxtUser.Text, TextPassword.Text)){ //Se evalúa si el usuario se encuentra registrado
                    Object[] usuario = controlador_usuario.obtenerUsuario(TxtUser.Text, TextPassword.Text);
                    if (usuario[1].ToString() == "ADMINISTRADOR")
                    {
                        Principal MP_Adm = new Principal();
                        MP_Adm.lblroltxt.Text = usuario[1].ToString();
                        MP_Adm.lblnombretxt.Text = usuario[3].ToString() + ", " + usuario[2].ToString();
                        MP_Adm.lblemailtxt.Text = usuario[4].ToString();

                        SesionUser.Id_usuario = Convert.ToInt32(usuario[0].ToString());
                        SesionUser.Us_nombre = usuario[3].ToString();
                        SesionUser.Us_apellido = usuario[2].ToString();
                        SesionUser.Us_email = usuario[4].ToString();
                        SesionUser.Us_Rol = usuario[1].ToString();

                        this.Hide();
                        MP_Adm.Show();
                        MP_Adm.FormClosed += new FormClosedEventHandler(cerrarSesion);
                    }
                    else if (usuario[1].ToString() == "EMPLEADO") {

                        Menu_Empleado MP_Empleado = new Menu_Empleado();

                        MP_Empleado.lblroltxt.Text = usuario[1].ToString();
                        MP_Empleado.lblnombretxt.Text = usuario[3].ToString() + ", " + usuario[2].ToString();
                        MP_Empleado.lblemailtxt.Text = usuario[4].ToString();

                        SesionUser.Id_usuario = Convert.ToInt32(usuario[0].ToString());
                        SesionUser.Us_nombre = usuario[3].ToString();
                        SesionUser.Us_apellido = usuario[2].ToString();
                        SesionUser.Us_email = usuario[4].ToString();
                        SesionUser.Us_Rol = usuario[1].ToString();

                        this.Hide();
                        MP_Empleado.Show();
                        MP_Empleado.FormClosed += new FormClosedEventHandler(cerrarSesion);
                    }
                    else if (usuario[1].ToString() == "SUPERVISOR")
                    {
                        Menu_Supervisor MP_Supervisor = new Menu_Supervisor();

                        MP_Supervisor.lblroltxt.Text = usuario[1].ToString();
                        MP_Supervisor.lblnombretxt.Text = usuario[3].ToString() + ", " + usuario[2].ToString();
                        MP_Supervisor.lblUsuarioTxt.Text = usuario[4].ToString();

                        SesionUser.Id_usuario = Convert.ToInt32(usuario[0].ToString());
                        SesionUser.Us_nombre = usuario[3].ToString();
                        SesionUser.Us_apellido = usuario[2].ToString();
                        SesionUser.Us_email = usuario[4].ToString();
                        SesionUser.Us_Rol = usuario[1].ToString();

                        this.Hide();
                        MP_Supervisor.Show();
                        MP_Supervisor.FormClosed += new FormClosedEventHandler(cerrarSesion);
                    }
                }else
                {
                   MessageBox.Show("Usuario no encontrado", "Acceso inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else{
                MessageBox.Show("Debe completar los campos con el formato correcto", "Acceso inválido", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        //Al cerrar el Menú principal, se visualizará nuevamente el inicio de sesión
        private void cerrarSesion(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }

        #region Ver/Ocultar contraseña
        //Al presionar la img visualizar contraseña, se ocultará o visualizará
        private void IPBvisualizarClave_Click(object sender, EventArgs e){
            if (TextPassword.UseSystemPasswordChar == true) {
                TextPassword.UseSystemPasswordChar = false;
                IPBvisualizarClave.IconChar = FontAwesome.Sharp.IconChar.Eye;
            }
            else{
                TextPassword.UseSystemPasswordChar = true;
                IPBvisualizarClave.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            } 
        }
        #endregion

    }
}
