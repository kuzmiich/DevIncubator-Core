using System;

namespace DevIncubatorCore.HelloWorld
{
    class H : ITask
    {
        public void RunTask()
        {
            var a = long.MaxValue;
            var b = int.MaxValue;

            Console.WriteLine($"a = {a}, b = {b}");

            b = (int)a;

            Console.WriteLine($"a = {a}, b = {b}");
        }
    }
}
