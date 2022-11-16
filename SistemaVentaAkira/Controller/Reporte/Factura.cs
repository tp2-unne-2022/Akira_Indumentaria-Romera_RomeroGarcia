using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller
{
    public class Factura
    {
        public Int64 NroFac { get; set; }
        public Int32 NroDet { get; set; }
        public string ProducComp { get; set; }
        public Int32 Cantidad { get; set; }
        public decimal PrecioProducto { get; set; }
        public decimal SubTot { get; set; }
        public string DniCli { get; set; }
        public string NomCli { get; set; }
        public string ApeCli { get; set; }
        public decimal Total { get; set; }
        public DateTime FechaRegsitro { get; set; }
        public string FormaPago { get; set; }
        public string NomEmpl { get; set; }
        public string ApeEmpl { get; set; }
    }
}
