using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    class DaysOfWeek : ITask
    {
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
        
        public void RunTask()
        {
            Console.Write("Input number day of week(1..7): ");
            var dayNumber = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine($"It`s - {(DayOfWeek)dayNumber}");
        }
    }
}
