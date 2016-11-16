using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIEI.Capas.Capa_Entidad;
using SIEI.Models;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Microsoft.AspNet.Identity.Owin;

namespace SIEI.Capas.Capa_de_Acceso_a_Datos
{
    public class ControladoraBDPersonal
    {
        Entities bd = new Entities();
        ApplicationDbContext context = new ApplicationDbContext();

        /*
         */
        public Boolean insertarPersona(EntidadPersona nueva)
        {
            Boolean resultado = false; 

            Persona nuevaPersona = new Persona(nueva);

            try
            {
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                UserManager.AddToRole(nueva.getId, "Persona");

                bd.Persona.Add(nuevaPersona);
                bd.SaveChanges();

                resultado = true;
            }
            catch (Exception e)
            {
                resultado = false;
            }

            return resultado;
        }

        /**/
        public Boolean modificarPersona(EntidadPersona actualizada)
        {
            Boolean resultado = false;

            var original = bd.Persona.Find(actualizada.getIdentificacion);

            Persona nuevaPersona = new Persona(actualizada, true);

            if (original != null)
            {
                bd.Entry(original).CurrentValues.SetValues(nuevaPersona);
                bd.SaveChanges();

                resultado = false;
            }
            return resultado;
        }

        /**/
        public Boolean actualizarContrasena(string password)
        {
            Boolean result = false;

            var manager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();

            IdentityResult resultado = manager.AddPassword(HttpContext.Current.User.Identity.GetUserId(), password);

            if (resultado.Succeeded)
            {
                result = true;
            }

            return result;
        }

        /**/
        public object[] obtenerDatosPersonaLoggeada()
        {
            string id = HttpContext.Current.User.Identity.GetUserId();

            List<Persona> persona = bd.Persona.Where(x => x.id == id).ToList();

            Persona resultado = persona.FirstOrDefault();

            object[] retorno = new object[7];

            retorno[0] = resultado.identificacion;
            retorno[1] = resultado.nombre;
            retorno[2] = resultado.apellido1;
            retorno[3] = resultado.apellido2;
            retorno[4] = resultado.discapacidad;
            retorno[5] = resultado.correo;
            retorno[6] = resultado.curriculo;

            return retorno;

        }
    }
}