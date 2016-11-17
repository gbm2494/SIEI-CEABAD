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

        /*Requiere: un objeto de tipo entidadPersona con los datos de la nueva persona que se desea insertar
         * Modifica: Mediante EF inserta una nueva tupla en la base de datos
         * Retorna: True si puede insertar la tupla, false si no
         */
        public Boolean insertarPersona(EntidadPersona nueva)
        {
            Boolean resultado = false; 

            Persona nuevaPersona = new Persona(nueva);

            try
            {
                //obtiene el ID del usuario a insertar en la capa de seguridad Identity
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

        /*Requiere: un objeto de tipo EntidadPersona con los datos de la persona que se quiere actualizar en la BD
         Modifica: la modificación de la tupla en la base de datos
         Retorna: true si pudo realizar la modificiación de la tupla, false si no */ 
        public Boolean modificarPersona(EntidadPersona actualizada)
        {
            Boolean resultado = false;

            //encuentra la tupla original ha modificar
            var original = bd.Persona.Find(actualizada.getIdentificacion);

            Persona nuevaPersona = new Persona(actualizada, true);

            if (original != null)
            {
                //intenta actualizar la tupla original con la actualizada
                bd.Entry(original).CurrentValues.SetValues(nuevaPersona);
                bd.SaveChanges();

                resultado = false;
            }
            return resultado;
        }

        /*Requiere: el password que quiere actualizar en la base de datos
         * Modifica: intenta actualizar la contraseña en la base de datos
         * Retorna true si pudo actualizarla, false si no:
         */
        public Boolean actualizarContrasena(string password)
        {
            Boolean result = false;

            
            var manager = HttpContext.Current.GetOwinContext().GetUserManager<ApplicationUserManager>();

            //elimina la contraseña actual de la base de datos asociada al usuario
            IdentityResult resultado2 = manager.RemovePassword(HttpContext.Current.User.Identity.GetUserId());

            //si se pudo eliminar la contraseña se guarda la actual
            if (resultado2.Succeeded)
            {
                //añade la nueva contraseña para dicho usuario
                IdentityResult resultado = manager.AddPassword(HttpContext.Current.User.Identity.GetUserId(), password);

                //si se pudo actualizar
                if (resultado.Succeeded)
                {
                    result = true;
                }
                //no se pudo
                else
                {
                    result = false;
                }
            }
            return result;
        }

        /*Requiere: no requiere parámetros
         Modifica: obtiene los datos de la persona actualmente 
         Retorna: un objeto con los datos del usuario logueado
         */
        public object[] obtenerDatosPersonaLoggeada()
        {
            string id = HttpContext.Current.User.Identity.GetUserId();

            //realiza la busqueda de los datos de la persona loggeada
            List<Persona> persona = bd.Persona.Where(x => x.id == id).ToList();

            Persona resultado = persona.FirstOrDefault();

            //llena el objeto con los datos encontrados
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

        /*Requiere: no requiere parámetros
         Modifica: retorna el flujo de bytes del currículo del usuario loggeado
         Retorna: el flujo de bytes que corresponde al archivo del currículo
         */
        public byte[] obtenerCurriculoLoggeado()
        {
            string id = HttpContext.Current.User.Identity.GetUserId();

            //obtiene la persona loggeada en el sistema
            List<Persona> persona = bd.Persona.Where(x => x.id == id).ToList();

            Persona resultado = persona.FirstOrDefault();

            return resultado.curriculo;
        }

        /*Requiere: 
         * Modifica:
         * Retorna:
         */
        //public object[] obtenerAreas(string identificacion)
        //{

        //    List<Telefono_Persona> telefonos = bd.Telefono_Persona.Where(x => x.identificacion == identificacion).ToList();

        //    object[] retorno = new object[2];

        //    for (int i = 0; i < telefonos.Count; i++)
        //    {
        //        retorno[i] = telefonos.ElementAt(i).numero;
        //    }

        //    return retorno;
        //}

        /* Requiere: la identificación de la persona dueña de los teléfonos a consultar
         * Modifica: consulta los téléfonos de la persona asociados en la base de datos
         * Retorna: un objeto con los teléfonos asociados a la 
        */
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

        /* Requiere: la identificación de la persona dueña de los teléfonos a consultar
         * Modifica: elimina los telefonos asociados a una persona
         * Retorna: no retorna datos
        */
        public void eliminarTelefonosActuales(string identificacion)
        {
            List<Telefono_Persona> listaNumeros = bd.Telefono_Persona.Where(x => x.identificacion == identificacion).ToList();

            for (int i = 0; i < listaNumeros.Count; i++)
            {
                bd.Telefono_Persona.Remove(listaNumeros.ElementAt(i));
                bd.SaveChanges();
            }
        }

        /* Requiere: la entidad que presenta el telefono de una persona
         * Modifica: almacena el telefono asociado a una persona
         * Retorna: un booleano para indicar el estado de la acción
        */
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

        /* Requiere: no quiere ningún dato
         * Modifica: no modifica datos
         * Retorna: una lista de los servicios profesionales
        */
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

        /* Requiere: la entidad que representa un servicio que se puede ofrecer
         * Modifica: almacena el servicio
         * Retorna: un booleano para indicar el estado de la acción
        */
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