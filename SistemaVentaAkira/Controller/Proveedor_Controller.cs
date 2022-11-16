using SistemaVentaAkira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class Proveedor_Controller
    {
        #region Consultar Proveedor Activo
        public List<Object> ConsultarProveedores()
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaProveedores = from Proveedor in dbAkira.Proveedor.Where(prov => prov.Prov_estado != false) select new
                {
                    Identificador = Proveedor.Id_Proveedor,
                    Nombre = Proveedor.Prov_nombre,
                    Cuit = Proveedor.Prov_Cuit,
                    Razón_Social = Proveedor.Prov_razonSocial,
                    Teléfono = Proveedor.Prov_telefono,
                    Dirección = Proveedor.Prov_direccion,
                    Descripción = Proveedor.Prov_descripcion,
                    Estado = (Proveedor.Prov_estado == true ? "ACTIVO" : "INACTIVO")
                };
                //Se devuelve una lista con los productos consultados a la base de datos
                return listaProveedores.ToList();
            }
        }
        #endregion

        #region Consultar Proveedor Inactivo
        public List<Object> ConsultarProveedoresInactivos()
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaProveedores = from Proveedor in dbAkira.Proveedor.Where(prov => prov.Prov_estado != true) select new
                           {
                                 Identificador = Proveedor.Id_Proveedor,
                                 Nombre = Proveedor.Prov_nombre,
                                 Cuit = Proveedor.Prov_Cuit,
                                 Razón_Social = Proveedor.Prov_razonSocial,
                                 Teléfono = Proveedor.Prov_telefono,
                                 Dirección = Proveedor.Prov_direccion,
                                 Descripción = Proveedor.Prov_descripcion,
                                 Estado = (Proveedor.Prov_estado == true ? "ACTIVO" : "INACTIVO")
                            };
                //Se devuelve una lista con los productos consultados a la base de datos
                return listaProveedores.ToList();
            }
        }
        #endregion

        #region Añadir Proveedor
        public void AgregarProveedor(String p_Cuit, String p_Nombre, String p_Descripcion, String p_Telefono, String p_Direccion, String p_Razon){
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Proveedor newSupplier = new Proveedor();

                newSupplier.Prov_Cuit = p_Cuit;
                newSupplier.Prov_nombre = p_Nombre;
                newSupplier.Prov_razonSocial = p_Razon;
                newSupplier.Prov_descripcion = p_Descripcion;
                newSupplier.Prov_telefono = p_Telefono;
                newSupplier.Prov_direccion = p_Direccion;
                newSupplier.Prov_estado = true;

                db_Akira.Proveedor.Add(newSupplier);
                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Consultar un Proveedor
        public Object[] buscarProveedor(int p_index)
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                Proveedor datosProveedor = dbAkira.Proveedor.Where(prov => prov.Id_Proveedor == p_index).First();

                Object[] supplier = { datosProveedor.Id_Proveedor, datosProveedor.Prov_nombre, datosProveedor.Prov_descripcion, datosProveedor.Prov_razonSocial, datosProveedor.Prov_Cuit, datosProveedor.Prov_direccion, datosProveedor.Prov_telefono};

                //Se devuelve una lista con los productos consultados a la base de datos
                return supplier;
            }
        }
        #endregion

        #region Actualizar Proveedor
        public void actualizarProveedor(int p_index, String p_Cuit, String p_Nombre, String p_Descripcion, String p_Telefono, String p_Direccion, String p_Razon)
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                Proveedor newSupplier = dbAkira.Proveedor.Where(prov => prov.Id_Proveedor == p_index).First();

                newSupplier.Prov_Cuit = p_Cuit;
                newSupplier.Prov_nombre = p_Nombre;
                newSupplier.Prov_razonSocial = p_Razon;
                newSupplier.Prov_descripcion = p_Descripcion;
                newSupplier.Prov_telefono = p_Telefono;
                newSupplier.Prov_direccion = p_Direccion;

                dbAkira.SaveChanges();
            }
        }
        #endregion

        #region Desactivar Proveedor
        public void desactivarProveedor(int p_index)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Proveedor supplier_modify = db_Akira.Proveedor.Where(prov => prov.Id_Proveedor == p_index).First();

                supplier_modify.Prov_estado = false;

                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Activar Proveedor
        public void activarProveedor(int p_index)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Proveedor supplier_modify = db_Akira.Proveedor.Where(prov => prov.Id_Proveedor == p_index).First();

                supplier_modify.Prov_estado = true;

                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Validación Cuit
        public bool validacionCuit(String p_Cuit)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Proveedor buscarProv = db_Akira.Proveedor.Where(prov => prov.Prov_Cuit == p_Cuit).First();

                if (buscarProv == null)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
        #endregion
    }
}
