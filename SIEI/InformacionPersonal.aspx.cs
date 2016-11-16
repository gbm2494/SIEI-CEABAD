using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SIEI.Models;
using SIEI.Capas.Capa_Control;

namespace SIEI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        ControladoraPersonal controladoraPersonas = new ControladoraPersonal();

        protected void Page_Load(object sender, EventArgs e)
        {

        }


        public void actualizar()
        {
            //actualizar datos persona
            object[] datosPersona = new object[5];

            datosPersona[0] = txtIdentificacion.Text;
            datosPersona[1] = txtNombre.Text;
            datosPersona[2] = txtApellido.Text;
            datosPersona[3] = txtApellido2.Text;
            datosPersona[4] = chkDiscapacidad.Checked;
            datosPersona[5] = txtCorreo.Text;

            controladoraPersonas.actualizarPersona(datosPersona);

            //actualizar contraseña

            //actualizar telefonos




        }

    }
}