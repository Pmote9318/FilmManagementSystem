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
    public class LoginCredentialBL
    {
        public bool Login(LoginCredentials newLoginCredentials)
        {

            Validation(newLoginCredentials);
            LoginCredentialDL loginCredentialDL = new LoginCredentialDL();
            return loginCredentialDL.Login(newLoginCredentials);

        }
        public void Validation(LoginCredentials loginCredentials)
        {
            if (!Regex.IsMatch(loginCredentials.PasswordForLogin, "[A-Za-z][0-9]"))
            {
                throw new PasswordException("Invalid Password");
            }
        }
        public bool SignUp(LoginCredentials newLoginCredentials)
        {

            Validation1(newLoginCredentials);
            LoginCredentialDL loginCredentialDL = new LoginCredentialDL();
            return loginCredentialDL.SignUp(newLoginCredentials);

        }
        public void Validation1(LoginCredentials loginCredentials)
        {
            if (!Regex.IsMatch(loginCredentials.PasswordForLogin, "[A-Za-z][0-9]"))
            {
                throw new PasswordException("Invalid Password");
            }
            
        }

    }
}
