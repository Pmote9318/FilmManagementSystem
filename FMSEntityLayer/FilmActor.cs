using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class FilmActor
    {
        public int FilmId { get; set; }
        public int ActorId { get; set; }

        public override string ToString()
        {
            {
                return FilmId + "\t" + ActorId;
            }
        }
    }
}
