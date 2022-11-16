using SistemaVentaAkira.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaVentaAkira.View.Proveedor
{
    public partial class FrmProveedoresEliminados : Form
    {
        public FrmProveedoresEliminados()
        {
            InitializeComponent();
            cargarProveedor();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void cargarProveedor()
        {
            Proveedor_Controller proveedores = new Proveedor_Controller();
            this.dgv_Prov.DataSource = proveedores.ConsultarProveedoresInactivos();
        }

        private void btnActivarProveedor_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Activar el proveedor?", "Confirmar el alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgv_Prov.SelectedRows.Count > 0)
                {
                    Proveedor_Controller activarEstado = new Proveedor_Controller();
                    activarEstado.activarProveedor(Convert.ToInt32(dgv_Prov.CurrentRow.Cells[0].Value));
                    cargarProveedor();
                }

            }
        }
    }
}
