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
    public partial class Registration : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Service1Client client = new Service1Client();
            string EncrypetedPassWord = FormsAuthentication.HashPasswordForStoringInConfigFile(Password.Text, "SHA1");
            int count = client.AddUser(First_name.Text, Last_name.Text, User_Email.Text, EncrypetedPassWord);
            if (count > 0)
            {
                Label1.Text = "Success";
            }
            else
            {
                Label1.Text = "UserName Wrong";
            }
        }
    }
}