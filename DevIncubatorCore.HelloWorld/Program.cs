using System;

namespace DevIncubatorCore.HelloWorld
{
    internal class Program
    {
        internal static void Main(string[] args)
        {
            ITask[] tasks =
            {
                new A(),
                new B(),
                new C(),
                new D(),
                new E(),
                new F(),
                new G(),
                new H(),
                new I()
            };
            try
            {
                foreach (var task in tasks)
                {
                    task.RunTask();
                    Console.WriteLine(string.Empty.PadLeft(70, '-'));
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Overflow Exception");
            }
            catch (FormatException)
            {
                Console.WriteLine("Format Exception");
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