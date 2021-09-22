using System;

namespace DevIncubatorCore.ClassesStructures.Component
{
    internal class Student
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