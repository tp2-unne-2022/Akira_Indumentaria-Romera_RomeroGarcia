using SistemaVentaAkira.Controller;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace SistemaVentaAkira.View.Proveedor
{
    public partial class grillaProveedor : Form
    {
        public grillaProveedor()
        {
            InitializeComponent();
            this.cargarProveedores();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cargarProveedores()
        {
            Proveedor_Controller proveedores = new Proveedor_Controller();
            this.dgvProveedor.DataSource = proveedores.ConsultarProveedores();
        }

        private void btnAddProveedor_Click(object sender, EventArgs e)
        {
            FrmProveedorRegistrar proveedorNuevo = new FrmProveedorRegistrar();
            proveedorNuevo.Show();
            proveedorNuevo.FormClosed += new FormClosedEventHandler(grillaProveedor_Load);
        }

        private void btnEliminarProveedor_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea eliminar al proveedor?", "Confirmación de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvProveedor.SelectedRows.Count > 0)
                {
                    Proveedor_Controller eliminarProveedor = new Proveedor_Controller();
                    eliminarProveedor.desactivarProveedor(Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value));
                    cargarProveedores();
                }

            }
        }

        private void btnModificarProveedor_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea modificar el proveedor?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvProveedor.SelectedRows.Count > 0)
                {
                    FrmEditarProveedor editarProveedor = new FrmEditarProveedor(Convert.ToInt32(dgvProveedor.CurrentRow.Cells[0].Value));
                    editarProveedor.Show();
                    editarProveedor.FormClosed += new FormClosedEventHandler(grillaProveedor_Load);

                }
                else
                {
                    MessageBox.Show("No hay proveedores para eliminar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }

        private void grillaProveedor_Load(object sender, EventArgs e)
        {
            cargarProveedores();
        }
    }
}
