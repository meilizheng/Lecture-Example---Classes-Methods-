using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_Example___Classes___Methods__
{
    internal class Student
    {
        string firstName;
        string lastName;
        double csiGrade;
        double genEdGrade;

        public Student(string firstName, string lastName, double csiGrade, double genEdGrade)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.csiGrade = csiGrade;
            this.genEdGrade = genEdGrade;
        }

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public double CsiGrade { get => csiGrade; set => csiGrade = value; }
        public double GenEdGrade { get => genEdGrade; set => genEdGrade = value; }
    }
}
