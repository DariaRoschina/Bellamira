using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebClient.Models;
using Bellamira;
namespace WebClient.Account
{
    public static class Test1
    {
        public static string My_str1
        {
            get
            {
                return str1;
            }
            set
            {
                str1 = value;
            }
        }
        public static string str1 = "  ";
    }
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
            // Включите, когда будет включено подтверждение учетной записи для функции сброса пароля
            //ForgotPasswordHyperLink.NavigateUrl = "Forgot";
            //OpenAuthLogin.ReturnUrl = Request.QueryString["ReturnUrl"];
            RegisterHyperLink.NavigateUrl = "Register";
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                RegisterHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }
        }

        protected void LogIn(object sender, EventArgs e)
        {
            bool tmp;
            try
            {
                IceApplication.getInstance().EntryPrx.login(LOGIN.Text, Password.Text);
                 tmp = true;
            }
            catch (UserAlreadyExists uae)
            {
                 tmp = false;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('User already exists!');", true);
            }

            if (tmp == true) {

                Test1.My_str1 = "Вы вошли как " + IceApplication.getInstance().SessionPrx.getUserManager().getUser(LOGIN.Text).Fam + " "+ IceApplication.getInstance().SessionPrx.getUserManager().getUser(LOGIN.Text).Name; }


            //if (IsValid)
            //{
            //    // Проверка пароля пользователя
            //    var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            //    var signinManager = Context.GetOwinContext().GetUserManager<ApplicationSignInManager>();

            //    // Сбои при входе не приводят к блокированию учетной записи
            //    // Чтобы ошибки при вводе пароля инициировали блокирование, замените на shouldLockout: true
            //    var result = signinManager.PasswordSignIn(Email.Text, Password.Text, RememberMe.Checked, shouldLockout: false);

            //    switch (result)
            //    {
            //        case SignInStatus.Success:
            //            IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //            break;
            //        case SignInStatus.LockedOut:
            //            Response.Redirect("/Account/Lockout");
            //            break;
            //        case SignInStatus.RequiresVerification:
            //            Response.Redirect(String.Format("/Account/TwoFactorAuthenticationSignIn?ReturnUrl={0}&RememberMe={1}", 
            //                                            Request.QueryString["ReturnUrl"],
            //                                            RememberMe.Checked),
            //                              true);
            //            break;
            //        case SignInStatus.Failure:
            //        default:
            //            FailureText.Text = "Неудачная попытка входа";
            //            ErrorMessage.Visible = true;
            //            break;
            //    }
            //}
        }
    }
}