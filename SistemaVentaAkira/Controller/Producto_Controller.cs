using SistemaVentaAkira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class Producto_Controller
    {

        #region Consultar Productos ACTIVOS
        public List<Object> ConsultarProductos()
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities()){
                IQueryable<Object> listaProductos = from Producto in dbAkira.Producto.Include("Categoria").Include("Proveedor").Where(prod => prod.Pr_estado != false)
                                                    select new{
                                                        Identificador = Producto.Id_Producto,
                                                        Nombre = Producto.Pr_nombre,
                                                        Categoria = Producto.Categoria.cat_nombre,
                                                        Proveedor = Producto.Proveedor.Prov_nombre,
                                                        Precio_Venta = Producto.Pr_precioCompra,
                                                        Precio_Compra = Producto.Pr_precioVenta,
                                                        Stock = Producto.Pr_stock,
                                                        Reserva = Producto.Pr_reserva,
                                                        Stock_Minimo = Producto.Pr_stock_minimo,
                                                        Estado = (Producto.Pr_estado == true ? "ACTIVO" : "INACTIVO")
                                                    };
                //Se devuelve una lista con los productos consultados a la base de datos
                return listaProductos.ToList();
            }
        }
        #endregion

        #region Consultar Categoría
        public List<Object> ConsultarCategorias()
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCategorias = from Categoria in db_Akira.Categoria
                                                     select Categoria.cat_nombre;
                return listaCategorias.ToList();
            }
        }
        #endregion

        #region Consultar Proveedor
        public List<Object> ConsultarProveedor()
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaProveedor = from Proveedor in db_Akira.Proveedor
                                                    select Proveedor.Prov_nombre;
                return listaProveedor.ToList();
            }
        }
        #endregion

        #region Añadir producto
        public void AgregarProducto(string p_categoria, string p_proveedor, string p_nombre, decimal p_PrecioCompra, decimal p_PrecioVenta, int p_stock, int p_stockMinimo)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Producto nuevoProducto = new Producto();
                //Versión 1
                /*Categoria categoriaSeleccionada = (from Categoria in db_Akira.Categoria where Categoria.cat_nombre == p_categoria select Categoria).First();*/
                //Versión 2
                Categoria categoriaSeleccionada = db_Akira.Categoria.Where(s => s.cat_nombre == p_categoria).First();
                Proveedor proveedorSeleccionado = db_Akira.Proveedor.Where(s => s.Prov_nombre == p_proveedor).First();

                nuevoProducto.Pr_nombre = p_nombre;
                nuevoProducto.Pr_precioCompra = p_PrecioCompra;
                nuevoProducto.Pr_precioVenta = p_PrecioVenta;
                nuevoProducto.Pr_stock = p_stock;
                nuevoProducto.Pr_reserva = p_stock;
                nuevoProducto.Id_categoria = categoriaSeleccionada.Id_categoria;
                nuevoProducto.Id_proveedor = proveedorSeleccionado.Id_Proveedor;
                nuevoProducto.Pr_stock_minimo = p_stockMinimo;
                nuevoProducto.Pr_estado = true;

                db_Akira.Producto.Add(nuevoProducto);
                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Consultar Producto
        public Object[] consultarProducto(int p_index){
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities()) {
                Producto datosProducto = db.Producto.Where(prod => prod.Id_Producto == p_index).First();

                Categoria categoriaSeleccionada = db.Categoria.Where(cs => cs.Id_categoria == datosProducto.Id_categoria).First();
                Proveedor proveedorSeleccionado = db.Proveedor.Where(ps => ps.Id_Proveedor == datosProducto.Id_proveedor).First();

                Object[] producto = { datosProducto.Id_Producto, categoriaSeleccionada.cat_nombre, proveedorSeleccionado.Prov_nombre, datosProducto.Pr_nombre, datosProducto.Pr_precioVenta, datosProducto.Pr_precioCompra, datosProducto.Pr_stock, datosProducto.Pr_reserva, datosProducto.Pr_stock_minimo, datosProducto.Pr_estado };

                //0-ID,1-Categoria,2-Proveedor,3-Nombre,4-Pr_venta,5-Pr_compra,6-Stock,7-Reserva,8-stock_min,9-estado
                //Se devuelve el producto correspondiente al ID recibido
                return producto;
            }
        }
        #endregion

        #region Consultar productos DESACTIVOS
        public List<Object> ConsultarProductosEliminados(){
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listadoProductosInactivos = from Producto in db.Producto.Include("Categoria").Include("Proveedor").Where(prod => prod.Pr_estado != true)
                                                               select new{
                                                                 Identificador = Producto.Id_Producto,
                                                                 Nombre = Producto.Pr_nombre,
                                                                 Categoria = Producto.Categoria.cat_nombre,
                                                                 Proveedor = Producto.Proveedor.Prov_nombre,
                                                                 Precio_Venta = Producto.Pr_precioCompra,
                                                                 Precio_Compra = Producto.Pr_precioVenta,
                                                                 Stock = Producto.Pr_stock,
                                                                 Stock_Minimo = Producto.Pr_stock_minimo,
                                                                 Estado = (Producto.Pr_estado == true ? "ACTIVO" : "INACTIVO")
                                                                };
                //Se devuelve una lista con los productos consultados a la base de datos
                return listadoProductosInactivos.ToList();
            }
        }

        #endregion

        #region Activar producto
        public void activarProducto(int p_index){
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities()){
                Producto producto = db.Producto.Where(prod => prod.Id_Producto == p_index).First();

                producto.Pr_estado = true;

                db.SaveChanges();
            }
        }
        #endregion

        #region Modificar producto
        public void modificarProducto(int p_index, string p_categoria, string p_proveedor, string p_nombre, decimal p_PrecioCompra, decimal p_PrecioVenta, int p_stock, int p_stockMinimo){
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities()){

                Producto producto = db.Producto.Where(prod => prod.Id_Producto == p_index).First();

                Categoria categoriaSeleccionada = db.Categoria.Where(cs => cs.cat_nombre == p_categoria).First();
                Proveedor proveedorSeleccionado = db.Proveedor.Where(ps => ps.Prov_nombre == p_proveedor).First();

                producto.Id_categoria = categoriaSeleccionada.Id_categoria;
                producto.Id_proveedor = proveedorSeleccionado.Id_Proveedor;
                producto.Pr_nombre = p_nombre;
                producto.Pr_precioCompra = p_PrecioCompra;
                producto.Pr_precioVenta = p_PrecioVenta;
                producto.Pr_stock = p_stock;
                producto.Pr_reserva = p_stock;
                producto.Pr_stock_minimo = p_stockMinimo;
                producto.Pr_estado = true;


                db.SaveChanges();
            }
        }
        #endregion

        #region Eliminar producto
        public void desactivarProducto(int p_index){
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities()){
                Producto producto = db.Producto.Where(prod => prod.Id_Producto == p_index).First();

                producto.Pr_estado = false;
                
                db.SaveChanges();
            }
        }
        #endregion

    }
}
