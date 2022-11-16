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
    public partial class grillaUsuarios : Form
    {
        
        public grillaUsuarios()
        {
            InitializeComponent();
            cargarUsuarios();
        }

        #region Agregar usuario
        private void btnAddUsuario_Click(object sender, EventArgs e)
        {
            FrmUsuarioOperacion nuevoUsuario = new FrmUsuarioOperacion();
            nuevoUsuario.Show();
            nuevoUsuario.FormClosed += new FormClosedEventHandler(grillaUsuarios_Load);
        }
        #endregion

        #region Eliminar usuario
        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar al usuario?", "Confirmar eliminación", MessageBoxButtons.OK, MessageBoxIcon.Question);

            if (respuesta == DialogResult.OK){
                    if (dgvUsuarios.SelectedRows.Count > 0){
                        Usuario_controller controlador_usuario = new Usuario_controller();
                        controlador_usuario.desactivarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
                        cargarUsuarios();
                    }
                    else
                    {
                        MessageBox.Show("No hay usuarios para eliminar", "Operación inválida", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                    }

                }
        }
        #endregion

        #region Editar usuario
        private void btnEditarUsuario_Click(object sender, EventArgs e)
        {
            FrmEditarUsuario editarUsuario = new FrmEditarUsuario(Convert.ToInt32(dgvUsuarios.CurrentRow.Cells[0].Value));
            editarUsuario.Show();
            editarUsuario.FormClosed += new FormClosedEventHandler(grillaUsuarios_Load);

        }
        #endregion

        #region Cargar usuarios
        private void cargarUsuarios()
        {
            Usuario_controller controlador_usuario = new Usuario_controller();
            dgvUsuarios.DataSource = controlador_usuario.ConsultarUsuarios();
        }

        private void grillaUsuarios_Load(object sender, EventArgs e)
        {
            cargarUsuarios();
        }
        #endregion
        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}
