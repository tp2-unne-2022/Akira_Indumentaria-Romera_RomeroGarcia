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
    public partial class Reporte_ventaMensual : Form
    {
        public Reporte_ventaMensual()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel_contenido_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            viewEmpleadoMensual empleadoMensual = new viewEmpleadoMensual
            {
                anio = dtp_periodoDesde.Value.Year,
                mes = dtp_periodoDesde.Value.Month
            };

            empleadoMensual.ShowDialog();
        }
    }
}
