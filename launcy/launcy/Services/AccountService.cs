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
        private static List<Account> _courses;

        private AccountService()
        {
            _courses = new List<Account>();
            _courses.Add(new Account("toto", "tata"));
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
            foreach (Account account in _courses)
            {
                if (account.Username == username && account.Password == password)
                {
                    return account;
                }
            }

            throw new Exception("Account not found");
        }
    }
}
