using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using SistemaVentaAkira.Model;

namespace SistemaVentaAkira.Controller
{
    public class Usuario_controller
    {
        #region Consultar usuarios ACTIVOS
        public List<Object> ConsultarUsuarios()
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCliente = from usuario in db.Usuario.Include("Rol").Where(user => user.Us_estado != false)
                                                  select new
                                                  {
                                                      Identificador = usuario.Id_usuario,
                                                      Rol = usuario.Rol.rol_nombre,
                                                      Nombre = usuario.Us_nombre,
                                                      Apellido = usuario.Us_apellido,
                                                      Usuario = usuario.Us_nombreuser,
                                                      Email = usuario.Us_email,
                                                      Teléfono = usuario.Us_telefono,
                                                      //Clave = usuario.Us_clave,
                                                      Fecha_Nacimiento = usuario.Us_fechaNacimiento,
                                                      Estado = (usuario.Us_estado == true ? "ACTIVO" : "INACTIVO")
                                                  };
                //Se devuelve una lista con los usuarios consultados a la base de datos
                return listaCliente.ToList();
            }
        }
        #endregion

        #region Consultar usuarios INACTIVOS
        public List<Object> ConsultarUsuariosDesactivos()
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCliente = from usuario in db.Usuario.Include("Rol").Where(user => user.Us_estado != true)
                                                  select new
                                                  {
                                                      Identificador = usuario.Id_usuario,
                                                      Rol = usuario.Rol.rol_nombre,
                                                      Nombre = usuario.Us_nombre,
                                                      Apellido = usuario.Us_apellido,
                                                      Usuario = usuario.Us_nombreuser,
                                                      Email = usuario.Us_email,
                                                      Teléfono = usuario.Us_telefono,
                                                      Fecha_Nacimiento = usuario.Us_fechaNacimiento,
                                                      Estado = (usuario.Us_estado == true ? "ACTIVO" : "INACTIVO")
                                                  };
                //Se devuelve una lista con los usuarios inactivos consultados a la base de datos
                return listaCliente.ToList();
            }
        }
        #endregion

        #region Consultar Rol
        public List<Object> ConsultarRoles()
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> roles = from Rol in db.Rol
                                           select Rol.rol_nombre;
                return roles.ToList();
            }
        }
        #endregion

        #region Consultar usuario
        public Object[] consultarUsuario(int p_index)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Usuario datosUsuario = db.Usuario.Include("Rol").Where(user => user.Id_usuario == p_index).FirstOrDefault();

                Object[] usuario = { datosUsuario.Id_usuario, datosUsuario.Rol.rol_nombre, datosUsuario.Us_nombre, datosUsuario.Us_apellido, datosUsuario.Us_nombreuser, datosUsuario.Us_email, datosUsuario.Us_telefono, descencriptarClave(datosUsuario.Us_clave), datosUsuario.Us_fechaNacimiento, datosUsuario.Us_estado };

                //Se devuelve el usuario correspondiente al ID recibido
                return usuario;
            }
        }
        #endregion

        #region Añadir usuario
        public void AgregarUsuario(string p_rol, string p_nombre, string p_apellido, string p_usuario, string p_email, string p_telefono, string p_clave, DateTime p_fechaNacimiento)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Usuario nuevoUsuario = new Usuario();

                Rol rolSeleccionado = db.Rol.Where(rol => rol.rol_nombre == p_rol).First();

                nuevoUsuario.Id_Rol = rolSeleccionado.Id_Rol;
                nuevoUsuario.Us_nombre = p_nombre;
                nuevoUsuario.Us_apellido = p_apellido;
                nuevoUsuario.Us_email = p_email;
                nuevoUsuario.Us_telefono = p_telefono;
                nuevoUsuario.Us_clave = encriptarClave(p_clave);
                nuevoUsuario.Us_fechaNacimiento = p_fechaNacimiento;
                nuevoUsuario.Us_estado = true;
                nuevoUsuario.Us_nombreuser = p_usuario;

                db.Usuario.Add(nuevoUsuario);
                db.SaveChanges();
            }
        }
        #endregion

        #region Modificar usuario
        public void modificarUsuario(int p_index, string p_rol, string p_nombre, string p_apellido, string p_usuario, string p_email, string p_telefono, string p_clave, DateTime p_fechaNacimiento)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {

                Usuario usuario = db.Usuario.Where(user => user.Id_usuario == p_index).First();

                Rol rolSeleccionado = db.Rol.Where(rol => rol.rol_nombre == p_rol).First();

                usuario.Id_Rol = rolSeleccionado.Id_Rol;
                usuario.Us_nombre = p_nombre;
                usuario.Us_apellido = p_apellido;
                usuario.Us_nombreuser = p_usuario;
                usuario.Us_email = p_email;
                usuario.Us_telefono = p_telefono;
                usuario.Us_clave = encriptarClave(p_clave);
                usuario.Us_fechaNacimiento = p_fechaNacimiento;

                db.SaveChanges();
            }
        }
        #endregion

        #region Eliminar usuario
        public void desactivarUsuario(int p_index)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Usuario usuario = db.Usuario.Where(user => user.Id_usuario == p_index).First();

                usuario.Us_estado = false;

                db.SaveChanges();
            }
        }
        #endregion

        #region Activar usuario
        public void activarUsuario(int p_index)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Usuario usuario = db.Usuario.Where(user => user.Id_usuario == p_index).First();

                usuario.Us_estado = true;

                db.SaveChanges();
            }
        }
        #endregion

        #region Encriptacion / Desencriptacion de clave
        private string encriptarClave(String clave)
        {
            try
            {
                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] secretkeyByte = { };
                secretkeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                System.IO.MemoryStream ms = null;
                System.Security.Cryptography.CryptoStream cs = null;
                byte[] inputbyteArray = System.Text.Encoding.UTF8.GetBytes(clave);
                using (System.Security.Cryptography.DESCryptoServiceProvider des = new System.Security.Cryptography.DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateEncryptor(publickeybyte, secretkeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    ToReturn = Convert.ToBase64String(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message, ex.InnerException);
            }
        }
        public string descencriptarClave(String clave)
        {
            try
            {

                string ToReturn = "";
                string publickey = "12345678";
                string secretkey = "87654321";
                byte[] privatekeyByte = { };
                privatekeyByte = System.Text.Encoding.UTF8.GetBytes(secretkey);
                byte[] publickeybyte = { };
                publickeybyte = System.Text.Encoding.UTF8.GetBytes(publickey);
                MemoryStream ms = null;
                CryptoStream cs = null;
                byte[] inputbyteArray = new byte[clave.Replace(" ", "+").Length];
                inputbyteArray = Convert.FromBase64String(clave.Replace(" ", "+"));
                using (DESCryptoServiceProvider des = new DESCryptoServiceProvider())
                {
                    ms = new MemoryStream();
                    cs = new CryptoStream(ms, des.CreateDecryptor(publickeybyte, privatekeyByte), CryptoStreamMode.Write);
                    cs.Write(inputbyteArray, 0, inputbyteArray.Length);
                    cs.FlushFinalBlock();
                    Encoding encoding = Encoding.UTF8;
                    ToReturn = encoding.GetString(ms.ToArray());
                }
                return ToReturn;
            }
            catch (Exception ae)
            {
                throw new Exception(ae.Message, ae.InnerException);
            }
        }
        #endregion

        #region Autorizar loggin
        public bool verificarLoggin(string p_usuario, string p_clave)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                bool autorizacion = false;

                string claveEncriptada = encriptarClave(p_clave);
                Usuario datosUsuario = db.Usuario.Where(user => user.Us_nombreuser == p_usuario && user.Us_clave == claveEncriptada).FirstOrDefault();

                if (datosUsuario != null)
                {
                    autorizacion = true;    
                }

                return autorizacion;
            }
            
        }
        #endregion

        #region Obtener usuario (Loggin)
        public Object[] obtenerUsuario(string p_usuario, string p_clave)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                string claveEncriptada = encriptarClave(p_clave);
                Usuario datosUsuario = db.Usuario.Include("Rol").Where(user => user.Us_nombreuser == p_usuario && user.Us_clave == claveEncriptada).First();

                Object[] usuario = { datosUsuario.Id_usuario, datosUsuario.Rol.rol_nombre, datosUsuario.Us_nombre, datosUsuario.Us_apellido, datosUsuario.Us_nombreuser };

                return usuario;
            }
        }
        #endregion

        #region Validación Email Registro (unique)
        public bool validacionEmailRegistro(String p_email)
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                Usuario buscarUsuario = db.Usuario.Where(user => user.Us_email == p_email).FirstOrDefault();

                if (buscarUsuario == null)
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

        #region Validación Email Edición (unique)
        public bool validacionEmailEdit(int p_index, String p_email) 
        {
            using (Akira_IndumentariaEntities db = new Akira_IndumentariaEntities())
            {
                bool encontrado = true;
                Usuario buscarUsuario1 = db.Usuario.Where(user => user.Us_email == p_email).FirstOrDefault();
                Usuario buscarUsuario2 = db.Usuario.Where(user => user.Us_email == p_email && user.Id_usuario == p_index).FirstOrDefault();

                if (buscarUsuario1 != null)
                {
                    encontrado = false;

                    if (buscarUsuario2 != null)
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
