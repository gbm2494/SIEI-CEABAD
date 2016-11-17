using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIEI.Capas.Capa_de_Acceso_a_Datos;
using SIEI.Capas.Capa_Entidad;

namespace SIEI.Capas.Capa_Control
{
    public class ControladoraPersonal
    {
        ControladoraBDPersonal controladoraBDPersonas = new ControladoraBDPersonal();

        /*
         */
        public Boolean insertarPersona(object[] nueva)
        {

            EntidadPersona nuevaPersona = new EntidadPersona(1, nueva);
            return controladoraBDPersonas.insertarPersona(nuevaPersona);
        }

        /*
         */
        public Boolean actualizarPersona(object[] actualizado)
        {
            EntidadPersona personaActualizada = new EntidadPersona(2, actualizado);

            return controladoraBDPersonas.modificarPersona(personaActualizada);
        }

        /**/
        public object[] obtenerDatosPersonaLoggeada()
        {
            return controladoraBDPersonas.obtenerDatosPersonaLoggeada();
        }

        public byte[] obtenerCurriculoLoggeado()
        {
            return controladoraBDPersonas.obtenerCurriculoLoggeado();
        }
        /**/
        public Boolean actualizarContrasena(string password)
        {
            return controladoraBDPersonas.actualizarContrasena(password);
        }

        /**/

        public void eliminarTelefonosActuales(string identificacion)
        {
            controladoraBDPersonas.eliminarTelefonosActuales(identificacion);
        }

        /**/
        public Boolean guardarTelefonoUsuarioLogueado(object[] datos)
        {
            EntidadTelefono_Persona nuevo = new EntidadTelefono_Persona(datos);
            return controladoraBDPersonas.guardarTelefonoUsuarioLogueado(nuevo);
        }

        /**/
        public object[] obtenerTelefonos(string identificacion)
        {
            return controladoraBDPersonas.obtenerTelefonos(identificacion);
        }

    }
}