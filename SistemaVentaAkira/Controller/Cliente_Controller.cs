using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaVentaAkira.Model;

namespace SistemaVentaAkira.Controller
{
    public class Cliente_Controller
    {
        #region Consultar clientes ACTIVOS
        public List<Object> ConsultarClientes()
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCliente = from cliente in db.Cliente.Where(clie => clie.cl_estado != false)
                                                    select new
                                                    {
                                                        Identificador = cliente.Id_Cliente,
                                                         Nombre = cliente.cl_nombre,
                                                         Apellido = cliente.cl_apellido,
                                                         DNI = cliente.cl_dni,
                                                         Email = cliente.cl_email,
                                                         Teléfono = cliente.cl_telefono,
                                                         Fecha_Nacimiento = cliente.cl_fechaNacimiento,
                                                         Fecha_Alta = cliente.cl_fechaAlta,
                                                         Estado = (cliente.cl_estado == true ? "ACTIVO" : "INACTIVO")
                                                    };
                //Se devuelve una lista con los clientes consultados a la base de datos
                return listaCliente.ToList();
            }
        }
        #endregion

        #region Consultar clientes INACTIVOS
        public List<Object> ConsultarClientesDesactivos()
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCliente = from cliente in db.Cliente.Where(clie => clie.cl_estado != true)
                                                  select new
                                                  {
                                                      Identificador = cliente.Id_Cliente,
                                                      Nombre = cliente.cl_nombre,
                                                      Apellido = cliente.cl_apellido,
                                                      DNI = cliente.cl_dni,
                                                      Email = cliente.cl_email,
                                                      Teléfono = cliente.cl_telefono,
                                                      Fecha_Nacimiento = cliente.cl_fechaNacimiento,
                                                      Fecha_Alta = cliente.cl_fechaAlta,
                                                      Estado = (cliente.cl_estado == true ? "ACTIVO" : "INACTIVO")
                                                  };
                //Se devuelve una lista con los clientes inactivos consultados a la base de datos
                return listaCliente.ToList();
            }
        }
        #endregion

        #region Consultar Cliente
        public Object[] consultarCliente(int p_index)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Cliente datosCliente = db.Cliente.Where(cl => cl.Id_Cliente == p_index).First();

                Object[] cliente = { datosCliente.Id_Cliente, datosCliente.cl_nombre, datosCliente.cl_apellido, datosCliente.cl_dni, datosCliente.cl_email, datosCliente.cl_telefono, datosCliente.cl_fechaNacimiento, datosCliente.cl_fechaAlta, datosCliente.cl_estado };

                //Se devuelve el cliente correspondiente al ID recibido
                return cliente;
            }
        }
        #endregion

        #region Añadir cliente
        public void AgregarCliente(string p_nombre, string p_apellido, string p_dni, string p_email, string p_telefono, DateTime p_fechaNacimiento)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            { 
                Cliente nuevoCliente = new Cliente();

                nuevoCliente.cl_nombre = p_nombre;
                nuevoCliente.cl_apellido = p_apellido;
                nuevoCliente.cl_dni = p_dni;
                nuevoCliente.cl_email = p_email;
                nuevoCliente.cl_telefono = p_telefono;
                nuevoCliente.cl_fechaNacimiento = p_fechaNacimiento;
                nuevoCliente.cl_fechaAlta = DateTime.Now;
                nuevoCliente.cl_estado = true;

                db.Cliente.Add(nuevoCliente);
                db.SaveChanges();
            }
        }
        #endregion

        #region Modificar cliente
        public void modificarCliente(int p_index, string p_nombre, string p_apellido, string p_dni, string p_email, string p_telefono, DateTime p_fechaNacimiento)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {

                Cliente cliente = db.Cliente.Where(cl => cl.Id_Cliente == p_index).First();

                cliente.cl_nombre = p_nombre;
                cliente.cl_apellido = p_apellido;
                cliente.cl_dni = p_dni;
                cliente.cl_email = p_email;
                cliente.cl_telefono = p_telefono;
                cliente.cl_fechaNacimiento = p_fechaNacimiento;

                //Si salta error ponerle true a estado
                db.SaveChanges();
            }
        }
        #endregion

        #region Eliminar cliente
        public void desactivarCliente(int p_index)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Cliente cliente = db.Cliente.Where(cl => cl.Id_Cliente == p_index).First();

                cliente.cl_estado = false;

                db.SaveChanges();
            }
        }
        #endregion

        #region Activar cliente
        public void activarCliente(int p_index)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Cliente cliente = db.Cliente.Where(cl => cl.Id_Cliente == p_index).First();

                cliente.cl_estado = true;

                db.SaveChanges();
            }
        }
        #endregion

        #region Validación DNI Registro (unique)
        public bool validacionDNIRegistro(String p_DNI)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Cliente buscarCliente = db.Cliente.Where(cl => cl.cl_dni == p_DNI).FirstOrDefault();

                if (buscarCliente == null)
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

        #region Validación DNI Edición (unique)
        public bool validacionDNIEdit(int p_index, String p_DNI)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                bool encontrado = true;
                Cliente buscarCliente1 = db.Cliente.Where(cl => cl.cl_dni == p_DNI).FirstOrDefault();
                Cliente buscarCliente2 = db.Cliente.Where(cl => (cl.cl_dni == p_DNI && cl.Id_Cliente != p_index)).FirstOrDefault();

                if (buscarCliente1 != null)
                {
                    encontrado = false;

                    if (buscarCliente2 != null)
                    {
                        encontrado = true;
                    }
                }
                
                return encontrado;
            }
        }
        #endregion
    }
}
