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

            Response.Redirect("Login.aspx");
           
        }
    }
}