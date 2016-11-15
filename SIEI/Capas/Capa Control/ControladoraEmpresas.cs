using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIEI.Capas.Capa_de_Acceso_a_Datos;
using SIEI.Capas.Capa_Entidad;

namespace SIEI.Capas.Capa_Control
{
    public class ControladoraEmpresas
    {
        ControladoraBDEmpresas controladoraBDEmpresas = new ControladoraBDEmpresas();

        /*
         */
        public void insertarEmpresa(object[] nueva)
        {
            EntidadEmpresa nuevaEmpresa = new EntidadEmpresa(1, nueva);
            Boolean resultado = controladoraBDEmpresas.insertarEmpresa(nuevaEmpresa);


        }
    }
}