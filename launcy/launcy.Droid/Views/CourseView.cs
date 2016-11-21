using Android.App;
using Android.OS;
using MvvmCross.Droid.Views;
using launcy.Core.ViewModels;

namespace launcy.Droid.Views
{
    [Activity(Label = "View for CourseViewModel")]
    public class CourseView : MvxActivity
    {
        public new CourseViewModel ViewModel
        {
            get { return (CourseViewModel)base.ViewModel; }
            set { base.ViewModel = value; }
        }

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.CourseView);
        }
    }
}
