using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class Film
    {
        public int FilmId { get; set; }
        public string Title { get; set; }
        public string FilmDescription { get; set; }
        public DateTime ReleaseYear { get; set; }
        public int OriginalLangId { get; set; }
        public DateTime RentalDuration { get; set; }
        public int FilmLength { get; set; }
        public int ReplacementCost { get; set; }
        public int Rating { get; set; }
        public string SpecialFeatures { get; set; }
        public int ActorId { get; set; }
        public int CategoryId { get; set; }

        public override string ToString()
        {
            return FilmId + "\t" + Title + "\t" + FilmDescription + "\t" + ReleaseYear + "\t" + OriginalLangId + "\t" + RentalDuration + "\t" + FilmLength + "\t" + ReplacementCost + "\t" + Rating + "\t" + SpecialFeatures + "\t" + ActorId + "\t" + CategoryId;
        }

    }
}
