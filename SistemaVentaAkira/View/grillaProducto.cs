using SistemaVentaAkira.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaVentaAkira.View
{
    public partial class grillaProducto : Form
    {
        //En el constructor se inicializaran los componentes y cargará los productos en el datagrid
        public grillaProducto()
        {
            InitializeComponent();
            cargarProductos();
        }
        #region btn cerrar ventana
        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

        #region Evento click para mostrar el formulario de registro de producto
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            FrmProductoRegistrar productoNuevo = new FrmProductoRegistrar();
            productoNuevo.Show();
            productoNuevo.FormClosed += new FormClosedEventHandler(grillaProducto_Load);
        }
        #endregion

        #region Evento click para eliminar un producto seleccionado
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea eliminar el producto?", "Confirmación de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    Producto_Controller controller_producto = new Producto_Controller();
                    controller_producto.desactivarProducto(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value));
                    cargarProductos();
                }
                else
                {
                    MessageBox.Show("No hay productos para eliminar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }

        }

        #endregion

        #region Evento click para mostrar el formulario de modificación de producto
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea modificar el producto?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvProductos.SelectedRows.Count > 0)
                {
                    FrmEditarProducto editarProducto = new FrmEditarProducto(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value));
                    editarProducto.Show();
                    editarProducto.FormClosed += new FormClosedEventHandler(grillaProducto_Load);

                }
                else
                {
                    MessageBox.Show("No hay categorías para eliminar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Se cargan los productos registrados en la BD
        private void cargarProductos()
        {
            Producto_Controller productos = new Producto_Controller();
            dgvProductos.DataSource = productos.ConsultarProductos();
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void grillaProducto_Load(object sender, EventArgs e)
        {
            this.cargarProductos();
        }
    }
}
