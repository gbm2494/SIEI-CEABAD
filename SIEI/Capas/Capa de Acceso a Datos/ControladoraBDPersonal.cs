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

            IdentityResult resultado2 = manager.RemovePassword(HttpContext.Current.User.Identity.GetUserId());

            if (resultado2.Succeeded)
            {
                IdentityResult resultado = manager.AddPassword(HttpContext.Current.User.Identity.GetUserId(), password);

                if (resultado.Succeeded)
                {
                    result = true;
                }
                else
                {
                    result = false;
                }
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

        /**/
        public byte[] obtenerCurriculoLoggeado()
        {
            string id = HttpContext.Current.User.Identity.GetUserId();

            List<Persona> persona = bd.Persona.Where(x => x.id == id).ToList();

            Persona resultado = persona.FirstOrDefault();

            return resultado.curriculo;
        }

        /**/
        public object[] obtenerTelefonos(string identificacion)
        {

            List<Telefono_Persona> telefonos = bd.Telefono_Persona.Where(x => x.identificacion == identificacion).ToList();

            object[] retorno = new object[2];

            for(int i = 0; i < telefonos.Count; i++)
            {
                retorno[i] = telefonos.ElementAt(i).numero;
            }

            return retorno;
        }

        /**/
        public void eliminarTelefonosActuales(string identificacion)
        {
            List<Telefono_Persona> listaNumeros = bd.Telefono_Persona.Where(x => x.identificacion == identificacion).ToList();

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                bd.Telefono_Persona.Remove(listaNumeros.ElementAt(i));
                bd.SaveChanges();
            }
        }

        /**/
        public Boolean guardarTelefonoUsuarioLogueado(EntidadTelefono_Persona nueva)
        {
            Boolean resultado = false;

            Telefono_Persona nuevoTelefono = new Telefono_Persona(nueva);

            try
            {
                
                bd.Telefono_Persona.Add(nuevoTelefono);
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
        public List<string> listaServicios()
        {
            List<Tipo_Servicio> lista = bd.Tipo_Servicio.ToList();
            List<string> resultado = new List<string>() ;

            for (int i = 0; i < lista.Count; i++)
            {
                resultado.Add(lista.ElementAt(i).nombre.ToString());
            }

            return resultado;
        }

        /**/
        public Boolean insertarServicio(EntidadServicio nueva)
        {
            Boolean resultado = false;

            Servicio nuevo = new Servicio(nueva);

            try
            {

                bd.Servicio.Add(nuevo);
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