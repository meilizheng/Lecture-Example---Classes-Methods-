using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes___Methods__
{
    internal class Course
    {
        string _courseName;
        string _teacher;
        List<Student> classRoster = new List<Student>();

        public Course(string courseName, string teacher)
        {
            CourseName = courseName;
            Teacher = teacher;
        }

        public string CourseName { get => _courseName; set => _courseName = value; }
        public string Teacher { get => _teacher; set => _teacher = value; }
        internal List<Student> ClassRoster { get => classRoster; }

        public void EnrollStudent(Student student)
        {
            classRoster.Add(student);
        }
    }   
}
