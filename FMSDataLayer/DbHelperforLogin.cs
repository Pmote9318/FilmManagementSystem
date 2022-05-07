using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using FMSEntityLayer;


namespace FMSDataLayer
{
    internal class DbHelperforLogin
    {
        static SqlConnection conn = null;
        static DbHelperforLogin()
        {
            conn = new SqlConnection(@"data source=LAPTOP-H84KGV90; database=FMS;Integrated Security=true");
        }

        public static int ExecuteDMLCommand(string commandText, SqlParameter[] sqlparameter1)
        {
            int recordsAffected = 0;
            try
            {
                SqlCommand insertlogin = new SqlCommand();
                insertlogin.CommandText = commandText;
                insertlogin.Connection = conn;
                if (sqlparameter1 != null)
                    insertlogin.Parameters.AddRange(sqlparameter1);
                conn.Open();
                recordsAffected = insertlogin.ExecuteNonQuery();
                insertlogin.Parameters.Clear(); 
                conn.Close();

            }
            catch (SqlException)
            {
                if (conn != null && conn.State == ConnectionState.Open)
                    conn.Close();
            }
            return recordsAffected;
        }
        public static List<object> ExecuteReader(string commandText)
        {

            List<object> objectList = new List<object>();
            SqlCommand getLogin = new SqlCommand();
            getLogin.CommandText = "select * from LoginCredentials";
            getLogin.Connection = conn;
            conn.Open();
            SqlDataReader sdr = getLogin.ExecuteReader();

            while (sdr.Read())
            {
                LoginCredentials L = new LoginCredentials();

                L.TypeOfUser = sdr.GetString(0);
                L.Username = sdr.GetString(1);
                L.PasswordForLogin = sdr.GetString(2);
                

                objectList.Add(L);
            }
            conn.Close();
            return objectList;
        }
    }
}
