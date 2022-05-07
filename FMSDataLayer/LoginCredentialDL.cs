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
    public class LoginCredentialDL
    {
        public bool Login(LoginCredentials newLoginCredentials)
        {
            string commandText = "insert into LoginCredentials values(@typeofuser,@username,@passwordforlogin)";
            SqlParameter[] loginParams = new SqlParameter[3];
            loginParams[0] = new SqlParameter("@typeofuser", newLoginCredentials.TypeOfUser);
            loginParams[1] = new SqlParameter("@username", newLoginCredentials.Username);
            loginParams[2] = new SqlParameter("@passwordforlogin", newLoginCredentials.PasswordForLogin);
            
            DbHelper.ExecuteDMLCommand(commandText, loginParams);
            int recordsAffected = DbHelperforLogin.ExecuteDMLCommand(commandText, loginParams);
            if (recordsAffected > 0)
                return true;
            return false;

        }
        public bool SignUp(LoginCredentials newLoginCredentials)
        {
            string commandText = "insert into LoginCredentials values(@typeofuser,@username,@passwordforlogin)";
            SqlParameter[] signupParams = new SqlParameter[3];
            signupParams[0] = new SqlParameter("@typeofuser", newLoginCredentials.TypeOfUser);
            signupParams[1] = new SqlParameter("@username", newLoginCredentials.Username);
            signupParams[2] = new SqlParameter("@passwordforlogin", newLoginCredentials.PasswordForLogin);

            DbHelper.ExecuteDMLCommand(commandText, signupParams);
            int recordsAffected = DbHelperforLogin.ExecuteDMLCommand(commandText, signupParams);
            if (recordsAffected > 0)
                return true;
            return false;

        }
    }
}
