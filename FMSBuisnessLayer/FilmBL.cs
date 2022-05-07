using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FMSEntityLayer;
using FMSDataLayer;
using FMSExceptionLayer;
using System.Text.RegularExpressions;

namespace FMSBuisnessLayer
{
    public class FilmBL
    {
        public bool CreateFilm(Film newFilm)
        {

            Validation(newFilm);
            FilmDL filmDL = new FilmDL();
            return filmDL.CreateFilm(newFilm);

        }
        public void Validation(Film film)
        {
            if (!Regex.IsMatch(film.Title, "^[A-Z][0-9]{30}$"))
            {
                throw new TitleException("Invalid Title");
            }
        }
        public List<Film> GetAllFilms()
        {
            FilmDL filmDL = new FilmDL();
            return filmDL.GetAllFilms();
        }
    }
}
