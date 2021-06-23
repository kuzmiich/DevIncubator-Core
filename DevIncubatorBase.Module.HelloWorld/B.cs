using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Module.HelloWorld
{
    class B : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input double value: ");
            var d = Extractor.GetDouble(Console.ReadLine());

            Console.WriteLine("Input byte value: ");
            var b = Extractor.GetByte(Console.ReadLine());

            Console.WriteLine("Input char value: ");
            var c = Extractor.GetChar(Console.ReadLine());

            if (d == default || b == default || c == default)
            {
                Console.WriteLine("Runtime error");
                return;
            }
            Console.WriteLine($"{d} {b} {c}");
        }
    }
}
