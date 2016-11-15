using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIEI.Capas.Capa_Entidad
{
    public class EntidadEmpresa
    {
        private string identificacion;
        private string id;
        private string nombre;
        private Boolean estado;
        private Boolean certificacion;
        private int puntos;
        private string especialidad;

        /*
         */
        public EntidadEmpresa(int tipo, object[] datos)
        {
            //inserción necesaria solo si es un registrar empresa
            if (tipo == 1)
            {
                identificacion = datos[0].ToString();
                nombre = datos[1].ToString();
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

      

        public Boolean getEstado
        {
            get { return estado; }
            set { estado = value; }
        }

        public Boolean getCertificacion
        {
            get { return certificacion; }
            set { certificacion = value; }
        }

        public int getPuntos
        {
            get { return puntos; }
            set { puntos = value; }
        }

        public string getEspecialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }
    }
}