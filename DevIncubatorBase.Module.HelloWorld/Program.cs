using System;

namespace DevIncubatorBase.Module.HelloWorld
{
    class Program
    {
        internal static void Main(string[] args)
        {
            ITask[] tasks =
            {
                new A(),
                new B(),
                new C()
            };
            try
            {
                foreach (var task in tasks)
                {
                    task.RunTask();
                }
            }
            catch (ArgumentException)
            {
                Console.WriteLine("Argument Exception");
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
