using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
namespace SIEI
{
    public partial class contratarServicios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            string userName = HttpContext.Current.User.Identity.Name;
            llenarGrid(userName);

        }
        private void llenarGrid(string nm) {
            DataTable dt = crearTablaPuestos();
            Object[] datos = new Object[4];
            datos[0] = "-";
            datos[1] = "-";
            datos[2] = "-";
            datos[3] = "-";
            dt.Rows.Add(datos);
            this.gridDisenos.DataSource = dt;
            this.gridDisenos.DataBind();

        }

        protected DataTable crearTablaPuestos()
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