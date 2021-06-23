using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Module.HelloWorld
{
    class F : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input a (0..255): ");
            var a = Extractor.GetByte(Console.ReadLine());

            Console.WriteLine("Input b (0..255): ");
            var b = Extractor.GetByte(Console.ReadLine());

            var c = (byte)(a + b);

            Console.WriteLine($"result - {c}");
        }
    }
}
