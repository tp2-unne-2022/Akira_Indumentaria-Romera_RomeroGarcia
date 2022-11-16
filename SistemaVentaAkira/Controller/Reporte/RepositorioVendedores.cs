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
    public class RepositorioVendedores
    {
        private readonly string connectionString;

        public RepositorioVendedores()
        {
            connectionString = ConfigurationManager.ConnectionStrings["Akira_Indu"].ToString();
        }

        public DataTable EmpleadoAnual(int p_anioInicio, int p_anioFinal)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select CabeceraFactura.cf_fechaRegistro, Usuario.Us_nombre, Usuario.Us_apellido, CabeceraFactura.cf_montoTotal, Sum(DetalleFactura.df_cantidad) from CabeceraFactura " +
                        "inner join Usuario On CabeceraFactura.Id_Usuario = Usuario.Id_usuario " +
                        "inner join DetalleFactura On CabeceraFactura.Cod_factura = DetalleFactura.Cod_factura " +
                        " Where Usuario.Us_estado = 1 And (Year(CabeceraFactura.cf_fechaRegistro)) Between  @p_anioIni  And  @p_anioFin " +
                        "Group by CabeceraFactura.cf_fechaRegistro, Usuario.Us_nombre, Usuario.Us_apellido, CabeceraFactura.cf_montoTotal;";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@p_anioIni", p_anioInicio);
                    command.Parameters.AddWithValue("@p_anioFin", p_anioFinal);
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }

        public DataTable EmpleadoMensual(int p_anio, int p_mes)
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select CabeceraFactura.cf_fechaRegistro, Usuario.Us_nombre, Usuario.Us_apellido, CabeceraFactura.cf_montoTotal, Sum(DetalleFactura.df_cantidad) " +
                        "from CabeceraFactura " +
                        "inner join Usuario On CabeceraFactura.Id_Usuario = Usuario.Id_usuario " +
                        "inner join DetalleFactura On CabeceraFactura.Cod_factura = DetalleFactura.Cod_factura " +
                        "Where Usuario.Us_estado = 1 And(Year(CabeceraFactura.cf_fechaRegistro)) = @p_anio And(Month(CabeceraFactura.cf_fechaRegistro)) = @p_mes " +
                        "Group by CabeceraFactura.cf_fechaRegistro, Usuario.Us_nombre, Usuario.Us_apellido, CabeceraFactura.cf_montoTotal; ";
                    command.CommandType = CommandType.Text;
                    command.Parameters.AddWithValue("@p_anio", p_anio);
                    command.Parameters.AddWithValue("@p_mes", p_mes);
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }

        public DataTable estadisticaGeneralEmpleado()
        {
            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                using (var command = new SqlCommand())
                {
                    command.Connection = connection;
                    command.CommandText = "Select Usuario.Us_nombre, Usuario.Us_apellido, Forma_Pago.fp_nombre ,CabeceraFactura.cf_montoTotal, Sum(DetalleFactura.df_cantidad) from CabeceraFactura " +
                        "inner join Usuario On CabeceraFactura.Id_Usuario = Usuario.Id_usuario " +
                        "inner join DetalleFactura On CabeceraFactura.Cod_factura = DetalleFactura.Cod_factura " +
                        "inner join Forma_Pago On CabeceraFactura.Id_formaPago = Forma_Pago.Id_formaPago " +
                        "Group by Forma_Pago.fp_nombre, Usuario.Us_nombre, Usuario.Us_apellido, CabeceraFactura.cf_montoTotal; ";
                    command.CommandType = CommandType.Text;
                    SqlDataReader reader = command.ExecuteReader();
                    using (var table = new DataTable())
                    {
                        table.Load(reader);
                        reader.Dispose();
                        return table;
                    }
                }
            }
        }

    }
}
