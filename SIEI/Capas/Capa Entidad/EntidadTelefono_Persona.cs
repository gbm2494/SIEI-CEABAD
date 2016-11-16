using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIEI.Capas.Capa_Entidad
{
    public class EntidadTelefono_Persona
    {
        private string identificacion;
        private string numero;

        public string getIdentificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public string getNumero
        {
            get { return numero; }
            set { numero = value; }
        }

        /*
         */
        public EntidadTelefono_Persona(object[] datos)
        {
            identificacion = datos[0].ToString();
            numero = datos[1].ToString();
        }

    }
}