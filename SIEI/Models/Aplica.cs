//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SIEI.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Aplica
    {
        public string IdentificacionAplicante { get; set; }
        public string identificacionPuesto { get; set; }
        public Nullable<System.DateTime> fechaAplicacion { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Puesto Puesto { get; set; }
    }
}
