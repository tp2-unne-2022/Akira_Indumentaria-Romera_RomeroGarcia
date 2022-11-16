using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaVentaAkira.Controller;

namespace SistemaVentaAkira.View.Empleado
{
    public partial class PlanillaVentas : Form
    {
        public PlanillaVentas()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrarVentas_Click(object sender, EventArgs e)
        {
            if (dtFechaFin.Value.Date < dtFechaInicio.Value.Date)
            {
                MessageBox.Show("Rango de fechas incorrecto", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
            else
            {
                Venta_Controller controller_venta = new Venta_Controller();
                dgvVentas.DataSource = controller_venta.filtrarVentas(dtFechaInicio.Value, dtFechaFin.Value);

            }
        }
    }
}
