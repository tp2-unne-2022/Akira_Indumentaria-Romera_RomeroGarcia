using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaVentaAkira.Controller.Reporte
{
    public class ReporteEmpleados
    {
        public List<EmpleadoGeneral> listaEmpleados { get; private set; }
        public List<EmpleadoMensual> listaEmpleadoMensual { get; private set; }
        public List<EmpleadoAnual> listaEmpleadoAnual { get; private set; }

        private RepositorioVendedores empleadoRepositorio;

        public ReporteEmpleados()
        {
            empleadoRepositorio = new RepositorioVendedores();
        }

        public void CrearListaEmpleadosGeneral()
        {
            var empleadoGeneral = empleadoRepositorio.estadisticaGeneralEmpleado();

            listaEmpleados = new List<EmpleadoGeneral>();

            foreach (DataRow item in empleadoGeneral.Rows)
            {
                var empleadoGen = new EmpleadoGeneral()
                {
                    nombreEmpleado = item[0].ToString(),
                    apellidoEmpleado = item[1].ToString(),
                    formaPago = item[2].ToString(),
                    TotalVenta = Convert.ToDecimal(item[3]),
                    Cantidad = Convert.ToInt32(item[4])
                };

                listaEmpleados.Add(empleadoGen);
            }
        }

        public void CrearListaEmpleadoAnual(int p_anioInic, int p_anioFin)
        {
            var empleadosAnual = empleadoRepositorio.EmpleadoAnual(p_anioInic, p_anioFin);

            listaEmpleadoAnual = new List<EmpleadoAnual>();

            foreach (DataRow item in empleadosAnual.Rows)
            {
                var empAnual = new EmpleadoAnual()
                {
                    fechaReg = Convert.ToDateTime(item[0]),
                    nombreEmpleado = item[1].ToString(),
                    apellidoEmpleado = item[2].ToString(),
                    TotalVentRango = Convert.ToDecimal(item[3]),
                    Cantidad = Convert.ToInt32(item[4])
                };

                listaEmpleadoAnual.Add(empAnual);
            }
        }

        public void CrearListaEmpleadoMensual(int p_anio, int p_mes)
        {
            var empleadoMensual = empleadoRepositorio.EmpleadoMensual(p_anio, p_mes);

            listaEmpleadoMensual = new List<EmpleadoMensual>();

            foreach (DataRow item in empleadoMensual.Rows)
            {
                var empMensual = new EmpleadoMensual()
                {
                    fechaReg = Convert.ToDateTime(item[0]),
                    nombreEmpleado = item[1].ToString(),
                    apellidoEmpleado = item[2].ToString(),
                    TotalVentRango = Convert.ToDecimal(item[3]),
                    Cantidad = Convert.ToInt32(item[4])
                };

                listaEmpleadoMensual.Add(empMensual);
            }
        }
    }
}
