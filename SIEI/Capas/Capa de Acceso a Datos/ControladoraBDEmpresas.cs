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

        /*
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



        public List<Requerimiento> consultarRequerimientos(string idEempresa)
        {
            var id = bd.Empresa.Where(e => e.id == idEempresa).ToList().FirstOrDefault().identificacion;
            var req = bd.Requerimiento.Where(r=>r.identificacionEmpresa.Equals(id));
     
            return req.ToList();
        }





    }
}