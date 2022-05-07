using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class FilmDubbedLang
    {
        public int DubbedId { get; set; }
        public int FilmId { get; set; }

        public override string ToString()
        {

            {
                return DubbedId + "\t" + FilmId;
            }
        }
    }
}
