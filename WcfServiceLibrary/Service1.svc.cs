using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using MiddleTier;
using System.Data;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    public class Service1 : IService1
    {
        public int  LoginCheck(string  UserName , string Password)
        {
            Login logincheck = new Login();
            
            return logincheck.LoginCheck(UserName, Password);
        }

        public DataSet GetUser()
        { 
            Login getuser=new Login();
            return getuser.GetUser();
       
        }

        public int AddUser(string First_name,string Last_name, string UserName, string Password)
        {
            Login Adduser = new Login();

            return Adduser.Insert_user(First_name, Last_name,UserName, Password);
        }
  }
}
