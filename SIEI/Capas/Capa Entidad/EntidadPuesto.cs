using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SIEI.Capas.Capa_Entidad
{
    public class EntidadPuesto
    {
        private string identificacion { get; set; }
        private string nombre { get; set; }
        private string descripcion { get; set; }
        private string ubicacionPuesto { get; set; }
        private int idArea { get; set; }

        /*
         */
        public EntidadPuesto(object[] objecto)
        {
            this.identificacion = objecto[0].ToString();
            this.nombre = objecto[1].ToString();
            this.descripcion = objecto[2].ToString();
            this.ubicacionPuesto = objecto[3].ToString();
            this.idArea = (int)objecto[4];

        }
        public string getIdentificacion
        {
            get { return identificacion; }
            set { identificacion = value; }
        }

        public string getNombre
        {
            get { return nombre; }
            set { nombre = value; }
        }

        public string getDescripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }

        public string getUbicacionPuesto
        {
            get { return ubicacionPuesto; }
            set { ubicacionPuesto = value; }
        }

        public int getIdArea
        {
            get { return idArea; }
            set { idArea = value; }
        }
    }
}