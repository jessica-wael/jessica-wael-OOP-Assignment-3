using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsDemo
{
    public class Student
    {

        public int Id { get; }
        public string Name { get; }
        public Student(int id, string name)
        {
            if (id <=0)
                throw new ArgumentException("Student id can't be negative or zero!");

            if (string.IsNullOrEmpty(name))
                throw new ArgumentException("Student name can't be empty!");

            Id = id;
            Name = name;
        }

    }
}
