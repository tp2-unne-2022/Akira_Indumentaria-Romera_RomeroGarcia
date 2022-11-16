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
    public partial class grillaCategoria : Form
    {
        public grillaCategoria()
        {
            InitializeComponent();
            cargarCategoria();
        }

        private void cargarCategoria()
        {
            Categoria_Controller categorias = new Categoria_Controller();
            this.dgvCategorias.DataSource = categorias.ConsultarCategorias();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnaddCategoria_Click(object sender, EventArgs e)
        {
            FrmCategoriaOperacion agregarCategoria = new FrmCategoriaOperacion();
            agregarCategoria.Show();
            agregarCategoria.FormClosed += new FormClosedEventHandler(grillaCategoria_Load);
        }

        private void btnEliminarCategoria_Click(object sender, EventArgs e)
        {
            DialogResult respuesta= MessageBox.Show("Desea eliminar la categoría?", "Confirmación de eliminación", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if(respuesta == DialogResult.OK)
            {
                if( dgvCategorias.SelectedRows.Count > 0)
                {
                    Categoria_Controller eliminarCategoria = new Categoria_Controller();
                    eliminarCategoria.desactivarCategoria(Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value));
                    cargarCategoria();
                }
                
            }
        }

        private void btnModificarCategoria_Click(object sender, EventArgs e)
        {

            DialogResult respuesta = MessageBox.Show("Desea modificar la categoría?", "Confirmar", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

            if (respuesta == DialogResult.OK)
            {
                if (dgvCategorias.SelectedRows.Count > 0)
                {

                    FrmEditarCategoria editarCategoria = new FrmEditarCategoria(Convert.ToInt32(dgvCategorias.CurrentRow.Cells[0].Value));
                    editarCategoria.Show();
                    editarCategoria.FormClosed += new FormClosedEventHandler(grillaCategoria_Load);

                }
                else
                {
                    MessageBox.Show("No hay categorías para eliminar", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }

        private void grillaCategoria_Load(object sender, EventArgs e)
        {
            cargarCategoria();
        }

 
    }
}
