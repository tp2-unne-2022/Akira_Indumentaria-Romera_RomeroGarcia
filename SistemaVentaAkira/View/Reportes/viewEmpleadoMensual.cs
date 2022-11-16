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
    public partial class viewEmpleadoMensual : Form
    {
        public int anio;
        public int mes;
        public viewEmpleadoMensual()
        {
            InitializeComponent();
        }

        private void viewEmpleadoMensual_Load(object sender, EventArgs e)
        {
            this.reportViewer1.RefreshReport();
            this.ObtenerEmpleados();
            this.reportViewer1.RefreshReport();
        }

        private void ObtenerEmpleados()
        {
            ReporteEmpleados empleados = new ReporteEmpleados();
            empleados.CrearListaEmpleadoMensual(anio, mes);
            this.reporteFacturasBindingSource.DataSource = empleados.listaEmpleadoMensual;
            this.reportViewer1.RefreshReport();
        }
    }
}
