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
    
    public partial class Comentarios_Clientes
    {
        public int id_comentario { get; set; }
        public decimal calificacion { get; set; }
        public string comentario { get; set; }
        public int id_cliente { get; set; }
        public System.DateTime fecha_registro { get; set; }
    
        public virtual Cliente Cliente { get; set; }
    }
}