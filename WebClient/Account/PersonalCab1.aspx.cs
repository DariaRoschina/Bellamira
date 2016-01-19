using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Bellamira;
namespace WebClient.Account
{
    public static class PersonalData
    {
        public static string youname = " ";
        public static string youtype = " ";
        public static string yougroup = " ";
        public static string YourName
        {
            get {return youname;}
            set{ youname = value;}
        }
        public static string YourType
        {
            get { return youtype; }
            set { youtype = value; }
        }
        public static string YourGroup
        {
            get { return yougroup; }
            set { yougroup = value; }
        }
    }
    public partial class PersonalCab : System.Web.UI.Page
    {
       protected void Page_Load(object sender, EventArgs e)
        {
            PersonalData.YourName = Login.youname;
            PersonalData.YourType = Login.youtype;
            PersonalData.YourGroup = Login.yougroup;
        }
    }
}