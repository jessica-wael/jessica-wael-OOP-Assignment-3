using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class StudentStore
    {
        private readonly List<Student> _student = new();

        public void Add(Student student)
        {
            _student.Add(student);

        }

        public Student? GetById(int id)
        {
            foreach (var s in _student)
            {
                if (s.Id == id)
                    return s; 
            }
            return null;
        }
        public List<Student> GetAll()
        {
            return _student;
        }
        public bool Remove(int id)
        {
            var student = GetById(id);
            if(student == null)
            {
                return false;
            }
                
            return _student.Remove(student);  
        }
    }
}
