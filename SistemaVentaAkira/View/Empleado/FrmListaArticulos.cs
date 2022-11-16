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
    public partial class FrmListaArticulos : Form
    {
        DataGridView DGVListaVenta;
        public FrmListaArticulos(DataGridView p_dgvListaVenta)
        {
            InitializeComponent();
            cargarProductos();
            DGVListaVenta = p_dgvListaVenta;
             
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
            cargarProductos();
        }

        private void FrmListaArticulos_Load(object sender, EventArgs e)
        {
            cargarProductos();
        }

        #region Se cargan los productos registrados en la BD
        private void cargarProductos()
        {
            Producto_Controller productos = new Producto_Controller();
            dgvProductos.DataSource = productos.ConsultarProductos();
        }
        #endregion

        //Para desplazar form
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void FrmListaArticulos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {

            if (dgvProductos.SelectedRows.Count > 0)
            {
                Venta_Controller c_venta = new Venta_Controller();
                FrmVenta formularioVenta = (FrmVenta)Owner;
                bool productoExistente = false;

                //Se verifica que el producto seleccionado no exista en la lista de venta actual
                int ID_productoSeleccionado = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());

                for (int i = 0; i < DGVListaVenta.RowCount; i++)
                {
                    if (Convert.ToInt32(DGVListaVenta.Rows[i].Cells[0].Value.ToString()) == ID_productoSeleccionado)
                    {
                        productoExistente = true;
                    }
                }

                if (productoExistente)
                {
                    MessageBox.Show("El producto ya se ha agregado a la lista de venta", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    formularioVenta.identificador_Articulo = Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString());
                    formularioVenta.txtProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
                    formularioVenta.txtPrecio.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
                    formularioVenta.txtCantidad.Text = "1";
                    c_venta.actualizarStockProcesoVenta(Convert.ToInt32(Convert.ToInt32(dgvProductos.CurrentRow.Cells[0].Value.ToString())), 1);
                    formularioVenta.txt_Stock.Text = (Convert.ToInt32(dgvProductos.CurrentRow.Cells[7].Value) - 1).ToString();
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("No existen productos para seleccionar", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
