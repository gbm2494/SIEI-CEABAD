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
        public void insertarPersona(object[] nueva)
        {
            EntidadPersona nuevaPersona = new EntidadPersona(1, nueva);
            Boolean resultado = controladoraBDPersonas.insertarPersona(nuevaPersona);

           
        }
    }
}