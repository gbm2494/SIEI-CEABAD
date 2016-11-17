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

        /*Requiere: Requiere un objeto con los datos de la nueva empresa por insertar.
      * Modifica:  La tabla empresas 
      * Retorna:  Retorna true si se pudo insertar, false si no.
      */

        public void insertarEmpresa(object[] nueva)
        {
            EntidadEmpresa nuevaEmpresa = new EntidadEmpresa(1, nueva);
            Boolean resultado = controladoraBDEmpresas.insertarEmpresa(nuevaEmpresa);


        }


        /*Requiere: String con el id de la empresa
     * Modifica:  Nada 
     * Retorna:   Una lista de los requerimientos de la empresa
     */

        public List<Requerimiento> consultarRequerimientos(string idEempresa)
        {
            return controladoraBDEmpresas.consultarRequerimientos(idEempresa);
        }


        /*Requiere: nada
     * Modifica:  nada 
     * Retorna:  Una lista con el area de trabajos
     */

        public List<Area_Trabajo> consultarAreaTrabajo()
        {
            return controladoraBDEmpresas.consultarAreaTrabajo();
        }

        /*Requiere: Un objeto con el puesto por insertar.
     * Modifica:  La tabla puestos en la base de datos
     *  * Retorna:  true si se inserta false si no.
     */


        public void insertarPuesto(object[] nueva)
        {
            EntidadPuesto nuevoPuesto = new EntidadPuesto(nueva);
            Boolean resultado = controladoraBDEmpresas.insertarPuesto(nuevoPuesto);
        }

    }
}