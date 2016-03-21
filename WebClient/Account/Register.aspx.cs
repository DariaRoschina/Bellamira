using System;
//using System.Linq;
using System.Web;
using System.Web.UI;
//using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
//using Owin;
//using WebClient.Models;
using Bellamira;
//using System.Collections.Generic;
//using System.Web.UI.WebControls;

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
           
            // TimeTableEntry t = new TimeTableEntry();
            // Group g = new Group();
            User user = new User(Login.Text, Password.Text, Fam.Text, Name.Text, Otch.Text, 
                IceApplication.getInstance().SessionPrx.getUserManager().getUserType(TypeUser.SelectedValue),
                IceApplication.getInstance().SessionPrx.getGroupManager().getGroupbyName(Groups.SelectedValue));
            bool tmp;
            try {
                IceApplication.getInstance().EntryPrx.Register(user);
                tmp = true;
            }
            catch (UserAlreadyExists uae)
            {
                tmp = false;
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "AlertBox", "alert('Пользователь уже существует!');", true);
            }
            if (tmp == true)
            {
                Response.Redirect("Login.aspx");
            }
           
        }
    }
}