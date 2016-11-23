using launcy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcy.Core.Services
{
    public class AccountService
    {
        private static AccountService _instance;
        private static List<Account> _accounts;

        private AccountService()
        {
            _accounts = new List<Account>();
            _accounts.Add(new Account("toto", "tata"));
        }

        public static AccountService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new AccountService();
            }

            return _instance;
        }

        public Account Verify(string username, string password)
        {
            foreach (Account account in _accounts)
            {
                if (account.Username == username && account.Password == password)
                {
                    return account;
                }
            }

            throw new KeyNotFoundException("The accoun wasn't found.");
        }
    }
}
