using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller.Reporte
{
    public class EmpleadoMensual
    {
        public DateTime fechaReg { get; set; }
        public string nombreEmpleado { get; set; }
        public string apellidoEmpleado { get; set; }
        public decimal TotalVentRango { get; set; }
        public Int32 Cantidad { get; set; }
    }
}
