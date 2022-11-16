using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller.Reporte
{
    public class EmpleadoGeneral
    {
        public string nombreEmpleado { get; set; }
        public string apellidoEmpleado { get; set; }
        public string formaPago { get; set; }
        public decimal TotalVenta { get; set; }
        public Int32 Cantidad { get; set; }
    }
}
