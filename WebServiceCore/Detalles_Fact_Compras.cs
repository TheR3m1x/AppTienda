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
    
    public partial class Detalles_Fact_Compras
    {
        public int id_det_fact { get; set; }
        public int id_factura { get; set; }
        public int id_producto { get; set; }
        public int cant_producto { get; set; }
        public decimal precio_unitario { get; set; }
        public decimal descuento { get; set; }
    
        public virtual Factura Factura { get; set; }
        public virtual Producto Producto { get; set; }
    }
}
