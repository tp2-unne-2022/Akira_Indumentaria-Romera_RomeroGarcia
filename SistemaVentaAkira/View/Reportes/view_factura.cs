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
    public partial class view_factura : Form
    {
        public long posicion;
        public view_factura()
        {
            InitializeComponent();
            this.ObtenerFactura();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ObtenerFactura();
            this.reportViewer1.RefreshReport();
        }

        private void ObtenerFactura()
        {
            ReporteFacturas factura = new ReporteFacturas();
            factura.CrearReporteFact(posicion);
            reporteFacturasBindingSource.DataSource = factura.ListaFacturas;
            this.reportViewer1.RefreshReport();
        }
    }
}
