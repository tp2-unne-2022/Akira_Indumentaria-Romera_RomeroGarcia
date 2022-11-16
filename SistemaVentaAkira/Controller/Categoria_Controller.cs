using SistemaVentaAkira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class Categoria_Controller
    {
        #region Consultar Categorias
        public List<Object> ConsultarCategorias()
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCategorias = from Categoria in dbAkira.Categoria.Where(cat=>cat.cat_estado != false) select new
                {
                  Identificador = Categoria.Id_categoria,
                  Nombre = Categoria.cat_nombre,
                  Descripcion = Categoria.cat_descripcion,
                  Estado = (Categoria.cat_estado == true ? "ACTIVO" : "INACTIVO")
                };
                //Se devuelve una lista con los productos consultados a la base de datos
                return listaCategorias.ToList();
            }
        }
        #endregion

        #region Consultar Categorias Desactivadas
        public List<Object> ConsultarCategoriasEliminadas()
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listaCategorias = from Categoria in dbAkira.Categoria.Where(cat => cat.cat_estado != true) select new {
                                      Identificador = Categoria.Id_categoria,
                                      Nombre = Categoria.cat_nombre,
                                      Descripcion = Categoria.cat_descripcion,
                                      Estado = (Categoria.cat_estado == true ? "ACTIVO" : "INACTIVO")
                                    };
                //Se devuelve una lista con los productos consultados a la base de datos
                return listaCategorias.ToList();
            }
        }
        #endregion

        #region Añadir categoría
        public void AgregarCategoria(string nombre_categoria, string desc_categoria)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Categoria newCategory = new Categoria();

                newCategory.cat_nombre = nombre_categoria;
                newCategory.cat_descripcion = desc_categoria;
                newCategory.cat_estado = true;

                db_Akira.Categoria.Add(newCategory);
                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Consultar una categoría
        public Object[] buscarCategoria(int p_index)
        {
            using (Akira_IndumentariaEntities dbAkira = new Akira_IndumentariaEntities())
            {
                Categoria datosCategoria = dbAkira.Categoria.Where(categoria => categoria.Id_categoria == p_index).First();

                Object[] cate = { datosCategoria.Id_categoria, datosCategoria.cat_nombre, datosCategoria.cat_descripcion };
    
                //Se devuelve una lista con los productos consultados a la base de datos
                return cate;
            }
        }
        #endregion

        #region Actualizar Categoria
        public void actualizarCategoria(int p_index, String nombre_cat, String desc_Cate)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Categoria newCategory = db_Akira.Categoria.Where(cat => cat.Id_categoria == p_index).First();

                newCategory.cat_nombre = nombre_cat;
                newCategory.cat_descripcion = desc_Cate;
                //newCategory.cat_estado = true;

                //db_Akira.Categoria.Add(newCategory);
                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Desactivar Categoria
        public void desactivarCategoria(int p_index)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Categoria cate_modify = db_Akira.Categoria.Where(cat => cat.Id_categoria == p_index).First();

                cate_modify.cat_estado = false;
                //newCategory.cat_estado = true;

                //db_Akira.Categoria.Add(newCategory);
                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Activar Categoria
        public void activarCategoria(int p_index)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Categoria cate_modify = db_Akira.Categoria.Where(cat => cat.Id_categoria == p_index).First();

                cate_modify.cat_estado = true;
                //newCategory.cat_estado = true;

                //db_Akira.Categoria.Add(newCategory);
                db_Akira.SaveChanges();
            }
        }
        #endregion

        #region Validación Name
        public bool validacionName(String p_Nombre)
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                Categoria buscarCate = db_Akira.Categoria.Where(cat => cat.cat_nombre == p_Nombre).First();

                if(buscarCate == null)
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
