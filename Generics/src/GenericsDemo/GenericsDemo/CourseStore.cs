using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class CourseStore
    {

        private readonly List<Course> _course = new();

        public void Add(Course course)
        {
            _course.Add(course);

        }

        public Course? GetById(int id)
        {
            foreach (var c in _course)
            {
                if (c.Id == id)
                    return c;
            }
            return null;
        }
        public List<Course> GetAll()
        {
            return _course;
        }
        public bool Remove(int id)
        {
            var course = GetById(id);
            if (course == null)
            {
                return false;
            }

            return _course.Remove(course);
        }
    }
}

