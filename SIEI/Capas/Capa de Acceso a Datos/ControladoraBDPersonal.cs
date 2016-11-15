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
    }
}