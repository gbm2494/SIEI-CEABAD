using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;
using SIEI.Models;
using SIEI.Capas.Capa_Control;
using System.Runtime.Serialization.Formatters.Binary;

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

                if (!IsPostBack)
                {
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
                        lnkDownload.Text = "curriculo.pdf";
                        curriculoCargado.Style.Clear();

                    }

                    object[] telefonos = controladoraPersonas.obtenerTelefonos(txtIdentificacion.Text);

                    if (telefonos[0] != null)
                    {
                        txtTelefono.Text = telefonos[0].ToString();
                    }

                    if (telefonos[1] != null)
                    {
                        txtTelefono2.Text = telefonos[1].ToString();
                    }
                }



            }

        }

        /**/
        public Boolean actualizarPersona()
        {
            //actualizar datos persona
            object[] datosPersona = new object[7];

            datosPersona[0] = txtIdentificacion.Text;
            datosPersona[1] = txtNombre.Text;
            datosPersona[2] = txtApellido.Text;
            datosPersona[3] = txtApellido2.Text;
            datosPersona[4] = chkDiscapacidad.Checked; //REVISAR
            datosPersona[5] = txtCorreo.Text;

            if (!lnkDownload.Text.Contains("pdf"))
            {
                Stream fs = fileUploadCurriculo.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] archivo = br.ReadBytes((Int32)fs.Length);
                datosPersona[6] = archivo;
            }
            else {
                datosPersona[6] = null;
            }

            return controladoraPersonas.actualizarPersona(datosPersona);
        }

        /**/
        public Boolean actualizarContrasena()
        {
            if (txtPassword.Text != "" && txtConfirm.Text != "")
            {
                return controladoraPersonas.actualizarContrasena(txtConfirm.Text);
            }
            else
            {
                return false;
            }
        }

        /**/
        protected void actualizarTelefonos()
        {
            controladoraPersonas.eliminarTelefonosActuales(txtIdentificacion.Text);

            if (txtTelefono.Text != "")
            {
                object[] datos = new object[2];
                datos[0] = txtIdentificacion.Text;
                datos[1] = txtTelefono.Text;

                controladoraPersonas.guardarTelefonoUsuarioLogueado(datos);
            }

            if (txtTelefono2.Text != "")
            {
                object[] datos2 = new object[2];
                datos2[0] = txtIdentificacion.Text;
                datos2[1] = txtTelefono2.Text;

                controladoraPersonas.guardarTelefonoUsuarioLogueado(datos2);
            }
        }

        /**/
        protected void btnActualizar(object sender, EventArgs e)
        {
            actualizarTelefonos();

            if (actualizarPersona() == true && actualizarContrasena() == true)
            {
                //check.Style.Clear();
            }
        }

        /**/
        protected void DownloadFile(object sender, EventArgs e)
        {
            //Response.Clear();
            //Response.ContentType = "text/plain";
            //Response.AppendHeader("Content-Disposition", "attachment; filename=" + "curriculo.pdf");
            //Response.BinaryWrite(controladoraPersonas.obtenerCurriculoLoggeado());
            //Response.Flush();
            //Response.End();

            Response.ContentType = "application/pdf";
            Response.AddHeader("content-length", controladoraPersonas.obtenerCurriculoLoggeado().Length.ToString());
            Response.AppendHeader("Content-Disposition", "attachment; filename=curriculo.pdf");
            Response.BinaryWrite(controladoraPersonas.obtenerCurriculoLoggeado());
            
        }
    }
}