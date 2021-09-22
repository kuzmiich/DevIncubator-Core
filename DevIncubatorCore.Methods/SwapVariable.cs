using System;

namespace DevIncubatorCore.Methods
{
    internal class SwapVariable : ITask
    {
        public void RunTask()
        {
            Console.Write("Input first int value a: ");
            var a = Extractor.GetInt32(Console.ReadLine());
            Console.Write("Input second int value b: ");
            var b = Extractor.GetInt32(Console.ReadLine());

            Swap(ref a, ref b);

            Console.WriteLine($"a = {a}, b = {b}");
        }

        private static void Swap<T>(ref T first, ref T second)
        {
            var buf = first;
            first = second;
            second = buf;
        }
    }
}