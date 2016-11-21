using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using launcy.Core.ViewModels;

namespace launcy.Droid.Views
{
    [Activity(Label = "View for LoginViewModel")]
    public class LoginView : MvxActivity
    {
        public new LoginViewModel ViewModel
        {
            get { return (LoginViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.LoginView);
        }
    }
}
