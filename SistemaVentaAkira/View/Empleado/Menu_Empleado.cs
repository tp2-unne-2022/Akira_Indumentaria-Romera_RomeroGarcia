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
using FontAwesome.Sharp;
using SistemaVentaAkira.Controller;
using SistemaVentaAkira.View.Empleado;

namespace SistemaVentaAkira.View
{
    public partial class Menu_Empleado : Form
    {
        //Campos
        //private IconButton currentBtn;
        private IconButton currentBtn;
        private Panel bordeIzquierdoBtn;
        private Form formActivo;

        public Menu_Empleado(){
            InitializeComponent();
            bordeIzquierdoBtn = new Panel();
            bordeIzquierdoBtn.Size = new Size(10, 49);
            panelMenu.Controls.Add(bordeIzquierdoBtn);
            invisibilizarSubMenus();
        }
        //Método encargado de cambiar la visibilidad del panel con las opciones
        private void invisibilizarSubMenus(){
            subMenuClientes.Visible = false;
            subMenuProductos.Visible = false;
        }
        //Método encargado de ocultar los sub menus
        private void ocultarSubMenus(){
            if (subMenuClientes.Visible == true) subMenuClientes.Visible = false;
            if (subMenuProductos.Visible == true) subMenuProductos.Visible = false;
        }
        //Cambia la visibilidad a true de los paneles del submenu
        private void mostrarSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                ocultarSubMenus();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        //Posiciona al botón por defecto, es decir imagen luego texto y color de fondo (al no estar seleccionado)
        private void botonNoSeleccionado()
        {
            if (currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(154, 103, 78);
                currentBtn.ForeColor = Color.White;
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;

            }
        }

        //Instancia un fomulario, el cual se visualizará dentro del panel principal
        private void AbrirFormulario<MiForm>() where MiForm : Form, new()
        {
            Form formulario;
            formulario = panelFormularios.Controls.OfType<MiForm>().FirstOrDefault();//Busca en la colecion el formulario
            //si el formulario/instancia no existe
            if (formulario == null)
            {
                formulario = new MiForm();
                formulario.TopLevel = false;
                formulario.FormBorderStyle = FormBorderStyle.None;
                formulario.Dock = DockStyle.Fill;
                panelFormularios.Controls.Add(formulario);
                panelFormularios.Tag = formulario;
                formulario.Show();
                formulario.BringToFront();
                formulario.FormClosed += new FormClosedEventHandler(CerrarFormulario);
            }
            //si el formulario/instancia existe
            else
            {
                formulario.BringToFront();
            }
        }
        //Deshabilita la selección de otro botón/sección
        private void AbrirFormulario()
        {
            ICProductos.Enabled = false;
            IconVentas.Enabled = false;
            ICclientes.Enabled = false;
        }
        //Activa las opciones al cerrar el formulario
        private void CerrarFormulario(object sender, FormClosedEventArgs e)
        {
            ICProductos.Enabled = true;
            IconVentas.Enabled = true;
            ICclientes.Enabled = true;
        }
        //Método que cambia el estilo del botón al ser seleccionado
        private void botonSeleccionado(object botonEnv, Color color)
        {
            if (botonEnv != null)
            {
                botonNoSeleccionado();
                //Boton
                currentBtn = (IconButton)botonEnv;
                currentBtn.BackColor = Color.FromArgb(90, 60, 48);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //Borde izquierdo del boton
               /* bordeIzquierdoBtn.BackColor = color;
                bordeIzquierdoBtn.Location = new Point(0, currentBtn.Location.Y);
                bordeIzquierdoBtn.Visible = true;
                bordeIzquierdoBtn.BringToFront();*/
            }

        }

        private void IconVentas_Click(object sender, EventArgs e)
        {
            botonSeleccionado(sender, Color.FromArgb(255, 171, 145));
            AbrirFormulario<FrmVenta>();
            AbrirFormulario();
        }

        private void ICProductos_Click(object sender, EventArgs e)
        {
            botonSeleccionado(sender, Color.FromArgb(255, 171, 145));

            mostrarSubMenu(subMenuProductos);
        }

        private void ICclientes_Click(object sender, EventArgs e)
        {
            botonSeleccionado(sender, Color.FromArgb(255, 171, 145));
            
            mostrarSubMenu(subMenuClientes);
        }

        private void ICsalir_Click(object sender, EventArgs e)
        {
            botonSeleccionado(sender, Color.FromArgb(255, 171, 145));
            string leyenda = "¿Desea cerrar sesión?";
            string titulo = "Confirmar cierre de Sesión";
            DialogResult respuesta = MessageBox.Show(leyenda, titulo, MessageBoxButtons.YesNoCancel, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //Desactiva los bordes y cambios en botones
            ReiniciaraOrigen();
        }

        private void ReiniciaraOrigen()
        {
            botonNoSeleccionado();
            bordeIzquierdoBtn.Visible = false;
        }

        //Permite desplazar la venta del Menu
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Horario_Tick(object sender, EventArgs e)
        {
            LblHoraAct.Text = "Hora: " + DateTime.Now.ToLongTimeString();
            LblFechaAct.Text = "Fecha: " + DateTime.Now.ToLongDateString();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ICMinimized_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void IBGrillaProductos_Click(object sender, EventArgs e)
        {
            ocultarSubMenus();
            AbrirFormulario<grillaProducto>();
            AbrirFormulario();
        }

        private void IBProductosElim_Click(object sender, EventArgs e)
        {
            ocultarSubMenus();
            AbrirFormulario<FrmProductosEliminados>();
            AbrirFormulario();
        }

        private void IBGrillaCliente_Click(object sender, EventArgs e){
            ocultarSubMenus();
            AbrirFormulario<grillaClientes>();
            AbrirFormulario();
        }

        private void IBClientesElim_Click(object sender, EventArgs e)
        {
            ocultarSubMenus();
            AbrirFormulario<FrmClientesEliminados>();
            AbrirFormulario();
        }

        private void IBInformeVentas_Click(object sender, EventArgs e)
        {
            ocultarSubMenus();
            AbrirFormulario<PlanillaVentas>();
            AbrirFormulario();
        }
    }

}
