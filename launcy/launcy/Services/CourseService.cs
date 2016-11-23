using launcy.Core.Models;
using System.Collections.Generic;

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

        public Course GetCourseByGuid(string guid)
        {
            foreach (Course course in _courses)
            {
                if (course.Id.Equals(guid))
                {
                    return course;
                }
            }

            throw new KeyNotFoundException("The course wasn't found.");
        }
    }
}
