using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentaAkira.Controller;

namespace SistemaVentaAkira.View
{
    public partial class grillaClientes : Form
    {
        public grillaClientes()
        {
            InitializeComponent();
            cargarClientes();
        }

        #region Agregar cliente
        private void btnAddCliente_Click(object sender, EventArgs e)
        {
            FrmClienteOperacion nuevoCliente = new FrmClienteOperacion();
            nuevoCliente.Show();
            nuevoCliente.FormClosed += new FormClosedEventHandler(grillaClientes_Load);
        }
        #endregion

        #region Eliminar cliente
        private void btnEliminarCliente_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar el cliente?", "Confirmar eliminación", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK){
                if (dgvClientes.SelectedRows.Count > 0){
                    Cliente_Controller cliente_Controller = new Cliente_Controller();
                    cliente_Controller.desactivarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                    cargarClientes();
                }
                else
                {
                    MessageBox.Show("No hay clientes para eliminar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }

        }
        #endregion

        #region Modificar cliente
        private void btnEditarCliente_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea modificar el cliente?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvClientes.SelectedRows.Count > 0)
                {
                    FrmEditarCliente editarCliente = new FrmEditarCliente(Convert.ToInt32(dgvClientes.CurrentRow.Cells[0].Value));
                    editarCliente.Show();
                    editarCliente.FormClosed += new FormClosedEventHandler(grillaClientes_Load);

                }
                else
                {
                    MessageBox.Show("No hay clientes para modificar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Btn cerrar ventana
        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Cargar clientes
        private void cargarClientes() {
            Cliente_Controller controller_cliente = new Cliente_Controller();
            dgvClientes.DataSource = controller_cliente.ConsultarClientes();

        }

        private void grillaClientes_Load(object sender, EventArgs e)
        {
            this.cargarClientes();
        }
        #endregion

        private void grillaClientes_MouseDown(object sender, MouseEventArgs e)
        {

        }
    }
}
