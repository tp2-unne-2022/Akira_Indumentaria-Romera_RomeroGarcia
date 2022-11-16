using SistemaVentaAkira.Controller.Reporte;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentaAkira.View.Reportes
{
    public partial class ArticulosVendidos : Form
    {
        public string fechaInicio;
        public string fechaFinal;
        public ArticulosVendidos()
        {
            InitializeComponent();
        }

        private void ArticulosVendidos_Load(object sender, EventArgs e)
        {

            ObtenerProductos();
            this.reportViewer1.RefreshReport();
        }

        private void ObtenerProductos()
        {
            ReporteProducto producto = new ReporteProducto();
            producto.CrearProdProveedor(fechaInicio, fechaFinal);
            producto.CreateProductoEstReport(fechaInicio, fechaFinal);
            producto.CreateProductoCatego(fechaInicio, fechaFinal);

            ListaProdcutosbindingSource.DataSource = producto.ListaProdcutos;
            ListaProductosCatebindingSource.DataSource = producto.ListaProductosCate;
            ListaProdcutosProveedorbindingSource.DataSource = producto.ListaProdcutosProveedor;

            reportViewer1.RefreshReport();
        }
    }
}
