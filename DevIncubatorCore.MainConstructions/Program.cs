﻿using System;

namespace DevIncubatorCore.MainConstructions
{
    class Program
    {
        static void Main(string[] args)
        {
            ITask[] tasks =
            {
                new MultiplicationTable(), // +
                new Days(), // +
                new EvenNumber(), // +
                new ComparisonDigit(),  // +
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