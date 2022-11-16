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
    public partial class FrmProductosEliminados : Form
    {
        public FrmProductosEliminados()
        {
            InitializeComponent();
            this.cargarProductos();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Activación de un producto eliminado
        private void btnActivarProducto_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea activar nuevamente el producto?", "Confirmación de re-activación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                if (dgvProductosEliminados.SelectedRows.Count > 0)
                {
                    Producto_Controller controller_producto = new Producto_Controller();
                    controller_producto.activarProducto(Convert.ToInt32(dgvProductosEliminados.CurrentRow.Cells[0].Value));
                    cargarProductos();
                }
                else
                {
                    MessageBox.Show("No hay productos para activar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Carga de productos eliminados
        private void cargarProductos()
        {
            Producto_Controller controller_producto = new Producto_Controller();
            dgvProductosEliminados.DataSource = controller_producto.ConsultarProductosEliminados();

        }
        #endregion
    }
}
