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

        /*Requiere: un nuevo objeto persona
        * Modifica: no modifica datos
        * Retorna: True si puede insertar la tupla, false si no
        */
        public Boolean insertarPersona(object[] nueva)
        {

            EntidadPersona nuevaPersona = new EntidadPersona(1, nueva);
            return controladoraBDPersonas.insertarPersona(nuevaPersona);
        }

        /*Requiere: Un objeto tipo persona con los datos actualizados de este.
       * Modifica: Modifica la tabla asociada a las persona
       * Retorna: True si puede actualizar la tupla, false si no
       */
        public Boolean actualizarPersona(object[] actualizado)
        {
            EntidadPersona personaActualizada = new EntidadPersona(2, actualizado);

            return controladoraBDPersonas.modificarPersona(personaActualizada);
        }

        /*Requiere: no requiere nada
       * Modifica: no modifica datos
       * Retorna: datos de la persona loggeada
       */
        public object[] obtenerDatosPersonaLoggeada()
        {
            return controladoraBDPersonas.obtenerDatosPersonaLoggeada();
        }


        /*Requiere: no requiere nada
        * Modifica: no modifica datos
        * Retorna: Obtiene el curriculum de la persona loggeada
        */
        public byte[] obtenerCurriculoLoggeado()
        {
            return controladoraBDPersonas.obtenerCurriculoLoggeado();
        }

        /*Requiere: Requiere el password
        * Modifica: Modifica (actualiza) la contraseña de la persona loggeada 
        * Retorna:  Retorna true si se puede actualizar, false si no.
        */
        public Boolean actualizarContrasena(string password)
        {
            return controladoraBDPersonas.actualizarContrasena(password);
        }


        /*Requiere: Requiere la identificacion para poder eliminar el telefono
       * Modifica:  Nada
       * Retorna:  Retorna true si se pudo eliminar, false si no.
       */

        public void eliminarTelefonosActuales(string identificacion)
        {
            controladoraBDPersonas.eliminarTelefonosActuales(identificacion);
        }

        /**/


        /*Requiere: Requiere los datos telefono para guardarls
     * Modifica:    La tabla relacionada a la persona loggueada
     * Retorna:     true si se guardo false si no.
     */
        public Boolean guardarTelefonoUsuarioLogueado(object[] datos)
        {
            EntidadTelefono_Persona nuevo = new EntidadTelefono_Persona(datos);
            return controladoraBDPersonas.guardarTelefonoUsuarioLogueado(nuevo);
        }

        /*Requiere: La identificacion para obtener el telefono
     * Modifica:  Nada
     * Retorna:   Los telefonos de acuardo a la identificacion
     */
        public object[] obtenerTelefonos(string identificacion)
        {
            return controladoraBDPersonas.obtenerTelefonos(identificacion);
        }

        /*Requiere: nada
      * Modifica:  Nada
      * Retorna:  Una lista de los servicios.
      */
        public List<string> listaServicios()
        {
            return controladoraBDPersonas.listaServicios();
        }

        /*Requiere: Requiere un objetos con los datos
     * Modifica:  la tabla serivios de la base de datos
     * Retorna:  true si se pudo insertar false si no
     */
        public Boolean insertarServicio(object[] datos)
        {
            EntidadServicio nuevo = new EntidadServicio(datos);
            return controladoraBDPersonas.insertarServicio(nuevo);
        }
    }
}