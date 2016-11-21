using launcy.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace launcy.Core.Services
{
    public class CourseService
    {
        private static CourseService _instance;
        private static List<Course> _courses;

        private CourseService()
        {
            _courses = new List<Course>();
            _courses.Add(new Course("Course 1"));
            _courses.Add(new Course("Course 2"));
            _courses.Add(new Course("Course 3", Course.StateEnum.FAIT));
        }

        public static CourseService GetInstance()
        {
            if (_instance == null)
            {
                _instance = new CourseService();
            }

            return _instance;
        }

        public List<Course> GetCoursesByState(Course.StateEnum state)
        {
            List<Course> courses = new List<Course>();
            foreach (Course course in _courses)
            {
                if (course.State == state)
                {
                    courses.Add(course);
                }
            }

            return courses;
        }
    }
}
