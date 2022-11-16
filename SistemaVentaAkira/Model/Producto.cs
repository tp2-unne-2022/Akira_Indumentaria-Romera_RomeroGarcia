
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
    
public partial class Producto
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Producto()
    {

        this.DetalleFactura = new HashSet<DetalleFactura>();

    }


    public int Id_Producto { get; set; }

    public int Id_categoria { get; set; }

    public int Id_proveedor { get; set; }

    public string Pr_nombre { get; set; }

    public decimal Pr_precioVenta { get; set; }

    public decimal Pr_precioCompra { get; set; }

    public int Pr_stock { get; set; }

    public int Pr_stock_minimo { get; set; }

    public bool Pr_estado { get; set; }

    public int Pr_reserva { get; set; }



    public virtual Categoria Categoria { get; set; }

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<DetalleFactura> DetalleFactura { get; set; }

    public virtual Proveedor Proveedor { get; set; }

}

}
