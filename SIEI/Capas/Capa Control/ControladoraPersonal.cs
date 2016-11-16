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

        public void actualizarPersona(object[] actualizado)
        {
            Boolean resultado;
            EntidadPersona personaActualizada = new EntidadPersona(2, actualizado);
            return controladoraBDPersonas.modificarPersona(personaActualizada);
        }

    }
}