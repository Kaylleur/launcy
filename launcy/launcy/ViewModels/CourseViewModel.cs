using launcy.Core.Models;
using launcy.Core.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcy.Core.ViewModels
{
    public class CourseViewModel : MvxViewModel
    {
        private string _name;
        private Course _course;

        private Course.StateEnum _state;

        public Course.StateEnum State
        {
            get { return _state; }
            set {
                _state = value;
                _course.State = value;
                RaisePropertyChanged();
            }
        }

        public string Name
        {
            get { return _name; }
            set {
                _name = value;
                _course.Name = value;
                RaisePropertyChanged();
            }
        }

        protected override void InitFromBundle(IMvxBundle parameters)
        {
            base.InitFromBundle(parameters);
            try
            {
                _course = CourseService.GetInstance().GetCourseByGuid(parameters.Data["Id"]);
                Name = _course.Name;
                State = _course.State;
            }
            catch (KeyNotFoundException e)
            {
                Debug.WriteLine(e.ToString());
                ShowViewModel<CoursesViewModel>(); // TODO Handle the error please !
            }
        }

        public CourseViewModel()
        {
            
        }

        public MvxCommand CourseDoneButtonCommand
        {
            get { return new MvxCommand(SetCourseDone); }
        }

        public void SetCourseDone()
        {
            State = Course.StateEnum.FAIT;
            ReturnToCourses();
        }

        public MvxCommand ReturnButtonCommand
        {
            get { return new MvxCommand(ReturnToCourses); }
        }

        public void ReturnToCourses()
        {
            ShowViewModel<CoursesViewModel>();
        }
    }
}
