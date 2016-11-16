using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIEI.Capas.Capa_Entidad
{
    public class EntidadServicio
    {
        private int id { get; set; }
        private string descripcion { get; set; }
        private byte[] imagen { get; set; }
        private string costo { get; set; }
        private string tipoServicio { get; set; }
        private string identificacionPersona { get; set; }

        /*
         */
        public EntidadServicio()
        {
        }
    }
}