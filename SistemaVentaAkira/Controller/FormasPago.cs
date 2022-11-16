using SistemaVentaAkira.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class FormasPago
    {
        #region Consultar Forma de Pago
        public List<Object> ConsultarFormaPago()
        {
            using (Akira_IndumentariaEntities db_Akira = new Akira_IndumentariaEntities())
            {
                IQueryable<Object> listarFormaPago = from Forma_Pago in db_Akira.Forma_Pago
                                                     select Forma_Pago.fp_nombre;
                return listarFormaPago.ToList();
            }
        }
        #endregion
    }
}
