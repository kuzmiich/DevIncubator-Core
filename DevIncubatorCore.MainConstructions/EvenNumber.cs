using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.MainConstructions
{
    class EvenNumber : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input start range number: ");
            var n = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine("Input end range number: ");
            var m = Extractor.GetInt32(Console.ReadLine());

            if (n > m)
            {
                (n, m) = (m, n); // swap
            }

            for (int i = n; i <= m; i += 2)
            {
                if (i % 2 != 0)
                {
                    i++;
                }
                Console.Write($"{i} ");
            }
            Console.WriteLine();
        }
    }
}
