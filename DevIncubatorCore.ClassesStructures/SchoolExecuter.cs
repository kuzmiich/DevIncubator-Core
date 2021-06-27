using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore.ClassesStructures.Component;

namespace DevIncubatorCore.ClassesStructures
{
    class SchoolExecuter : ITask
    {
        private static readonly string[] _nameArray =
        {
            "Ivan", "Eugene", "Artyom", "Alina", "Darya", "Egor"
        };
        private static readonly string[] _lastNameArray =
        {
            "Ivanov", "Kostricov", "Sotnicov", "Bashko", "Kozlov", "Kramsaev", "Ananich"
        };

        private static Random _random = new();

        private static double AverageScore(IEnumerable<Student> students)
        {
            var count = 0.0;
            var sum = 0.0;
            foreach (var element in students)
            {
                sum += element.GradeAverage;
                count++;
            }
            return sum / count;
        }

        public void RunTask()
        {
            Console.Write("Input count of students: ");
            var count = Extractor.GetInt32(Console.ReadLine());

            var students = new Student[count];
            for (int i = 0; i < count; i++)
            {
                var name = _nameArray[_random.Next(_nameArray.Length)];
                var lastName = _lastNameArray[_random.Next(_lastNameArray.Length)];
                var gradeAverage = Math.Round(_random.NextDouble() * (10.0), 2);
                students[i] = new Student(name, lastName, gradeAverage);
            }

            var averageScore = Math.Round(AverageScore(students), 2);
            Console.WriteLine($"Average score - {averageScore}");

            Console.WriteLine("Bad students: ");
            foreach (var student in students)
            {
                if (student.GradeAverage < averageScore)
                {
                    Console.WriteLine(student);
                }
            }
        }
    }
}
