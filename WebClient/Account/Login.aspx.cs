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
        public static string str1 = " ";
    }
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
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
            if (Test1.My_str1 != " ")
            {
                Response.Redirect("PersonalCab.aspx");

            };

        }
    }
}