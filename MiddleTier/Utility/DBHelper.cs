using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;

namespace MiddleTier.Utility
{
    public class DBHelper
    {
        /// <summary>
        /// Opening the sql Connection 
        /// Getting the Connection String from the web .Config File
        /// </summary>
        /// <returns></returns>
        public static SqlConnection connection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["ABC"].ConnectionString;
            SqlConnection con = new SqlConnection(connectionString);
            con.Open();
            return con;
        }

        /// <summary>
        /// This Function is used to do DML operation on SQL serverr
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string query, IDataParameter[] parms)
        {
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(parms);
            cmd.CommandType = CommandType.Text;
            cmd.ExecuteNonQuery();
            return 1;
        }
        /// <summary>
        /// This function is used to do read operation on SQl
        /// </summary>
        /// <param name="query"></param>
        /// <param name="parms"></param>
        /// <returns></returns>
        public static DataTable EXcuteReadar(string query, IDataParameter[] parms)
        {
            DataTable dataset = new DataTable();
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddRange(parms);
            cmd.CommandType = CommandType.Text;
            SqlDataReader dr = cmd.ExecuteReader();
            dataset.Load(dr);
            return dataset;
        }
        /// <summary>
        /// Used to get the user
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public static DataSet GetUser(string query)
        {
            DataSet dataset = new DataSet();
            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.CommandType = CommandType.Text;
            var dr = cmd.ExecuteReader();
            dataset.Load(dr, LoadOption.OverwriteChanges, "User");
            return dataset;
        }

        public static int ExecuteScalar(string query, IDataParameter[] parms)
        {

            SqlConnection con = connection();
            SqlCommand cmd = new SqlCommand(query, con);

            cmd.CommandType = CommandType.StoredProcedure;
            var count = (int)cmd.ExecuteScalar();
            return count;
        }
    }
}
