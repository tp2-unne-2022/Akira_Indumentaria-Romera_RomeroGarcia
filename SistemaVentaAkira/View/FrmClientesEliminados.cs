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
    public partial class FrmClientesEliminados : Form
    {
        public FrmClientesEliminados()
        {
            InitializeComponent();
            cargarClientesEliminados();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Cargar clientes eliminados
        private void cargarClientesEliminados()
        {
            Cliente_Controller controller_cliente = new Cliente_Controller();
            dgvClientesEliminados.DataSource = controller_cliente.ConsultarClientesDesactivos();

        }
        #endregion

        #region Activar cliente
        private void btnActivarCliente_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea activar nuevamente al cliente?", "Confirmación de re-activación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                if (dgvClientesEliminados.SelectedRows.Count > 0)
                {
                    Cliente_Controller controlador_cliente = new Cliente_Controller();
                    controlador_cliente.activarCliente(Convert.ToInt32(dgvClientesEliminados.CurrentRow.Cells[0].Value));
                    cargarClientesEliminados();
                }
                else
                {
                    MessageBox.Show("No hay clientes para activar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion
    }
}
