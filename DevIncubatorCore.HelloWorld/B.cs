using System;

namespace DevIncubatorCore.HelloWorld
{
    internal class B : ITask
    {
        public void RunTask()
        {
            Console.Write("Input double value: ");
            var d = Extractor.GetDouble(Console.ReadLine());

            Console.Write("Input byte value: ");
            var b = Extractor.GetByte(Console.ReadLine());

            Console.Write("Input char value: ");
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