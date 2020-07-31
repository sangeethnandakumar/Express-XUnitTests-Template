using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class LoginService
    {
        public bool PerformLogin(Credential credential)
        {
            if (credential.Username.Equals("sangeeth") && credential.Password.Equals("sangee"))
            {
                return true;
            }
            if (credential.Username.Equals("navaneeth") && credential.Password.Equals("navu"))
            {
                return true;
            }
            if (credential.Username.Equals("surya") && credential.Password.Equals("surya"))
            {
                return true;
            }
            if (credential.Username.Equals("nandakumar") && credential.Password.Equals("nandu"))
            {
                return true;
            }
            return false;
        }
    }
}
