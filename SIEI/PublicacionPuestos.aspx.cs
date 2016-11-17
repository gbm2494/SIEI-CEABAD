using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.AspNet.Identity;

namespace SIEI
{
    public partial class PublicacionPuestos : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string userName = HttpContext.Current.User.Identity.Name;
            int a = 0;
        }

        protected DataTable crearTablaDisenos()
        {
            DataTable dt = new DataTable();
            DataColumn columna;
            DataRow row = dt.NewRow();

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Identificador";
            dt.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Nombre";
            dt.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Descripción";
            dt.Columns.Add(columna);

            columna = new DataColumn();
            columna.DataType = System.Type.GetType("System.String");
            columna.ColumnName = "Ubicación";
            dt.Columns.Add(columna);

            return dt;
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