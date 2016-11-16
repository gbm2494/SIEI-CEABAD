using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIEI.Capas.Capa_Entidad
{
    public class EntidadAplica
    {
        private string IdentificacionAplicante { get; set; }
        private string identificacionPuesto { get; set; }
        private DateTime fechaAplicacion { get; set; }

        public EntidadAplica()
        {
        }
    }
}