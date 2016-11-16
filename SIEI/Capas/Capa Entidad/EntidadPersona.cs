using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

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
            else
            {
                identificacion = datos[0].ToString();
                nombre = datos[1].ToString();
                apellido1 = datos[2].ToString();
                apellido2 = datos[3].ToString();
                discapacidad = Convert.ToBoolean(datos[4]);
                correo = datos[5].ToString();

                if (datos[6] != null)
                {
                    BinaryFormatter bf = new BinaryFormatter();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        bf.Serialize(ms, datos[6]);
                        curriculo = ms.ToArray();    
                    }
                }

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