using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace SIEI
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void lnkNumero_Click(object sender, EventArgs e)
        {
            txtPassword.Attributes["Value"] = txtPassword.Text;
            txtConfirm.Attributes["Value"] = txtConfirm.Text;

            if (txtTelefono.Text != "")
            {
                listTelefonos.Items.Add(txtTelefono.Text);
                txtTelefono.Text = "";
            }

            Update_Telefonos.Update();
        }
    }
}