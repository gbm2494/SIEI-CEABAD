using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIEI
{
    public partial class contratarServicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void gridPuestos_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            if (e.CommandName == "seleccionarPuesto")
            {
                LinkButton lnkConsulta = (LinkButton)e.CommandSource;
                string idPuestoConsultado = lnkConsulta.CommandArgument;

                if (idPuestoConsultado.Equals("-") == false)
                {

                    Session["idPuestoConsultado"] = idPuestoConsultado;


                }


                //listMiembrosDisponibles.Items.Clear();
            }

        }
    }
}