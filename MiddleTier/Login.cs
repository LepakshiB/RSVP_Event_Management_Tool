using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
using MiddleTier.Utility;

namespace MiddleTier
{
    public class Login
    {
            public int LoginCheck(string Username, string password)
            {
                try
                {
                    string query = "select * from user_master where login_name=@username and login_password=@password";
                    IDataParameter[] parms = new IDataParameter[]
                                                            { new SqlParameter("@username",Username),
                                                              new SqlParameter("@password",password)
                                                             };
                    DataTable datatable = DBHelper.EXcuteReadar(query, parms);
                    return datatable.Rows.Count;
                }
                catch (Exception ex)
                {
                    throw ex;
                }
            }

             public DataSet GetUser()
             {

                 string query = "select top 10  first_name,last_name, login_name  from user_master";
                DataSet datatable=DBHelper.GetUser(query);
                return datatable;
            }
             public int Insert_user(string first_name, string last_name, string Username, string password)
             {

                 string query = "insert into user_master values(@first_name,@last_name,@username,@password,@active)";
                 IDataParameter[] parms = new IDataParameter[]
                                                            { new SqlParameter("@first_name",first_name),
                                                              new SqlParameter("@last_name",last_name),
                                                               new SqlParameter("@username",Username),
                                                              new SqlParameter("@password",password),
                                                              new SqlParameter("@active",1)
                                                             };
                 int count= DBHelper.ExecuteNonQuery(query , parms);
                 return count;
             }
  }
}
