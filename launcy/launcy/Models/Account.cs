using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcy.Core.Models
{
    public class Account
    {
        public string Username;
        public string Password;

        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
    }
}
