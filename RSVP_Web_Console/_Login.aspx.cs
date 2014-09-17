using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Hostel.ServiceReference1;
using System.Web.Security;


namespace Hostel
{
    public partial class _Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            string EncrypetedPassWord = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Text, "SHA1");
            int count = client.LoginCheck(Username.Text, EncrypetedPassWord);
           if (count > 0)
           {
               FormsAuthentication.RedirectFromLoginPage(Username.Text, false);
           }
           else
           {
               Label1.Text = "Invalid UserName And/Or Password";
           }

        }
    }
}