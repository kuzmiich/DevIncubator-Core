using System;
using System.Linq;

namespace DevIncubatorCore.Linq
{
    internal class RepetitionOfNumbers : ITask
    {
        public void RunTask()
        {
            const string str = "aabbbcccccdd";

            var groupingEnumerable = str.GroupBy(x => x);
            foreach (var group in groupingEnumerable)
            {
                Console.WriteLine($"{group.Key} {group.Count()}");
            }
        }
    }
}