using launcy.Core.Models;
using launcy.Core.Services;
using MvvmCross.Core.ViewModels;
using System;

namespace launcy.Core.ViewModels
{
    public class LoginViewModel 
        : MvxViewModel
    {
        private string _username = "toto";
        private string _password = "tata";

        public string Password
        {
            get { return _password; }
            set {
                _password = value;
                RaisePropertyChanged();
            }
        }

        public string Username
        {
            get { return _username; }
            set {
                _username = value;
                RaisePropertyChanged();
            }
        }

        public MvxCommand LoginButtonCommand
        {
            get { return new MvxCommand(TryToLogin); }
        }

        public void TryToLogin()
        {
            try
            {
                Account account = AccountService.GetInstance().Verify(Username, Password);

                ShowViewModel<CoursesViewModel>();
            } catch (Exception e)
            {

            }
        }

    }
}
