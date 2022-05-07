using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class Actor
    {

        public int ActorId { get; set; }

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public override string ToString()
        {

            {
                return ActorId + "\t" + FirstName + "\t" + LastName;
            }
        }
    }
}
