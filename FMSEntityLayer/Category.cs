using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class Category
    {
        public int CategoryId { get; set; }

        public string Name { get; set; }

        public int FilmId { get; set; }

        public override string ToString()
        {
            {
                return CategoryId + "\t" + Name + "\t" + FilmId;
            }
        }
    }
}
