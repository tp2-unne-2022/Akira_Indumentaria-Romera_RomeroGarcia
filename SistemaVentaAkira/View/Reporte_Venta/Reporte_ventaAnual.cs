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

namespace SistemaVentaAkira.View.Reporte_Venta
{
    public partial class Reporte_ventaAnual : Form
    {
        public Reporte_ventaAnual()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            viewEmpleadoAnual empleadoAnual = new viewEmpleadoAnual
            {
                anio = dtp_periodoDesde.Value.Year,
                anioHasta = dtp_periodoHasta.Value.Year,
            };

            empleadoAnual.ShowDialog();
        }
    }
}
