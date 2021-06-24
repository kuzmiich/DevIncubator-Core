using System;

namespace DevIncubatorCore.HelloWorld
{
    class A : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Input your name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Input your age: ");
            var userMessage = Console.ReadLine();

            var age = Extractor.GetInt32(userMessage);

            Console.WriteLine($"My name is {name}. My age is {age}");
        }
    }
}
