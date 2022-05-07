using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class FilmLanguage
    {
        public int LanguageId { get; set; }
        public string LanguageName { get; set; }

        public override string ToString()
        {
            {
                return LanguageId + "\t" + LanguageName;
            }
        }
    }
}
