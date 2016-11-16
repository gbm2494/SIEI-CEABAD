using System.Linq;
using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using SIEI.Models;
using SIEI.Capas.Capa_Control;

namespace SIEI.Account
{
    public partial class RegistrarEmpresa : Page
    {

        ControladoraEmpresas controladoraEmpresas = new ControladoraEmpresas();

        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();
            var user = new ApplicationUser() { UserName = txtEmail.Text, Email = txtEmail.Text };
            IdentityResult result = manager.Create(user, txtPassword.Text);
            if (result.Succeeded)
            {
                // For more information on how to enable account confirmation and password reset please visit http://go.microsoft.com/fwlink/?LinkID=320771
                //string code = manager.GenerateEmailConfirmationToken(user.Id);
                //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
                //manager.SendEmail(user.Id, "Confirm your account", "Please confirm your account by clicking <a href=\"" + callbackUrl + "\">here</a>.");

                signInManager.SignIn(user, isPersistent: false, rememberBrowser: false);

                //Creo el objeto con los atributos necesarios para crear la nueva persona
                Object[] nuevaEmpresa = new Object[3];
                nuevaEmpresa[0] = txtIdentificacion.Text;
                nuevaEmpresa[1] = txtNombre.Text;
                nuevaEmpresa[2] = user.Id;

                //Llamo a la controladora para que realice la inserción de la persona en el sistema
                controladoraEmpresas.insertarEmpresa(nuevaEmpresa);
                check.Style.Clear();

                //txtconfirmPassword.Text = "";
                //txtEmail.Text = "";
                //txtIdentificacion.Text = "";
                //txtNombre.Text = "";
                //txtPassword.Text = "";

                Session["Role"] = "Empresa";

                IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            }
            else
            {

                ErrorMessage.Text = result.Errors.FirstOrDefault();
                error.Style.Clear();
            }
        }
    }
}