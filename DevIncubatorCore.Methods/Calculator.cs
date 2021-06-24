using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Methods
{
    class Calculator : ITask
    {
        private const int SignCount = 2;
        private static double Subtraction(int first, int second)
        {
            return first - second;
        }
        private static double Subtraction(double first, double second)
        {
            return first - second;
        }

        private static double Addition(int first, int second)
        {
            return first + second;
        }
        private static double Addition(double first, double second)
        {
            return first + second;
        }

        private static double Multiplication(int first, int second)
        {
            return first * second;
        }
        private static double Multiplication(double first, double second)
        {
            return first * second;
        }

        private static double Division(int first, int second)
        {
            if (second == 0)
            {
                Console.WriteLine("The second value cannot be zero");
                return 0;
            }
            return first / second;
        }
        private static double Division(double first, double second)
        {
            if (second == 0)
            {
                Console.WriteLine("The second value cannot be zero");
                return 0;
            }
            return first / second;
        }
        public void RunTask()
        {
            var a = 10;
            var b = 4;
            
            Console.WriteLine($"Addition - {Math.Round(Addition(a, b), SignCount)}");
            Console.WriteLine($"Subtraction - {Math.Round(Subtraction(a, b), SignCount)}");
            Console.WriteLine($"Multiplication - {Math.Round(Multiplication(a, b), SignCount)}");
            Console.WriteLine($"Division - {Math.Round(Division(a, b), SignCount)}");

            var sumOperations = Math.Round(Addition(a, b) + Subtraction(a, b) + Multiplication(a, b) + Division(a, b), SignCount);
            Console.WriteLine($"Sum operations - {sumOperations}");
        }
    }
}
