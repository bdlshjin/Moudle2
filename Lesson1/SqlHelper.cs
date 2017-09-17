using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.SqlClient;
using System.Configuration;

namespace Lesson1
{
    static public class SqlHelper
    {
        public static object ExecuteScalar(string name,string password)
        {                           
            //string connstr = ConfigurationManager.ConnectionStrings["conntodb"].ConnectionString;
            using (SqlConnection con = new SqlConnection("data source=(local);database=itcast;uid=sa;pwd=123456"))
            //using(SqlConnection con = new SqlConnection(connstr)) 
            {
                using (SqlCommand cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = string.Format("select count(*) from users where username='{0}' and password='{1}'", name, password);
                    con.Open();
                    return cmd.ExecuteScalar();
                }
            }            
        }
    }
}