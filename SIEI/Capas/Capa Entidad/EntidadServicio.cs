using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
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
        public EntidadServicio(object[] nuevo)
        {
            descripcion = nuevo[0].ToString();

            if (nuevo[1] != null)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new MemoryStream())
                {
                    bf.Serialize(ms, nuevo[1]);
                    imagen = ms.ToArray();
                }
            }

            costo = nuevo[2].ToString();
            tipoServicio = nuevo[3].ToString();

        }

        public int getId
        {
            get { return id; }
            set { id = value; }
        }

        public string getDescripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public byte[] getImagen
        {
            get { return imagen; }
            set { imagen = value; }
        }

        public string getCosto
        {
            get { return costo; }
            set { costo = value; }
        }

        public string getTipoServicio
        {
            get { return tipoServicio; }
            set { tipoServicio = value; }
        }

        public string getIdentificacionPersona
        {
            get { return identificacionPersona; }
            set { identificacionPersona = value; }
        }
    }
}