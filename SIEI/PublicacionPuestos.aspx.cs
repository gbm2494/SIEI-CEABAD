using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Microsoft.AspNet.Identity;
using SIEI.Capas.Capa_Control;

namespace SIEI
{
    public partial class PublicacionPuestos : System.Web.UI.Page
    {
        string userName;
        ControladoraEmpresas controladoraEmpresas = new ControladoraEmpresas();
        protected void Page_Load(object sender, EventArgs e)
        {

            userName = HttpContext.Current.User.Identity.GetUserId();
            llenarComboArea("222");
            llenarGrid(userName);
            llenarListaReq();
        }


        protected void CreatePuesto_Click(object sender, EventArgs e)
        {
            //Creo el objeto con los atributos necesarios para crear el nuevo puesto

            var contador = listAsignados.Items.Count;
            var contadorDos = 4;
            contador = contador + 4;
            Object[] nuevaEmpresa = new Object[contador];
            nuevaEmpresa[0] = txtIdentificacion.Text;
            nuevaEmpresa[1] = txtNombre.Text;
            nuevaEmpresa[2] = txtDescripcion;
            nuevaEmpresa[3] = comboAreaTrabajo.SelectedItem.ToString();
            for (var i = 0; i < listAsignados.Items.Count; ++i)
            {
                nuevaEmpresa[contadorDos] = listAsignados.Items[i];
            }


            
        }

        protected void llenarListaReq()
        {
            var req = controladoraEmpresas.consultarRequerimientos(userName);
            foreach (var r in req)
            {
                listReqDisponibles.Items.Add(r.descripcion);
            }


        }


        protected void llenarComboArea(string cedulaUsuario)
        {
            Object[] datos;
            datos = new Object[3];
            datos[0] = "Seleccione";
            datos[1] = "Front End Developer";
            datos[2] = "Desarrollo móvil";
            this.comboAreaTrabajo.DataSource = datos;
            this.comboAreaTrabajo.DataBind();


        }

        protected void areaSeleccionada(object sender, EventArgs e)
        {
            llenarComboArea("3434535");
        }

        protected void llenarGrid(string user)
        {
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