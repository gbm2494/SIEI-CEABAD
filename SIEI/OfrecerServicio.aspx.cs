using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using SIEI.Capas.Capa_Control;
using System.IO;

namespace SIEI
{
    public partial class OfrecerServicio : System.Web.UI.Page
    {
        ControladoraPersonal controladoraPersonas = new ControladoraPersonal();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["Role"] == null)
            {
                Response.Redirect("~/");
            }

            if (!IsPostBack)
            {
                llenarComboboxServicio();
            }

            if (IsPostBack && FileUploadImage.PostedFile != null)
            {
                if (FileUploadImage.PostedFile.FileName.Length > 0)
                {
                    FileUploadImage.SaveAs(Server.MapPath("~/") + FileUploadImage.PostedFile.FileName);
                    ImgUploaded.ImageUrl = "~/" + FileUploadImage.PostedFile.FileName;

                }
            }
        }

        protected void llenarComboboxServicio()
        {
            List<string> servicios = controladoraPersonas.listaServicios();

            comboServicio.Items.Add("Seleccione");

            for (int i = 0; i < servicios.Count; i++)
            {
                comboServicio.Items.Add(servicios.ElementAt(i));
            }
        }

        protected void actualizarServicio(object sender, EventArgs e)
        {
            if (comboServicio.Text != "Seleccione")
            {
                object[] datos = new object[4];
                datos[0] = txtDesc.Text;

                Stream fs = FileUploadImage.PostedFile.InputStream;
                BinaryReader br = new BinaryReader(fs);
                byte[] archivo = br.ReadBytes((Int32)fs.Length);
                datos[1] = archivo;

                datos[2] = txtCosto.Text;

                datos[3] = comboServicio.Text;

                if (controladoraPersonas.insertarServicio(datos))
                {
                    //exito
                }
                else
                {
                    //error
                }
            }
            else
            {
                //error
            }

            
            

        }
    }
}