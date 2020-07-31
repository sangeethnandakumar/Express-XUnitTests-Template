using System;
using System.Collections.Generic;
using System.Text;

namespace ClassLibrary
{
    public class Credential
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public Credential(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
