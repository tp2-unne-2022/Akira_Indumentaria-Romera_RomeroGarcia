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

namespace SistemaVentaAkira.View
{
    public partial class FrmCategoriasEliminadas : Form
    {
        public FrmCategoriasEliminadas()
        {
            InitializeComponent();
            cargarCategoria();
        }

        private void cargarCategoria()
        {
            Categoria_Controller categorias = new Categoria_Controller();
            this.dgvCategoriaseEliminadas.DataSource = categorias.ConsultarCategoriasEliminadas();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnActivarCategoria_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Desea Activar la categoría?", "Confirmar el alta", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvCategoriaseEliminadas.SelectedRows.Count > 0)
                {
                    Categoria_Controller activarEstado = new Categoria_Controller();
                    activarEstado.activarCategoria(Convert.ToInt32(dgvCategoriaseEliminadas.CurrentRow.Cells[0].Value));
                    cargarCategoria();
                }

            }
        }
    }
}
