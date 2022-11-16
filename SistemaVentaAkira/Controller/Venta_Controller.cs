using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentaAkira.Model;

namespace SistemaVentaAkira.Controller
{
    public class Venta_Controller
    {
        #region Registrar Cabecera Venta
        /*Id_Usuario, Id_formaPago, Id_Cliente, cf_fechaRegistro, cf_montoTotal*/
        public long registrarCabeceraVenta(int p_ID_usuario, string p_forma_pago, string p_DNICliente, decimal p_montoTotal)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Forma_Pago fp = (from formaPago in db.Forma_Pago where formaPago.fp_nombre == p_forma_pago select formaPago).First();
                Cliente cliente = (from client in db.Cliente where client.cl_dni == p_DNICliente select client).First();

                CabeceraFactura cabecera_factura = new CabeceraFactura();

                cabecera_factura.Id_Usuario = p_ID_usuario;
                cabecera_factura.Id_formaPago = fp.Id_formaPago;
                cabecera_factura.Id_Cliente = cliente.Id_Cliente;
                cabecera_factura.cf_fechaRegistro = DateTime.Now;
                cabecera_factura.cf_montoTotal = p_montoTotal;

                db.CabeceraFactura.Add(cabecera_factura);
                db.SaveChanges();

                CabeceraFactura cf = (from factura in db.CabeceraFactura select factura).OrderByDescending(f => f.Cod_factura).First();

                return cf.Cod_factura;
                //SELECT* FROM TableName WHERE id = (SELECT max(id) FROM TableName);
            }
        }
        #endregion

        #region Registrar Detalle Venta
        public void registrarDetalleVenta(long p_Cod_factura, int p_ID_Producto, int p_cantidad, decimal p_precio_venta)
        {
            /*Cod_factura, Id_Producto, df_cantidad, df_precio_venta*/
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities()) {
                DetalleFactura df = new DetalleFactura();

                df.Cod_factura = p_Cod_factura;
                df.Id_Producto = p_ID_Producto;
                df.df_cantidad = p_cantidad;
                df.df_precio_venta = p_precio_venta;

                db.DetalleFactura.Add(df);

                Producto producto = (from product in db.Producto where product.Id_Producto == p_ID_Producto select product).First();
                producto.Pr_stock = producto.Pr_stock - p_cantidad;

                db.SaveChanges();
            }
        }
        #endregion

        #region Filtrar ventas por rango de fechas
        public List<Object> filtrarVentas(DateTime fecha_desde, DateTime fecha_hasta)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaVentas = from CabeceraFactura in db.CabeceraFactura.Include("Cliente").Include("Forma_Pago").Where(cf => cf.cf_fechaRegistro <= fecha_hasta && cf.cf_fechaRegistro >= fecha_desde.Date && cf.Id_Usuario == SesionUser.Id_usuario)
                                                 select new
                                                 {
                                                     Codigo_Factura = CabeceraFactura.Cod_factura,
                                                     Forma_Pago = CabeceraFactura.Forma_Pago.fp_nombre,
                                                     Cliente = CabeceraFactura.Cliente.cl_nombre + " " + CabeceraFactura.Cliente.cl_apellido,
                                                     Monto_Final = CabeceraFactura.cf_montoTotal,
                                                     Fecha = CabeceraFactura.cf_fechaRegistro
                                                 };
                return listaVentas.ToList();
            }
        }

        #endregion

        #region Actualizar stock en el proceso de venta
        public void actualizarStockProcesoVenta(int ID_producto, int cantidad)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Producto producto = (from product in db.Producto where product.Id_Producto == ID_producto select product).First();
                producto.Pr_reserva = producto.Pr_stock - cantidad;

                db.SaveChanges();
            }
                
        }
        #endregion

        #region Restaurar Stock
        public void restaurarStockProcesoVenta(int ID_producto)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Producto producto = (from product in db.Producto where product.Id_Producto == ID_producto select product).First();
                producto.Pr_reserva = producto.Pr_stock;

                db.SaveChanges();
            }

        }
        #endregion
    }
}
