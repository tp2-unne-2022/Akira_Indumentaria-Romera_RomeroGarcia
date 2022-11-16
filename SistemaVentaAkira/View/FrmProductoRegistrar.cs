using SistemaVentaAkira.Controller;
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
using SistemaVentaAkira.View.Clases_Validacion;

namespace SistemaVentaAkira.View
{
    public partial class FrmProductoRegistrar : Form
    {
        private bool precioVenta;
        private bool precioCompra;
        private bool stock;
        private bool stockMinimo;
        private bool categoriaPro;
        private bool nombre;
        private bool proveedor;
        //Constructor de la clase registrar producto
        public FrmProductoRegistrar()
        {
            InitializeComponent();
        }
        //Evento click para cerrar la ventana
        private void IcClose_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Cerrar Registro?", "Registro de producto", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            if (respuesta == DialogResult.Yes)
            {
                this.Close();
            }
        }
        //Evento click para cancelar, limpiando los campos cargados
        private void btnCancelarRegistro_Click(object sender, EventArgs e)
        {
            restaurarCampos();
        }
        //Se restauran los campos que se cargaron
        private void restaurarCampos()
        {
            tbNombreProducto.Clear();
            Validaciones.LimpiarProvider(Error_producto, tbNombreProducto);
            cbProveedor.SelectedIndex = 0;
            cbCategoríaProducto.SelectedIndex = 0;

            Validaciones.LimpiarProviderV2(Error_producto, txtPrecioVenta, txtPrecioCompra);
            txtPrecioCompra.Clear();
            txtPrecioVenta.Clear();

            Validaciones.LimpiarProviderV2(Error_producto, txtStock, txtStockMinimo);
            txtStock.Clear();
            txtStockMinimo.Clear();
        }

        //Se lo utilza para desplazar desde la borra de título a la ventana
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void panelTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //Se cargan en el comboBox las categoría registradas en la BD
        private void cargarCategorias()
        {
            Producto_Controller listarCateg = new Producto_Controller();
            List<object> listaCate = listarCateg.ConsultarCategorias();
            foreach (var categoria in listaCate)
            {
                cbCategoríaProducto.Items.Add(categoria.ToString());
            }
            this.cbCategoríaProducto.SelectedIndex = 0;
        }
        //Al momento de cargar el formulario, se cargaran las categorias y proveedores
        private void FrmProductoRegistrar_Load(object sender, EventArgs e)
        {
            this.cargarCategorias();
            this.cargarProveedor();
        }
        //Se cargan al comboBox los proveedores registrados en la BD
        private void cargarProveedor()
        {
            Producto_Controller listarProv = new Producto_Controller();
            List<object> listarProvedores = listarProv.ConsultarProveedor();
            foreach (var proveedor in listarProvedores)
            {
                cbProveedor.Items.Add(proveedor.ToString());
            }
            this.cbProveedor.SelectedIndex = 0;
        }

        private void btnRegistrarProducto_Click(object sender, EventArgs e)
        {
            /*if(txtPrecioCompra.Text == System.String.Empty || txtPrecioVenta.Text == System.String.Empty || txtStock.Text == System.String.Empty || tbNombreProducto.Text == System.String.Empty || cbCategoríaProducto.Text == "")
            {
                MessageBox.Show("Hay campos sin completar", "Completar campos", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Producto_Controller agregarProducto = new Producto_Controller();
                agregarProducto.AgregarProducto(cbCategoríaProducto.Text, tbNombreProducto.Text, Convert.ToDecimal(txtPrecioCompra.Text), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text));

                MessageBox.Show("Se añadió con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/

            if (this.validarCamposPro())
            {
                Producto_Controller agregarProducto = new Producto_Controller();
                agregarProducto.AgregarProducto(cbCategoríaProducto.Text, cbProveedor.Text, tbNombreProducto.Text, Convert.ToDecimal(txtPrecioCompra.Text), Convert.ToDecimal(txtPrecioVenta.Text), Convert.ToInt32(txtStock.Text), Convert.ToInt32(txtStockMinimo.Text));

                MessageBox.Show("Se añadió con éxito", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                restaurarCampos();
            }
            else
            {
                MessageBox.Show("Campos incorrectos", "Registro de producto", MessageBoxButtons.OK, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
            }
        }

        private void txtPrecioCompra_TextChanged(object sender, EventArgs e)
        {
            Validaciones.validarPrecio(Error_producto, txtPrecioCompra, txtPrecioVenta, ref precioCompra);
        }

        private void txtPrecioVenta_TextChanged(object sender, EventArgs e)
        {
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
        //Si todos los campos cumplieron las validaciones, retornará true
        private bool validarCamposPro()
        {
            Validaciones.validarPrecio(Error_producto, txtPrecioCompra, txtPrecioVenta, ref precioCompra);
            return (stock && stockMinimo && nombre && precioCompra && precioVenta);
        }

        private void cbProveedor_TextChanged(object sender, EventArgs e)
        {
            Validaciones.ValidarComboBox(Error_producto, cbProveedor, ref proveedor);
        }

       
    }
}
