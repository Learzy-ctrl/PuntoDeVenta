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
    
    public partial class Permiso
    {
        public int Id { get; set; }
        public Nullable<int> Idrol { get; set; }
        public Nullable<int> Idopcion { get; set; }
        public Nullable<bool> permitido { get; set; }
    
        public virtual Opcion Opcion { get; set; }
        public virtual Rol Rol { get; set; }
    }
}
