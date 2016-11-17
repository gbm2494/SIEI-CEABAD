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
    public class ControladoraBDEmpresas
    {
        Entities bd = new Entities();
        ApplicationDbContext context = new ApplicationDbContext();

        /*Requiere: un objeto de tipo entidadEmpresa que va a ser insertado en la base de datos
         * Modifica: inserta una nueva empresa a la blase
         * Retorna: True si logro almacenar la empresa
         */
        public Boolean insertarEmpresa(EntidadEmpresa nueva)
        {
            Boolean resultado = false;

            Empresa nuevaEmpresa = new Empresa(nueva);

            try
            {
                var UserManager = new UserManager<ApplicationUser>(new UserStore<ApplicationUser>(context));

                UserManager.AddToRole(nueva.getId, "Empresa");

                bd.Empresa.Add(nuevaEmpresa);
                bd.SaveChanges();

                resultado = true;
            }
            catch (Exception e)
            {
                resultado = false;
            }

            return resultado;
        }


        /*Requiere: una entidad puesto para almacearlo en la base de datos
         * Modifica: no modifica datos
         * Retorna: True si puede insertar la tupla, false si no
         */
        public Boolean insertarPuesto(EntidadPuesto nueva)
        {
            Boolean resultado = false;

            Puesto nuevoPuesto = new Puesto(nueva);

            try
            {
                

                bd.Puesto.Add(nuevoPuesto);
                bd.SaveChanges();

                resultado = true;
            }
            catch (Exception e)
            {
                resultado = false;
            }

            return resultado;
        }


        /*Requiere: identificacion de la empresa
         * Modifica: no modifica datos
         * Retorna: lista de requerimientos que puede tener una empresa
         */
        public List<Requerimiento> consultarRequerimientos(string idEempresa)
        {
            var id = bd.Empresa.Where(e => e.id == idEempresa).ToList().FirstOrDefault().identificacion;
            var req = bd.Requerimiento.Where(r=>r.identificacionEmpresa.Equals(id));
     
            return req.ToList();
        }


        /*Requiere: no requiere datos
         * Modifica: no modifica datos
         * Retorna: lista de areas de trabajo que puede tener una empresa
         */
        public List<Area_Trabajo> consultarAreaTrabajo()
        {
            var areas = from b in bd.Area_Trabajo select b;
            return areas.ToList();
        }




    }
}