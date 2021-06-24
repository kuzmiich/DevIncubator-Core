using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.HelloWorld
{
    class C : ITask
    {
        public void RunTask()
        {
            Console.WriteLine($"Min byte - {byte.MinValue}. Max byte - {byte.MaxValue}.");

            Console.WriteLine($"Min sbyte - {sbyte.MinValue}. Max sbyte - {sbyte.MaxValue}.");

            Console.WriteLine($"Min int - {int.MinValue}. Max int - {int.MaxValue}.");

            Console.WriteLine($"Min float - {float.MinValue}. Max float - {float.MaxValue}.");
        }
    }
}
