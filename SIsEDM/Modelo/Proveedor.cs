//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIsEDM.Modelo
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedor
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedor()
        {
            this.Fk_Compra = new HashSet<Compra>();
        }
    
        public int IdProveedor { get; set; }
        public string Codigo { get; set; }
        public int DatosIdDatos { get; set; }
        public string RazonSocial { get; set; }
    
        public virtual Datos Fk_Datos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Fk_Compra { get; set; }
    }
}
