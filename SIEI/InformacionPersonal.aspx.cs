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
            if (Session["Role"] == null)
            {
                Response.Redirect("~/");
            }
            else {

                object[] resultado = controladoraPersonas.obtenerDatosPersonaLoggeada();

                //en la posición 0 del objeto viene la identificación
                txtIdentificacion.Text = resultado[0].ToString();

                //posición 1 nombre
                if (resultado[1] != null)
                {
                    txtNombre.Text = resultado[1].ToString();
                }

                if (resultado[2] != null)
                {
                    txtApellido.Text = resultado[2].ToString();
                }

                if (resultado[3] != null)
                {
                    txtApellido2.Text = resultado[3].ToString();
                }

                if (resultado[4] != null)
                {
                    chkDiscapacidad.Checked = Convert.ToBoolean(resultado[4]);
                }

                if (resultado[5] != null)
                {
                    txtCorreo.Text = resultado[5].ToString();
                }

                //hay curriculo cargado
                if (resultado[6] != null)
                {
                }

            }

        }


        public void actualizar()
        {
            //actualizar datos persona
            object[] datosPersona = new object[7];

            datosPersona[0] = txtIdentificacion.Text;
            datosPersona[1] = txtNombre.Text;
            datosPersona[2] = txtApellido.Text;
            datosPersona[3] = txtApellido2.Text;
            datosPersona[4] = chkDiscapacidad.Checked; //REVISAR
            datosPersona[5] = txtCorreo.Text;


            Stream fs = fileUploadCurriculo.PostedFile.InputStream;
            BinaryReader br = new BinaryReader(fs);
            byte[] archivo = br.ReadBytes((Int32)fs.Length);

            datosPersona[6] = archivo;

            controladoraPersonas.actualizarPersona(datosPersona);

            //actualizar contraseña

            //actualizar telefonos
        }

        protected void btnActualizar(object sender, EventArgs e)
        {
            actualizar();
        }
    }
}