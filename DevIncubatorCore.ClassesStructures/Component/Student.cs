using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.ClassesStructures.Component
{
    class Student
    {
        private const int SchoolNumber = 201;

        static Student()
        {
            Console.WriteLine($"School number - {GetSchoolNumber()}");
        }

        public Student()
        {
            
        }
        public Student(string name, string lastName, double gradeAverage)
        {
            Console.WriteLine("Dynamic constructor with parameters has started");
            Name = name;
            LastName = lastName;
            GradeAverage = gradeAverage;
            Count++;
            Console.WriteLine($"Students number = {Count}");
        }
        public static int Count { get; private set; }
        public string Name { get; }
        public string LastName { get; }
        public double GradeAverage { get; }

        public static int GetSchoolNumber()
        {
            return SchoolNumber;
        }

        public override string ToString()
        {
            return $"Name - {Name}, Last name - {LastName}, Grade average - {GradeAverage}";
        }
    }
}
