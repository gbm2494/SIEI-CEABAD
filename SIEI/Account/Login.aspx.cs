using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using SIEI.Models;
using System.Web.Security;
using Microsoft.AspNet.Identity.EntityFramework;
using System.Linq;
using System.Web.Providers.Entities;

namespace SIEI.Account
{
    public partial class Login : Page
    {
        ApplicationDbContext context = new ApplicationDbContext();

        protected void Page_Load(object sender, EventArgs e)
        {
           
            RegisterHyperLink.NavigateUrl = "Register";
            // Enable this once you have account confirmation enabled for password reset functionality
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
           // OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }

            var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>());
            var roles = roleManager.Roles.ToList();

            comboRol.Items.Clear();

            comboRol.Items.Add("Seleccione");

            for (int i = 0; i < roles.Count; i++)
            {
                comboRol.Items.Add(roles[i].Name.ToString());
            }

        }

        protected void LogIn(object sender, EventArgs e)
        {
            if (IsValid)
            {
                // Validate the user password
                var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
                var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

                // This doen't count login failures towards account lockout
                // To enable password failures to trigger lockout, change to shouldLockout: true
                var result = signinManager.PasswordSignIn(Email.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

                switch (result)
                {
                    case SignInStatus.Success:

                        var roleManager = new RoleManager<IdentityRole>(new RoleStore<IdentityRole>(new ApplicationDbContext()));

                        var usuarios = roleManager.FindByName(comboRol.Text).Users;

                        var usuariosLista = usuarios.ToList();

                        var user = manager.FindByName(Email.Text);

                        Boolean existe = false;
                        int i = 0;

                        while (existe == false && usuarios.Count > i)
                        {
                            if (usuariosLista[i].UserId == user.Id)
                            {
                                existe = true;
                            }

                            i++;
                        }

                        if (existe == true)
                        {
                            Session["Role"] = comboRol.SelectedValue;
                            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
                        }
                        else
                        {
                            FailureText.Text = "Intento de inicio de sesión inválido";
                            ErrorMessage.Visible = true;

                        }

                        break;

                    case SignInStatus.LockedOut:
                        Response.Redirect("/Account/Lockout");
                        break;
                    case SignInStatus.RequiresVerification:
                        Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}", 
                                                        Request.QueryString["ReturnUrl"],
                                                        RememberMe.Checked),
                                          true);
                        break;
                    case SignInStatus.Failure:
                    default:
                        FailureText.Text = "Intento de inicio de sesión inválido";
                        ErrorMessage.Visible = true;
                        
                        break;
                }
            }
        }
    }
}