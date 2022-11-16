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
    public partial class FrmEditarProducto : Form
    {
        private bool precioVenta;
        private bool precioCompra;
        private bool stock;
        private bool stockMinimo;
        private bool categoriaPro;
        private bool nombre;
        private bool proveedor;
        //Constructor de la clase modificar producto
        public FrmEditarProducto(int p_index)
        {
            InitializeComponent();
            this.cargarCampos(p_index);
        }

        #region Evento click para cerrar la ventana
        private void IcClose_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Cerrar Modificación?", "Modificar producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        #endregion

        #region Evento click para cancelar, limpiando los campos cargados
        private void btnCancelarModificacion_Click(object sender, EventArgs e)
        {
            cargarCampos(Convert.ToInt32(tbIDProd.Text));
        }
        #endregion

        #region Código que permite desplazar desde la barra de título a la ventana
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

        #region Validación de campos para realizar la edición
        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            Validaciones.validarPrecio(Error_producto, txtPrecioCompra, txtPrecioVenta, ref precioCompra);
            // Validaciones.validarPrecio(Error_producto, txtPrecioVenta, txtPrecioCompra, ref precioCompra);
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
            //Validaciones.validarPrecio(Error_producto, txtPrecioVenta, ref precioVenta);
            Validaciones.validarPrecio(Error_producto, txtPrecioCompra, txtPrecioVenta, ref precioVenta);
        }

        private void txtStock_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarNumeroEntero(Error_producto, txtStock, ref stock);
            Validaciones.ValidarStock(Error_producto, txtStock, txtStockMinimo);
        }

        private void txtStockMinimo_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarNumeroEntero(Error_producto, txtStockMinimo, ref stockMinimo);
            Validaciones.ValidarStock(Error_producto, txtStock, txtStockMinimo);
        }

        private void tbNombreProducto_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarCadena(Error_producto, tbNombreProducto, ref nombre);
        }

        private void cbCategoríaProducto_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarComboBox(Error_producto, cbCategoríaProducto, ref categoriaPro);
        }

        private void cbProveedor_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarComboBox(Error_producto, cbProveedor, ref proveedor);
        }

        private void txtStock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtStockMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private bool validarCamposPro()
        {
            Validaciones.validarPrecio(Error_producto, txtPrecioCompra, txtPrecioVenta, ref precioCompra);
            return (stock && stockMinimo && nombre && precioCompra && precioVenta);
        }

        #endregion

        #region Actualizar producto 
        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            if (this.validarCamposPro()){
                Producto_Controller controller_producto = new Producto_Controller();
                controller_producto.modificarProducto(Convert.ToInt32(tbIDProd.Text), cbCategoríaProducto.Text, cbProveedor.Text, tbNombreProducto.Text, Convert.ToDecimal(txtPrecioCompra.Text), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtStockMinimo.Text));
                MessageBox.Show("Producto modificado con éxito", "Operación exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);
                cargarCampos(Convert.ToInt32(tbIDProd.Text));
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Modificar producto", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        #endregion

        #region Cargar campos a partir del producto seleccionado
        private void cargarCampos(int p_index) {
            Producto_Controller controlador_Producto = new Producto_Controller();
            Object[] producto = controlador_Producto.consultarProducto(p_index);

            tbIDProd.Text = producto[0].ToString();

            tbNombreProducto.Text = producto[3].ToString();

            //Se cargan los comboBoxs para poder hacer la comparación
            this.cargarCategorias();
            this.cargarProveedor();

            for (int i = 0; i < cbProveedor.Items.Count; i++) {
                if (cbProveedor.Items[i].ToString() == producto[2].ToString()) {
                    cbProveedor.SelectedIndex = i;
                }
            }

            for (int i = 0; i < cbCategoríaProducto.Items.Count; i++) {
                if (cbCategoríaProducto.Items[i].ToString() == producto[1].ToString()) {
                    cbCategoríaProducto.SelectedIndex = i;
                }
            }

            txtPrecioCompra.Text = producto[5].ToString();

            txtPrecioVenta.Text = producto[4].ToString();

            txtStock.Text = producto[6].ToString();

            txtStockMinimo.Text = producto[8].ToString();

        }
        #endregion

        #region Restauración de campos (limpiar erorres)
        private void restaurarCampos()
        {
            tbNombreProducto.Clear();
            Validaciones.LimpiarProvider(Error_producto, tbNombreProducto);
            //cbProveedor.SelectedIndex = 0;
            //cbCategoríaProducto.SelectedIndex = 0;

            Validaciones.LimpiarProviderV2(Error_producto, txtPrecioVenta, txtPrecioCompra);
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();

            Validaciones.LimpiarProviderV2(Error_producto, txtStock, txtStockMinimo);
            txtStock.Clear();
            txtStockMinimo.Clear();
        }
        #endregion

        #region Carga de combo box 
        private void FrmEditarProducto_Load(object sender, EventArgs e)
        {
            
        }

        //Se cargan al comboBox los proveedores registrados en la BD
        private void cargarProveedor(){
            Producto_Controller controller_producto = new Producto_Controller();
            List<object> proveedores = controller_producto.ConsultarProveedor();
            foreach (var proveedor in proveedores){
                cbProveedor.Items.Add(proveedor.ToString());
            }
        }
        //Se cargan al comboBox las categorías registrados en la BD
        private void cargarCategorias(){
            Producto_Controller controller_producto = new Producto_Controller();
            List<object> categorias = controller_producto.ConsultarCategorias();
            foreach (var categoria in categorias){
                cbCategoríaProducto.Items.Add(categoria.ToString());
            }
        }

        #endregion  
    }
}
