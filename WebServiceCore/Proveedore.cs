//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WebServiceCore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Proveedore
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Proveedore()
        {
            this.Compras_Proveedores = new HashSet<Compras_Proveedores>();
        }
    
        public int id_proveedor { get; set; }
        public string nombre { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public string rnc { get; set; }
        public bool activo { get; set; }
        public string email { get; set; }
        public string telefono { get; set; }
        public string direccion { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Compras_Proveedores> Compras_Proveedores { get; set; }
    }
}
