using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SIEI.Capas.Capa_de_Acceso_a_Datos;
using SIEI.Capas.Capa_Entidad;
using SIEI.Models;

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

        public List<Requerimiento> consultarRequerimientos(string idEempresa)
        {
            return controladoraBDEmpresas.consultarRequerimientos(idEempresa);
        }

        public List<Area_Trabajo> consultarAreaTrabajo()
        {
            return controladoraBDEmpresas.consultarAreaTrabajo();
        }

        public void insertarPuesto(object[] nueva)
        {
            EntidadPuesto nuevoPuesto = new EntidadPuesto(nueva);
            Boolean resultado = controladoraBDEmpresas.insertarPuesto(nuevoPuesto);
        }

    }
}