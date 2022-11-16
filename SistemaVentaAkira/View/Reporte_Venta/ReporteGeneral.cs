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
    public partial class ReporteGeneral : Form
    {
        public ReporteGeneral()
        {
            InitializeComponent();
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IcClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    
        private void ReporteGeneral_Load(object sender, EventArgs e)
        {
            Ganancia.Series["Ventas por Producto"].Points.AddXY("Producto A", 40);
            Ganancia.Series["Ventas por Producto"].Points.AddXY("Producto B", 30);
            Ganancia.Series["Ventas por Producto"].Points.AddXY("Producto C", 60);
            Ganancia.Series["Ventas por Producto"].Points.AddXY("Producto D", 40);

            //Gráfico de venta Categoría
            Venta_categoria.Series["S_Categoria"].Points.AddXY("Categoría A", 40);
            Venta_categoria.Series["S_Categoria"].Points.AddXY("Categoría B", 30);
            Venta_categoria.Series["S_Categoria"].Points.AddXY("Categoría C", 60);
            Venta_categoria.Series["S_Categoria"].Points.AddXY("Categoría D", 40);

            //Gráfico por proveedor
            venta_proveedor.Series["venta_proveedor"].Points.AddXY("Proveedor A", 40);
            venta_proveedor.Series["venta_proveedor"].Points.AddXY("Proveedor B", 30);
            venta_proveedor.Series["venta_proveedor"].Points.AddXY("Proveedor C", 60);
        }
    }
}
