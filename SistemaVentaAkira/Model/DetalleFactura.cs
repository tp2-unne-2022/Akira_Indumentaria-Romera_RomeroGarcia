
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace SistemaVentaAkira.Model
{

using System;
    using System.Collections.Generic;
    
public partial class DetalleFactura
{

    public int Cod_detalle { get; set; }

    public long Cod_factura { get; set; }

    public int Id_Producto { get; set; }

    public int df_cantidad { get; set; }

    public decimal df_precio_venta { get; set; }



    public virtual CabeceraFactura CabeceraFactura { get; set; }

    public virtual Producto Producto { get; set; }

}

}
