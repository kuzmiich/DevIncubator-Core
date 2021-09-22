using System;

namespace DevIncubatorCore.Methods
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITask[] tasks =
            {
                new Olympic(), // +
                new Calculator(), // +
                new EFood(), // +
                new SwapVariable(), // +
                new FullName(), // +
                new TypeOfElement()
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