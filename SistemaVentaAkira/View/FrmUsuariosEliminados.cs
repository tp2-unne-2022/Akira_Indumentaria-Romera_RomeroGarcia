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

namespace SistemaVentaAkira.View
{
    public partial class FrmUsuariosEliminados : Form
    {
        public FrmUsuariosEliminados()
        {
            InitializeComponent();
            this.cargarUsuariosEliminados();
        }

        private void btnCancelar_Click(object sender, EventArgs e){
            this.Close();
        }

        private void IcClose_Click(object sender, EventArgs e){
            this.Close();
        }

        #region Activar usuario
        private void btnActivarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea activar nuevamente al usuario?", "Confirmación de re-activación", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK)
            {
                if (dgvUsuariosEliminados.SelectedRows.Count > 0)
                {
                    Usuario_controller controlador_usuario = new Usuario_controller();
                    controlador_usuario.activarUsuario(Convert.ToInt32(dgvUsuariosEliminados.CurrentRow.Cells[0].Value));
                    cargarUsuariosEliminados();
                }
                else
                {
                    MessageBox.Show("No hay usuarios para activar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                }

            }
        }
        #endregion

        #region Cargar usuarios eliminados
        private void cargarUsuariosEliminados()
        {
            Usuario_controller controlador_usuario = new Usuario_controller();
            dgvUsuariosEliminados.DataSource = controlador_usuario.ConsultarUsuariosDesactivos();
        }
        #endregion

    }
}
