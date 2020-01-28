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
	using System.ComponentModel.DataAnnotations.Schema;

	public partial class Empleado
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Empleado()
        {
            this.Fk_Compra = new HashSet<Compra>();
            this.Fk_Venta = new HashSet<Venta>();
        }
    
        public int IdEmpleado { get; set; }
        public string Codigo { get; set; }
        public int DatosIdDatos { get; set; }
        public string Identificacion { get; set; }
        public string Correo { get; set; }
    
        public virtual Datos Fk_Datos { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compra> Fk_Compra { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Venta> Fk_Venta { get; set; }

		[NotMapped]
		public string Nombre
		{
			get
			{
				return Fk_Datos.Nombre + " " + Fk_Datos.Apellido;
			}
		}
	}
}
