using System;
using DevIncubatorCore.Linq.LinqBegin;

namespace DevIncubatorCore.Linq
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            ITask[] tasks =
            {
                new SecondLowestNumber(),
                new RepetitionOfNumbers(),
                new LinqBegin1(),
                new LinqBegin12(),
                new LinqBegin13(),
                new LinqBegin14(),
                new LinqBegin15(),
                new LinqBegin16(),
                new LinqBegin17(),
                new LinqBegin18(),
                new LinqBegin19(),
                new LinqBegin20(),
                new LinqBegin21(),
                new LinqBegin23(),
                new LinqBegin24(),
                new LinqBegin25(),
                new LinqBegin30()
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