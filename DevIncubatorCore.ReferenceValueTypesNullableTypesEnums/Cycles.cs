using System;
using System.Diagnostics;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    internal class Cycles : ITask
    {
        public void RunTask()
        {
            const int count = 1_000_000_000;
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            var j = 0;
            for (var i = 0; i < count; i++)
                while (j < count)
                {
                    var obj = new object();
                    j++;
                }

            stopWatch.Stop();

            var elapsedTime = stopWatch.Elapsed;

            Console.WriteLine(
                $"Iteration count - {j}, execution time seconds - {elapsedTime.Seconds}, execution time milliseconds - {elapsedTime.Milliseconds}");
        }
    }
}