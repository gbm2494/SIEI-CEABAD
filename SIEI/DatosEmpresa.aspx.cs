using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace SIEI
{
    public partial class DatosEmpresa : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            llenarComboArea("3434535");
        }

        protected void llenarComboArea(string cedulaUsuario)
        {
            Object[] datos;
            datos = new Object[1];
            datos[0] = "Seleccione";
            this.comboAreaTrabajo.DataSource = datos;
            this.comboAreaTrabajo.DataBind();


        }

        protected void areaSeleccionada(object sender, EventArgs e)
        {
            llenarComboArea("3434535");
        }


    }
}