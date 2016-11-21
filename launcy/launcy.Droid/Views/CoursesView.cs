using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using launcy.Core.ViewModels;

namespace launcy.Droid.Views
{
    [Activity(Label = "View for CoursesViewModel")]
    public class CoursesView : MvxActivity
    {
        public new CoursesViewModel ViewModel
        {
            get { return (CoursesViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CoursesView);
        }
    }
}
