using System;
using System.Diagnostics;
using System.Threading;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    class Cycles : ITask
    {
        public void RunTask()
        {
            const int count = 1_000_000_000;
            var stopWatch = new Stopwatch();

            stopWatch.Start();
            int j = 0;
            for (int i = 0; i < count; i++)
            {
                while(j < count)
                {
                    var obj = new object();
                    j++;
                }
            }
            stopWatch.Stop();

            TimeSpan elapsedTime = stopWatch.Elapsed;
            
            Console.WriteLine($"Iteration count - {j}, execution time seconds - {elapsedTime.Seconds}, execution time milliseconds - {elapsedTime.Milliseconds}");
        }
    }
}
