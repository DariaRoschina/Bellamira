using System;
using System.Linq;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using WebClient.Models;
using Bellamira;
using System.Collections.Generic;
using System.Web.UI.WebControls;

namespace WebClient.Account
{ 
    public partial class Register : Page
    {
        protected void Page_load()
        {
            if (!IsPostBack)

            {
                TypeUser.DataValueField = "NameType";
                TypeUser.DataSource = IceApplication.getInstance().SessionPrx.getUserManager().getAllUserTypes();
                TypeUser.DataBind();
                Groups.DataValueField = "NameGroup";
                Groups.DataSource = IceApplication.getInstance().SessionPrx.getGroupManager().getAllGroups();
                Groups.DataBind();
            }
           
        }
       
        protected void CreateUser_Click(object sender, EventArgs e)
        {
            var manager = Context.GetOwinContext().GetUserManager<ApplicationUserManager>();
            var signInManager = Context.GetOwinContext().Get<ApplicationSignInManager>();

            
            User user = new User(Login.Text, Password.Text, Fam.Text, Name.Text, Otch.Text, 
                IceApplication.getInstance().SessionPrx.getUserManager().getUserType(TypeUser.SelectedValue),
                IceApplication.getInstance().SessionPrx.getGroupManager().getGroupbyName(Groups.SelectedValue));
            try {
                IceApplication.getInstance().EntryPrx.Register(user);
            } catch (UserAlreadyExists uae)
            {
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('User already exists!');", true);
            }

            LoginHyperLink.NavigateUrl = "Login";
            var returnUrl = HttpUtility.UrlEncode(Request.QueryString["ReturnUrl"]);
            if (!String.IsNullOrEmpty(returnUrl))
            {
                LoginHyperLink.NavigateUrl += "?ReturnUrl=" + returnUrl;
            }

          


            //  var user = new ApplicationUser() { UserName = Email.Text, Email = Email.Text };

            ////  IdentityResult result = manager.Create(user, Password.Text);
            //   if (result.Succeeded)
            //   {


            //       // Дополнительные сведения о том, как включить подтверждение учетной записи и сброс пароля, см. по адресу: http://go.microsoft.com/fwlink/?LinkID=320771
            //       //string code = manager.GenerateEmailConfirmationToken(user.Id);
            //       //string callbackUrl = IdentityHelper.GetUserConfirmationRedirectUrl(code, user.Id, Request);
            //       //manager.SendEmail(user.Id, "Подтверждение учетной записи", "Подтвердите вашу учетную запись, щелкнув <a href=\"" + callbackUrl + "\">здесь</a>.");

            //       signInManager.SignIn( user, isPersistent: false, rememberBrowser: false);
            //       IdentityHelper.RedirectToReturnUrl(Request.QueryString["ReturnUrl"], Response);
            //   }
            //   else 
            //   {
            //       ErrorMessage.Text = result.Errors.FirstOrDefault();
            //   }
        }
    }
}