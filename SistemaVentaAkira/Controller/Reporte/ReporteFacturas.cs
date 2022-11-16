using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller.Reporte
{
    public class ReporteFacturas
    {
        private readonly string connectionString;
        public List<Factura> ListaFacturas { get;  set; }

        public ReporteFacturas()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Akira_Indu"].ToString();
        }

        public void CrearReporteFact(long p_index)
        {
            var facturaModel = this.buscarUnaFactura(p_index);
            decimal subtotalVenta;

            ListaFacturas = new List<Factura>();

            foreach (DataRow item in facturaModel.Rows)
            {
                subtotalVenta = Convert.ToInt32(item[3]) * Convert.ToDecimal(item[4]);

                var FacturasModel = new Factura()
                {
                    ProducComp = item[0].ToString(),
                    NroDet = Convert.ToInt32(item[1]),
                    NroFac = Convert.ToInt64(item[2]),
                    Cantidad = Convert.ToInt32(item[3]),
                    PrecioProducto = Convert.ToDecimal(item[4]),
                    SubTot= subtotalVenta,
                    NomCli = item[5].ToString(),
                    ApeCli = item[6].ToString(),
                    DniCli = item[7].ToString(),
                    FechaRegsitro = Convert.ToDateTime(item[8]),
                    Total = Convert.ToDecimal(item[9]),
                    FormaPago = item[10].ToString(),
                    NomEmpl = item[11].ToString(),
                    ApeEmpl = item[12].ToString()
                };

                ListaFacturas.Add(FacturasModel);
            }

        }

        private DataTable buscarUnaFactura(long p_index){

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select Producto.Pr_nombre, DetalleFactura.Cod_detalle, DetalleFactura.Cod_factura " +
                        ", DetalleFactura.df_cantidad, DetalleFactura.df_precio_venta " +
                        ", cl_nombre, cl_apellido, cl_dni, CabeceraFactura.cf_fechaRegistro, CabeceraFactura.cf_montoTotal, Forma_Pago.fp_descripcion " +
                        ", Usuario.Us_nombre, Usuario.Us_apellido from Cliente " +
                        "Inner join CabeceraFactura On CabeceraFactura.Id_Cliente = Cliente.Id_Cliente " +
                        "Inner join DetalleFactura On CabeceraFactura.Cod_factura = DetalleFactura.Cod_factura " +
                        "Inner join Producto On DetalleFactura.Id_Producto = Producto.Id_Producto " +
                        "Inner join Usuario On CabeceraFactura.Id_Usuario = Usuario.Id_usuario " +
                        "Inner join Forma_Pago On CabeceraFactura.Id_formaPago = Forma_Pago.Id_formaPago " +
                        "Where CabeceraFactura.Cod_factura = @cod_factura; ";
                    command.Parameters.AddWithValue("@cod_factura", p_index);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var tableVenta = new DataTable())
                    {
                        tableVenta.Load(reader);
                        reader.Dispose();
                        connection.Close();
                        return tableVenta;
                    }
                }
            }
        }

    }
}
