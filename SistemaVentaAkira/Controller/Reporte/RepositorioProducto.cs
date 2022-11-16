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
    public class RepositorioProducto
    {
        private readonly string connectionString;

        public RepositorioProducto()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Akira_Indu"].ToString();

        }

        public DataTable ProductoEstGeneral(string fechaInicio, string fechaFinal)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select Producto.Pr_nombre, Sum(DetalleFactura.df_cantidad), Sum(DetalleFactura.df_cantidad * DetalleFactura.df_precio_venta) from Producto " +
                        "inner join DetalleFactura On Producto.Id_Producto = DetalleFactura.Id_Producto " +
                        "inner join CabeceraFactura On DetalleFactura.Cod_factura = CabeceraFactura.Cod_factura " +
                        "Where Producto.Pr_estado = 1 and CabeceraFactura.cf_fechaRegistro between Convert(Date, @fechaInicial) And Convert(Date, @fechaFinal)" +
                        "Group by Producto.Pr_nombre";
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        connection.Close();
                        return table;
                    }
                }
            }
        }

        public DataTable ProductoporProveedor(string fechaInicio, string fechaFinal)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select Proveedor.Prov_nombre, Sum(DetalleFactura.df_cantidad) from Producto " +
                        "inner join Proveedor On Producto.Id_proveedor = Proveedor.Id_Proveedor " +
                        "inner join DetalleFactura On Producto.Id_Producto = DetalleFactura.Id_Producto " +
                        "inner join CabeceraFactura On DetalleFactura.Cod_factura = CabeceraFactura.Cod_factura " +
                        "Where Producto.Pr_estado = 1 and CabeceraFactura.cf_fechaRegistro between Convert(Datetime, @fechaInicial) And Convert(Datetime, @fechaFinal)" +
                        "Group by Proveedor.Prov_nombre; ";
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        connection.Close();
                        return table;
                    }
                }
            }
        }

        public DataTable ProductoporCategoria(string fechaInicio, string fechaFinal)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select Categoria.cat_nombre, Sum(DetalleFactura.df_cantidad) from Producto " +
                        "inner join Categoria On Producto.Id_categoria = Categoria.Id_categoria" +
                        " inner join DetalleFactura On Producto.Id_Producto = DetalleFactura.Id_Producto " +
                        "inner join CabeceraFactura On DetalleFactura.Cod_factura = CabeceraFactura.Cod_factura " +
                        "Where Producto.Pr_estado = 1 and CabeceraFactura.cf_fechaRegistro between Convert(Date, @fechaInicial) And Convert(Date, @fechaFinal)" +
                        "Group by Categoria.cat_nombre; ";
                    command.Parameters.AddWithValue("@fechaInicial", fechaInicio);
                    command.Parameters.AddWithValue("@fechaFinal", fechaFinal);
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        connection.Close();
                        return table;
                    }
                }
            }
        }
    }
}
