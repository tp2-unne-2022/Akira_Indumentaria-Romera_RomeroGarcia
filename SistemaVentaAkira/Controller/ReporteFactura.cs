using SistemaVentaAkira.Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class ReporteFactura
    {
        public List<Object> listadoFact {get; set;}

        public void CreacionReporte( long pos)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                //DetalleFactura factura = db.DetalleFactura.Where(s => s.Cod_factura == p_index).First();
                listadoFact = new List<Object>();

                IQueryable<object> factura = from detallefact in db.DetalleFactura.Include("Producto").Include("CabeceraFactura").Include("Cliente").Include("Usuario").Where(fact => fact.Cod_factura == pos)
                 select new
                                             {
                                                 NroFactura = detallefact.Cod_factura,
                                                 NroDetalle = detallefact.Cod_detalle,
                                                 ProductoComp = detallefact.Producto.Pr_nombre,
                                                 Cantidad = detallefact.df_cantidad,
                                                 PrecioProducto = detallefact.df_precio_venta,
                                                 DNIcliente = detallefact.CabeceraFactura.Cliente.cl_dni,
                                                 Nombrecliente = detallefact.CabeceraFactura.Cliente.cl_nombre,
                                                 ApellidoCliente = detallefact.CabeceraFactura.Cliente.cl_apellido,
                                                 Total = detallefact.CabeceraFactura.cf_montoTotal,
                                                 FechaRegistro = detallefact.CabeceraFactura.cf_fechaRegistro,
                                                 NombreEmpleado = detallefact.CabeceraFactura.Usuario.Us_nombre,
                                                 ApellidoEmpleado = detallefact.CabeceraFactura.Usuario.Us_apellido,

                                             };
                listadoFact.Add(factura);

            }

        }


    }
}
