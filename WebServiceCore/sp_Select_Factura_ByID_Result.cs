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
    
    public partial class sp_Select_Factura_ByID_Result
    {
        public int id_factura { get; set; }
        public System.DateTime fecha_registro { get; set; }
        public int id_metpago { get; set; }
        public int id_empleado { get; set; }
        public decimal subtotal_servicio { get; set; }
        public int id_tipo_compra { get; set; }
        public decimal impuestos { get; set; }
        public decimal total_descuento { get; set; }
        public decimal monto_total { get; set; }
        public string ncf { get; set; }
        public System.DateTime vencimiento_fact { get; set; }
        public string nombre_cliente { get; set; }
        public int id_cliente { get; set; }
        public bool entrega_domicilio { get; set; }
        public int id_sucursal { get; set; }
    }
}
