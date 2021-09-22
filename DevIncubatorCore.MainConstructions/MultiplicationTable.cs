using System;

namespace DevIncubatorCore.MainConstructions
{
    internal class MultiplicationTable : ITask
    {
        public void RunTask()
        {
            const int Count = 9;
            for (var i = 1; i <= Count; i++)
            {
                for (var j = 1; j <= Count; j++)
                {
                    var result = i * j;
                    Console.Write($"{result,3}");
                }

                Console.WriteLine("\n");
            }
        }
    }
}