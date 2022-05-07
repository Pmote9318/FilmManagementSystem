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
    public class DbHelper
    {
        static SqlConnection conn = null;
        static DbHelper()
        {
            conn = new SqlConnection(@"data source=LAPTOP-H84KGV90; database=FMS;Integrated Security=true");
        }

        public static int ExecuteDMLCommand(string commandText, SqlParameter[] sqlparameter)
        {
            int recordsAffected = 0;
            try
            {
                SqlCommand insertfilm = new SqlCommand();
                insertfilm.CommandText = commandText;
                insertfilm.Connection = conn;
                if (sqlparameter != null)
                    insertfilm.Parameters.AddRange(sqlparameter);
                conn.Open();
                recordsAffected = insertfilm.ExecuteNonQuery();
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
            SqlCommand getFilms = new SqlCommand();
            getFilms.CommandText = "select * from Film";
            getFilms.Connection = conn;
            conn.Open();
            SqlDataReader sdr = getFilms.ExecuteReader();

            while (sdr.Read())
            {
                Film f = new Film();

                f.FilmId = sdr.GetInt32(0);
                f.FilmDescription = sdr.GetString(1);
                f.Title = sdr.GetString(2);
                f.ReleaseYear = sdr.GetDateTime(3);
                f.OriginalLangId = sdr.GetInt32(4);
                f.RentalDuration = sdr.GetDateTime(5);
                f.FilmLength = sdr.GetInt32(6);
                f.ReplacementCost = sdr.GetInt32(7);
                f.Rating = sdr.GetInt32(8);
                f.SpecialFeatures = sdr.GetString(9);
                f.ActorId = sdr.GetInt32(10);
                f.CategoryId = sdr.GetInt32(11);

                objectList.Add(f);
            }
            conn.Close();
            return objectList;
        }
        
    }
}
