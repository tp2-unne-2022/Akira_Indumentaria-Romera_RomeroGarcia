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
    public class ReporteProducto
    {
        public List<ProductoEstGeneral> ListaProdcutos { get; private set; }
        public List<ArticuloCategoria> ListaProductosCate { get; private set; }
        public List<ArticuloProveedor> ListaProdcutosProveedor { get; private set; }

        private RepositorioProducto repositorio;

        public ReporteProducto()
        {
            repositorio = new RepositorioProducto();
        }

        public void CreateProductoEstReport(string fechaIni, string fechaFinal)
        {
            var productoGeneral = repositorio.ProductoEstGeneral(fechaIni, fechaFinal);

            ListaProdcutos = new List<ProductoEstGeneral>();

            foreach (DataRow item in productoGeneral.Rows)
            {
                var ProductosEstGene = new ProductoEstGeneral()
                {
                    DescripcionProduc = item[0].ToString(),
                    valTotal = Convert.ToDecimal(item[1]),
                    CantidadV = Convert.ToInt32(item[2])
                };

                ListaProdcutos.Add(ProductosEstGene);
            }
        }

        public void CreateProductoCatego(string fechaIni, string fechaFinal)
        {
            var productoCategoria = repositorio.ProductoporCategoria(fechaIni, fechaFinal);

            ListaProductosCate = new List<ArticuloCategoria>();

            foreach (DataRow item in productoCategoria.Rows)
            {
                var ProductoCate = new ArticuloCategoria()
                {
                    DescripcionCateg = item[0].ToString(),
                    CantidadCate = Convert.ToInt32(item[1]),
                };

                ListaProductosCate.Add(ProductoCate);
            }
        }

        public void CrearProdProveedor(string fechaIni, string fechaFinal)
        {
            var productoProveedor = repositorio.ProductoporProveedor(fechaIni, fechaFinal);

            ListaProdcutosProveedor = new List<ArticuloProveedor>();

            foreach (DataRow item in productoProveedor.Rows)
            {
                var ProductoProveedor = new ArticuloProveedor()
                {
                    nombreProveedor = item[0].ToString(),
                    cantidadProveedor = Convert.ToInt32(item[1]),
                };

                ListaProdcutosProveedor.Add(ProductoProveedor);
            }
        }
    }
}
