//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PuntoDeVenta.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Telefonos
    {
        public int Id { get; set; }
        public string Num_tel { get; set; }
        public int IdProveedor { get; set; }
    
        public virtual Proveedor Proveedor { get; set; }
    }
}
