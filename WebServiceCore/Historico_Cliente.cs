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
    
    public partial class Historico_Cliente
    {
        public int id_cliente { get; set; }
        public string nombre { get; set; }
        public string apellido { get; set; }
        public System.DateTime fecha_nac { get; set; }
        public System.DateTime fecha_cambio { get; set; }
        public string email { get; set; }
        public string direccion { get; set; }
        public string num_telefono { get; set; }
        public int id_estado { get; set; }
    
        public virtual Estado Estado { get; set; }
    }
}
