using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FMSEntityLayer
{
    [Serializable]
    public class LoginCredentials
    {
        public string TypeOfUser { get; set; }
        public string Username { get; set; }
        public string PasswordForLogin { get; set; }

        public override string ToString()
        {
            return TypeOfUser + "\t" + Username + "\t" + PasswordForLogin;
        }


    }
}
