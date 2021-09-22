using System;

namespace DevIncubatorCore.HelloWorld
{
    internal class E : ITask
    {
        public void RunTask()
        {
            object first = 1;
            object second = 1;
            var third = first;

            Console.WriteLine($"First variable equal second variable - {Equals(first, second)}");

            Console.WriteLine($"First variable reference equal second variable - {ReferenceEquals(first, third)}");
        }
    }
}