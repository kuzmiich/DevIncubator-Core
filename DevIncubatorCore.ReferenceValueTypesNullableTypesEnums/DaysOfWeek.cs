using System;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    internal class DaysOfWeek : ITask
    {
        public void RunTask()
        {
            Console.Write("Input number day of week(1..7): ");
            var dayNumber = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine($"It`s - {(DayOfWeek) dayNumber}");
        }

        private enum DayOfWeek
        {
            Monday = 1,
            Tuesday,
            Wednesday,
            Thursday,
            Friday,
            Saturday,
            Sunday
        }
    }
}