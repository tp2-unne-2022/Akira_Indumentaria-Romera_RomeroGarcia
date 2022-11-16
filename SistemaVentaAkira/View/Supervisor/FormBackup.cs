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

namespace SistemaVentaAkira.View.Supervisor
{
    public partial class FormBackup : Form
    {
        public BackUpService backUp = new BackUpService();
        public FormBackup()
        {
            InitializeComponent();
        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void IcCrarBackup_Click(object sender, EventArgs e)
        {
            string name_BD = "Akira_Indumentaria";
            var fechaRespaldo = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();
            var horaRespaldo = DateTime.Now.Hour.ToString() + "-" + DateTime.Now.Minute.ToString();
            string nombreRespaldo = name_BD + "-" + txtNombre.Text + "-" + fechaRespaldo + "-" + horaRespaldo;
            string direccion = TxtDirectorio.Text + @"\" + nombreRespaldo+".bak";
            bool estado = backUp.BackUpGrabar(nombreRespaldo, direccion);


            if (estado)
            {
                MessageBox.Show("Respaldo realizado con éxito!!", "Información", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("No fue posible realizar el respaldo", "Advertencia", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }

        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (fBD_direccion.ShowDialog() == DialogResult.OK)
            {
                TxtDirectorio.Text = fBD_direccion.SelectedPath;
            }
        }
    }
}
