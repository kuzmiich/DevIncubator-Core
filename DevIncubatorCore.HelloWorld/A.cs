using System;

namespace DevIncubatorCore.HelloWorld
{
    internal class A : ITask
    {
        public void RunTask()
        {
            Console.Write("Input your name: ");
            var name = Console.ReadLine();

            Console.Write("Input your age: ");

            var age = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine($"My name is {name}. My age is {age}");
        }
    }
}