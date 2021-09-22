using System;
using System.Linq;

namespace DevIncubatorCore.Linq
{
    internal class SecondLowestNumber : ITask
    {
        public void RunTask()
        {
            var arr = new[] {20, 15, 14, 30, 2, 6, 3};

            Console.WriteLine(arr.Where(val => val != arr.Min()).Min());
        }
    }
}