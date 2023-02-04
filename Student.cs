using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

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
              

        public double StudentAverage()
        {
            return (CsiGrade + GenEdGrade) / 2;
        }

        public override string ToString()
        {
            return $"{this.firstName} {this.lastName} - CSI Grade: {this.csiGrade} - GenED Grade: {this.genEdGrade} - Average {StudentAverage()}";
        }//To string;

        // What is method?
        // A block of code that is given a name, and run when it is called;

        //What is the purpose of the methed?
        //Easy to code, Easy to read, Easy to refaction, Easy to reuse;

        //What a 4 parts to declear a method?
        //Access modifier, return type, Name and Paremeters;

        // What is a class method?
        //Fields and methods inside classes are often referred to as "Class Members"

        //Review: What’s the name for any field, constructor, property or method that is part of a class?
        //They are a member of a class.

        //What keyword allows you to access members related to the specific instance? "public" keyword allows you to access member related to the specific instance.

        //A method build inside a class has access to what, even it’s access modifier is set to private? class;

        //What does “override .ToString()” allow us to do?
       // Overriding ToString() allows you to give a useful human-readable string representation of a class. 
    }
}
