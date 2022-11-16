using SistemaVentaAkira.Controller;
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

namespace SistemaVentaAkira.View.Empleado
{
    public partial class FrmClienteLista : Form
    {
        private Cliente_Controller buscarCliente = new Cliente_Controller();
        public FrmClienteLista()
        {
            InitializeComponent();
            cargarClientes();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Para desplazar form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);


        #region Agregar clientes
        private void cargarClientes()
        {
            Cliente_Controller controller_cliente = new Cliente_Controller();
            dgvClientes.DataSource = controller_cliente.ConsultarClientes();

        }

        private void FrmClienteLista_Load(object sender, EventArgs e)
        {
            this.cargarClientes();
        }

        #endregion

        #region Seleccionar un Cliente
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
           if (dgvClientes.SelectedRows.Count > 0)
            {
                FrmVenta formularioVenta = (FrmVenta)Owner;
                formularioVenta.identificador_Cliente = Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value.ToString());
                formularioVenta.tbNombreCliente.Text = dgvClientes.CurrentRow.Cells[1].Value.ToString();
                formularioVenta.tbDNICliente.Text = dgvClientes.CurrentRow.Cells[3].Value.ToString();
                formularioVenta.tbApellidoCliente.Text = dgvClientes.CurrentRow.Cells[2].Value.ToString();
                /*formularioVenta.TxtApellido.Text = DataGridCliente.CurrentRow.Cells[3].Value.ToString();
                formularioVenta.TxtDni.Text = DataGridCliente.CurrentRow.Cells[1].Value.ToString();*/
                this.Close();
            }
            else
            {
               MessageBox.Show("No se ha seleccionado un registro de cliente");
            }
        }
        #endregion

        private void FrmClienteLista_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

      
    }
}
