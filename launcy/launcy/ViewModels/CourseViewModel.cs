using launcy.Core.Models;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
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

        public CourseViewModel(Course course)
        {
            _course = course;
            Name = course.Name;
            State = course.State;
        }

        public MvxCommand CourseDoneButtonCommand
        {
            get { return new MvxCommand(SetCourseDone); }
        }

        public void SetCourseDone()
        {
            State = Course.StateEnum.FAIT;
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
