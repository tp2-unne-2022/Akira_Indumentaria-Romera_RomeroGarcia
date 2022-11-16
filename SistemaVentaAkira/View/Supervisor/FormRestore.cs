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

namespace SistemaVentaAkira.View.Supervisor
{
    public partial class FormRestore : Form
    {
        public FormRestore()
        {
            InitializeComponent();
            ICCargarRestore.Enabled = false;
        }

        private void ICCargarRestore_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de restaurar la Base de Datos?", "Confirmar Restauración", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

            if(resultado == DialogResult.OK)
            {
                BackUpService setDB = new BackUpService();
                bool result = setDB.RestoreDB(TxtDirectorio.Text.ToString());
                if (result)
                {
                    MessageBox.Show("La base de datos se ha restaurado con éxito", "Operación exitosa", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Ocurrió un error en la restauración", "Operación fallida", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
                }
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
        // BuscarBackup.Filter = "SQL SERVER database restore file|.bak";
            BuscarBackup.Title = "Restauración de la base de datos";
            if(BuscarBackup.ShowDialog() == DialogResult.OK)
            {
                TxtDirectorio.Text = BuscarBackup.FileName;
                ICCargarRestore.Enabled = true;
            }
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
