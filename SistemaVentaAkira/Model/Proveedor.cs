
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
    
public partial class Proveedor
{

    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
    public Proveedor()
    {

        this.Producto = new HashSet<Producto>();

    }


    public int Id_Proveedor { get; set; }

    public string Prov_razonSocial { get; set; }

    public string Prov_Cuit { get; set; }

    public string Prov_descripcion { get; set; }

    public string Prov_telefono { get; set; }

    public string Prov_direccion { get; set; }

    public bool Prov_estado { get; set; }

    public string Prov_nombre { get; set; }



    [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]

    public virtual ICollection<Producto> Producto { get; set; }

}

}
