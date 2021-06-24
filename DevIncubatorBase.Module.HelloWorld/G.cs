using System;

namespace DevIncubatorCore.Module.HelloWorld
{
    class G : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input a (0..255): ");
            var a = Extractor.GetByte(Console.ReadLine());

            Console.WriteLine("Input b (0..255): ");
            var b = Extractor.GetByte(Console.ReadLine());

            var c = checked((byte)(a + b));

            Console.WriteLine($"result - {c}");
        }
    }
}
