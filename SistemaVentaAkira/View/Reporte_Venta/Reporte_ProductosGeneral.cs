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
    public partial class Reporte_ProductosGeneral : Form
    {
        public Reporte_ProductosGeneral()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            
            ArticulosVendidos articulosGeneral = new ArticulosVendidos
            {
                fechaInicio = dtp_periodoDesde.Value.ToString("yyyy-MM -dd"),
                fechaFinal = dtp_periodoHasta.Value.ToString("yyyy-MM -dd"),
            };

            articulosGeneral.ShowDialog();
        }
    }
}
