using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIEI.Capas.Capa_Entidad
{
    public class EntidadPersona
    {
        private string identificacion;
        private string id;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string correo;
        private byte[] curriculo;
        private Boolean discapacidad;

        /*
         */
        public EntidadPersona(int tipo, object[] datos)
        {
            //inserción necesaria solo si es un registrar persona
            if (tipo == 1)
            {
                identificacion = datos[0].ToString();
                correo = datos[1].ToString();
                id = datos[2].ToString();

            }
        }

        public string getIdentificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public string getId
        {
            get { return id; }
            set { id = value; }
        }

        public string getNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string getApellido1
        {
            get { return apellido1; }
            set { apellido1 = value; }
        }

        public string getApellido2
        {
            get { return apellido2; }
            set { apellido2 = value; }
        }

        public string getCorreo
        {
            get { return correo; }
            set { correo = value; }
        }

        public  byte[] getCurriculo
        {
            get { return curriculo; }
            set { curriculo = value; }
        }

        public Boolean getDiscapacidad
        {
            get { return discapacidad; }
            set { discapacidad = value; }
        }
    }
}