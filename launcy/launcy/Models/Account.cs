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
        private string _id;

        public string Id
        {
            get { return _id; }
            private set { _id = value; }
        }


        public Account(string username, string password)
        {
            Id = Guid.NewGuid().ToString();
            Username = username;
            Password = password;
        }
    }
}
