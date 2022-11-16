using SistemaVentaAkira.Controller;
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
    public partial class view_Producto : Form
    {
        public view_Producto()
        {
            InitializeComponent();
        }

        private void view_Producto_Load(object sender, EventArgs e)
        {
            ObtenerProductosGeneral();
            this.reportViewer1.RefreshReport();
        }

        public void ObtenerProductosGeneral()
        {
            ReporteProducto reportProducts = new ReporteProducto();
            reportProducts.CrearProdProveedor();
            reportProducts.CreateProductoEstReport();
            reportProducts.CreateProductoCatego();

            reportGeneral.DataSource = reportProducts.ListaProdcutos;
            /*
            ArticulosReportBindingSource.DataSource = articulosReport.ListaArticulos;
            ArticulosMarcaBindingSource.DataSource = articulosReport.ListaArticulosMarca;
            ArticuloProveedorBindingSource.DataSource = articulosReport.ListaArticulosProveedor;
            ArticuloRubroBindingSource.DataSource = articulosReport.ListaArticulosRubro;*/

            this.reportViewer1.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
