using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Data;

namespace WcfServiceLibrary
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {

        [OperationContract]
        int LoginCheck(string UserName, string Password);

        [OperationContract]
        DataSet GetUser();

        [OperationContract]
        int AddUser(string First_name, string Last_name, string UserName, string Password);
    }


}
