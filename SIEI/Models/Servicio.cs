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
    using SIEI.Capas.Capa_Entidad;
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Web;
    using SIEI.Capas.Capa_Entidad;
    using SIEI.Models;
    using Microsoft.AspNet.Identity;
    using Microsoft.AspNet.Identity.EntityFramework;
    using Microsoft.AspNet.Identity.Owin;

    public partial class Servicio
    {
        Entities bd = new Entities();

        public int id { get; set; }
        public string descripcion { get; set; }
        public byte[] imagen { get; set; }
        public string costo { get; set; }
        public string tipoServicio { get; set; }
        public string identificacionPersona { get; set; }
    
        public virtual Persona Persona { get; set; }
        public virtual Tipo_Servicio Tipo_Servicio { get; set; }

        /**/
        public Servicio(EntidadServicio nuevo)
        {
            descripcion = nuevo.getDescripcion;
            imagen = nuevo.getImagen;
            costo = nuevo.getCosto;
            tipoServicio = nuevo.getTipoServicio;
            string idUser = HttpContext.Current.User.Identity.GetUserId();

            identificacionPersona = bd.Persona.Where(x => x.id == idUser).ToList().FirstOrDefault().identificacion;

        }
    }
}
