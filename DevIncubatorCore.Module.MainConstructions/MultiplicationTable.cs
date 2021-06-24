using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Module.MainConstructions
{
    class MultiplicationTable : ITask
    {
        public void RunTask()
        {
            const int Count = 9;
            for (int i = 1; i <= Count; i++)
            {
                for (int j = 1; j <= Count; j++)
                {
                    var result = i * j;
                    Console.Write($"{result, 3}");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
