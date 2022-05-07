using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSEntityLayer;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Data;
using System.Data.SqlClient;

namespace FMSDataLayer
{
    public class FilmDL
    {

        public bool CreateFilm(Film newFilm)
        {
            string commandText = "insert into film values(@filmid,@)";
            SqlParameter[] filmParams = new SqlParameter[12];
            filmParams[0] = new SqlParameter("@FilmId", newFilm.FilmId);
            filmParams[1] = new SqlParameter("@Title", newFilm.Title);
            filmParams[2] = new SqlParameter("@FilmDescription", newFilm.FilmDescription);
            filmParams[3] = new SqlParameter("@ReleaseYear", newFilm.ReleaseYear);
            filmParams[4] = new SqlParameter("@OriginalLangId", newFilm.OriginalLangId);
            filmParams[5] = new SqlParameter("@RentalDuration", newFilm.RentalDuration);
            filmParams[6] = new SqlParameter("@FilmLength", newFilm.FilmLength);
            filmParams[7] = new SqlParameter("@ReplacementCost", newFilm.ReplacementCost);
            filmParams[8] = new SqlParameter("@Rating", newFilm.Rating);
            filmParams[9] = new SqlParameter("@SpecialFeatures", newFilm.SpecialFeatures);
            filmParams[10] = new SqlParameter("@ActorId", newFilm.ActorId);
            filmParams[11] = new SqlParameter("@CategoryId", newFilm.CategoryId);
            DbHelper.ExecuteDMLCommand(commandText, filmParams);
            int recordsAffected = DbHelper.ExecuteDMLCommand(commandText, filmParams);
            if (recordsAffected > 0)
                return true;
            return false;

        }


        public List<Film> GetAllFilms()
        {
            List<object> objectList = DbHelper.ExecuteReader("select* from Film");
            List<Film> filmList = new List<Film>();
            foreach (var r in objectList)
            {
                filmList.Add((Film)r);
            }
            return filmList;
        }
    }
}
