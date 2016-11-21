using launcy.Core.Models;
using launcy.Core.Services;
using MvvmCross.Core.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcy.Core.ViewModels
{
    public class CoursesViewModel : MvxViewModel
    {
        private List<Course> _courses;

        public List<Course> Courses
        {
            get { return _courses; }
            set {
                _courses = value;
                RaisePropertyChanged();
            }
        }

        public CoursesViewModel()
        {
            Courses = CourseService.GetInstance().GetCoursesByState(Course.StateEnum.A_FAIRE);
        }

        public MvxCommand<Course> GoToCourseCommand
        {
            get { return new MvxCommand<Course>(GoToCourse); }
        }

        public void GoToCourse(Course currentCourse)
        {
            ShowViewModel<CourseViewModel>(new { course = currentCourse });
        }
    }
}
