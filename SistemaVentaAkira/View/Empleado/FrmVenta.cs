using SistemaVentaAkira.Controller;
using SistemaVentaAkira.View.Reportes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentaAkira.View.Empleado
{
    public partial class FrmVenta : Form
    {
        public int? identificador_Cliente = null;
        public int? identificador_Articulo = null;
        private bool cantidad = false;
        private Cliente_Controller clienteSeleccionado = new Cliente_Controller();
        private Producto_Controller productoSeleccionado = new Producto_Controller();


        public FrmVenta()
        {
            InitializeComponent();
            cargarFormaPago();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
            this.Close();
        }

        #region Cargar Forma de Pago
        private void cargarFormaPago()
        {
            FormasPago listarFormaPago = new FormasPago();
            List<object> listarFp = listarFormaPago.ConsultarFormaPago();
            foreach (var formaP in listarFp)
            {
                cbFormaPago.Items.Add(formaP.ToString());
            }
            this.cbFormaPago.SelectedIndex = 0;
        }
        #endregion

        #region Botón de seleccionar cliente
        //Se asigna el formulario de listado como propiedad de Venta
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            FrmClienteLista buscarCliente = new FrmClienteLista();
            AddOwnedForm(buscarCliente);
            buscarCliente.ShowDialog();
        }
        #endregion

        #region Botón para seleccionar Producto
        private void IcBuscar_Click(object sender, EventArgs e)
        {
            //En el caso de que se esté operando un producto y no se agregue a la lista se venta, este se restaura a su stock inicial
            if (identificador_Articulo != null)
            {
                Venta_Controller c_venta = new Venta_Controller();
                c_venta.restaurarStockProcesoVenta(Convert.ToInt32(identificador_Articulo));
                limpiarCamposProducto();
            }

            FrmListaArticulos buscarProducto = new FrmListaArticulos(dgvListaVenta);
            AddOwnedForm(buscarProducto);
            buscarProducto.ShowDialog();
        }
        #endregion

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            LblFecha.Text = "Fecha: " + DateTime.Now.ToString("dd/MM/yy");
            LblEmpleado.Text = "Empleado: " + SesionUser.Us_nombre;
        }

        #region Se calcula el total a abonar
        private void valorTotal()
        {
            
            if (dgvListaVenta.Rows.Count > 0)
            {
                decimal totalTemporal = 0;

                for (int i = 0; i < dgvListaVenta.RowCount ; i++)
                {
                    totalTemporal += Convert.ToDecimal(dgvListaVenta.Rows[i].Cells[4].Value.ToString());
                }

                txtTotal.Text = totalTemporal.ToString();
            }
            else
            {
                txtTotal.Text = "0";
            }
        }
        #endregion

        #region Agregar producto a la lista de venta

        private void btnAgregar_Click(object sender, EventArgs e)
        {

            if (identificador_Articulo != null)
            {
                Object[] producto = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));
                string productoID = producto[0].ToString();
               
                    if(txtCantidad.Text != String.Empty && Convert.ToInt32(txtCantidad.Text) > 0) 
                    {
                        int cantidad = Convert.ToInt32(txtCantidad.Text);
                        decimal precio = Convert.ToDecimal(txtPrecio.Text);
                        decimal subtotal = (cantidad * precio);

                        
                            dgvListaVenta.Rows.Add(producto[0].ToString(), producto[3].ToString(), precio, cantidad, subtotal);

                            valorTotal();
                            limpiarCamposProducto();

                            Venta_Controller c_venta = new Venta_Controller();
                            c_venta.actualizarStockProcesoVenta(Convert.ToInt32(identificador_Articulo), cantidad);
                            identificador_Cliente = null;
                            identificador_Articulo = null;
                            this.cantidad = false;
                        
                    }
                    else
                    {
                        MessageBox.Show("Ingrese un valor de cantidad válido", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
            }
            else
            {
                MessageBox.Show("Debe seleccionar un producto", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            

        }
        #endregion

        #region Eliminar el producto de la grilla
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            Venta_Controller c_venta = new Venta_Controller();
            if (dgvListaVenta.SelectedRows.Count > 0)
            {
                Object[] prod = productoSeleccionado.consultarProducto(Convert.ToInt32(dgvListaVenta.CurrentRow.Cells[0].Value));
                int identificadorProd = Convert.ToInt32(prod[0].ToString());

                c_venta.restaurarStockProcesoVenta(identificadorProd);
                eliminarProducto(identificadorProd);
                valorTotal();
            }
            else
            {
                MessageBox.Show("La grilla se encuentra vacía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void eliminarProducto(int p_index)
        {
            for (int i = 0; i < dgvListaVenta.RowCount; i++)
            {
                if (Convert.ToInt32(dgvListaVenta.Rows[i].Cells[0].Value.ToString()) == p_index)
                {
                    dgvListaVenta.Rows.RemoveAt(i);
                    break;
                }
            }
        }
        #endregion

        #region Modificar Producto agregado
        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (dgvListaVenta.SelectedRows.Count > 0)
            {
                Object[] prod = productoSeleccionado.consultarProducto(Convert.ToInt32(dgvListaVenta.CurrentRow.Cells[0].Value));
                int identificadorProd = Convert.ToInt32(prod[0].ToString());

                identificador_Articulo = identificadorProd;

                txt_Stock.Text = prod[7].ToString();
                txtProducto.Text = prod[3].ToString();
                txtPrecio.Text = prod[5].ToString();
                txtCantidad.Text = dgvListaVenta.CurrentRow.Cells[3].Value.ToString();

                eliminarProducto(identificadorProd);
                valorTotal();
            }
            else
            {
                MessageBox.Show("La grilla se encuentra vacía", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        #endregion

        #region Cancelar Venta
        private void IcCancelar_Click(object sender, EventArgs e)
         {
                DialogResult ask = MessageBox.Show("Desea cancelar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                {
                    LimpiarCampos();
                }      
         }

        private void LimpiarCampos()
        {
            restaurarStocks();
            limpiarCamposProducto();
            limpiarCamposCliente();
            limpiarListaVenta();
            identificador_Articulo = null;
            identificador_Cliente = null;
            cantidad = false;
        }

        private void limpiarCamposProducto()
        {
            cbFormaPago.SelectedValue = 0;
            txtProducto.Clear();
            txtCantidad.Text = "";
            txtPrecio.Clear();
            txt_Stock.Clear();
        }
        private void limpiarCamposCliente()
        {
            tbNombreCliente.Clear();
            tbApellidoCliente.Clear();
            tbDNICliente.Clear();
        }
        private void limpiarListaVenta()
        {
            dgvListaVenta.Rows.Clear();
            dgvListaVenta.Refresh();
            txtTotal.Text = "0";
        }

        #endregion

        #region Registrar venta
        private void IcCobrar_Click(object sender, EventArgs e)
        {
            if (tbNombreCliente.Text == System.String.Empty || tbApellidoCliente.Text == System.String.Empty || tbDNICliente.Text == System.String.Empty || dgvListaVenta.Rows.Count == 0)
            {
                MessageBox.Show("Campos incompletos", "Operación inválida", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DialogResult ask = MessageBox.Show("¿Desea concretar la venta?", "Confirmación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
                if (ask == DialogResult.Yes)
                { 
                    Venta_Controller controller_venta = new Venta_Controller();
                    long codigo_factura =  controller_venta.registrarCabeceraVenta(SesionUser.Id_usuario, cbFormaPago.Text, tbDNICliente.Text, Convert.ToDecimal(txtTotal.Text.ToString()));

                
                    if (dgvListaVenta.Rows.Count > 0)
                    {
                        for (int i = 0; i < dgvListaVenta.RowCount; i++)
                        {
                            controller_venta.registrarDetalleVenta(codigo_factura, Convert.ToInt32(dgvListaVenta.Rows[i].Cells[0].Value.ToString()), Convert.ToInt32(dgvListaVenta.Rows[i].Cells[3].Value.ToString()), Convert.ToDecimal(dgvListaVenta.Rows[i].Cells[2].Value.ToString()));
                        }
                    }
                    view_factura nuevoFact = new view_factura();
                    nuevoFact.posicion = codigo_factura;
                    nuevoFact.ShowDialog();
                    LimpiarCampos();
                    identificador_Cliente = null;
                    identificador_Articulo = null;
                    this.cantidad = false;
                }

                    
            }

        }
        #endregion

        #region Restaurar stocks
        private void restaurarStocks()
        {
            Venta_Controller c_venta = new Venta_Controller();
            if (dgvListaVenta.Rows.Count > 0)
            {
                for (int i = 0; i < dgvListaVenta.RowCount; i++)
                {
                    c_venta.restaurarStockProcesoVenta(Convert.ToInt32(dgvListaVenta.Rows[i].Cells[0].Value.ToString()));
                }
            }
        }
        #endregion

        #region Actualización del campo "Reserva" para permitir que múltiples usuarios puedan realizar una venta al mismo tiempo
        private void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            Venta_Controller c_venta = new Venta_Controller();

            //Se verifica si se está operando un producto para agregar a la lista de venta
            if (identificador_Articulo != null)
            {
                //Se buscan los datos del producto seleccionado
                object[] producto = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));

                //Si el operador completó el campo cantidad, entonces se realizan las validaciones correspondientes para actualizar el campo "Reserva"
                if (txtCantidad.Text != string.Empty)
                {
                    int reserva = Convert.ToInt32(producto[7]);
                    int cantidad = Convert.ToInt32(txtCantidad.Text);
                    int stock_min = Convert.ToInt32(producto[8]);

                    //Se verifica que se mantenga stock para cubrir el stock mínimo
                    if (stock_min <= (reserva - cantidad))
                    {
                        c_venta.actualizarStockProcesoVenta(Convert.ToInt32(identificador_Articulo), Convert.ToInt32(txtCantidad.Text));
                        object[] producto_actualizado = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));
                        txt_Stock.Text = Convert.ToString(producto_actualizado[7]);
                    }
                    else
                    {
                        //Se vuelve a restaurar el stock para contemplar el caso en el se llega al stock mínimo (por consecuencia del evento TextChanged)
                        c_venta.restaurarStockProcesoVenta(Convert.ToInt32(identificador_Articulo));
                        object[] producto_reactualizado = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));
                        int reserva_actualizada = Convert.ToInt32(producto_reactualizado[7]);

                        //Se vuelve a verificar que se mantenga stock para cubrir el stock mínimo
                        if (stock_min <= (reserva_actualizada - cantidad))
                        {
                            c_venta.actualizarStockProcesoVenta(Convert.ToInt32(identificador_Articulo), Convert.ToInt32(txtCantidad.Text));

                            object[] producto_actualizado = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));

                            txt_Stock.Text = Convert.ToString(producto_actualizado[7]);
                        }
                        else //Si la cantidad requerida sobrepasa el stock mínimo
                        {
                            object[] producto_actualizado = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));
                            txt_Stock.Text = Convert.ToString(producto_actualizado[7]);
                            txtCantidad.Text = "";
                            MessageBox.Show("Stock no suficiente", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        }

                    }
                }
                else //Si la cantidad está vacia (el operador borra el contenido del campo cantidad) se asume cantidad = 0
                {
                    c_venta.restaurarStockProcesoVenta(Convert.ToInt32(identificador_Articulo));
                    object[] producto_actualizado = productoSeleccionado.consultarProducto(Convert.ToInt32(identificador_Articulo));
                    txt_Stock.Text = Convert.ToString(producto_actualizado[7]);
                }
               
            }

        }

        #endregion

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            FrmClienteOperacion nuevoCliente = new FrmClienteOperacion();
            nuevoCliente.Show();
            nuevoCliente.FormClosed += new FormClosedEventHandler(FrmVenta_Load);
        }

        private void FrmVenta_Load(object sender, EventArgs e)
        {

        }
    }
}
