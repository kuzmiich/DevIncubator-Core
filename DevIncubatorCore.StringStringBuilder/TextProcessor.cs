using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.StringStringBuilder
{
    class TextProcessor : ITask
    {
        public static void A()
        {
            Console.WriteLine("Input source string: ");
            var hashSetString = Console.ReadLine()?.Split().ToHashSet();
            foreach (var str in hashSetString)
            {
                Console.Write($"{str} ");
            }
            Console.WriteLine();
        }
        public void RunTask()
        {
            A();
        }
    }
}
