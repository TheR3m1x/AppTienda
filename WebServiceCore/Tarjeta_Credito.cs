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
    
    public partial class Tarjeta_Credito
    {
        public int id_tarjeta_credito { get; set; }
        public int id_cliente { get; set; }
        public string nombre_dueno { get; set; }
        public string num_tarjeta { get; set; }
        public string fecha_vencimiento { get; set; }
        public string cvv { get; set; }
        public bool activo { get; set; }
        public System.DateTime fecha_registro { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}
