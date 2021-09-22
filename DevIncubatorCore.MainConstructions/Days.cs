using System;

namespace DevIncubatorCore.MainConstructions
{
    internal class Days : ITask
    {
        public void RunTask()
        {
            var isWork = true;
            while (isWork)
            {
                Console.WriteLine("Input number day of week: ");
                var number = Extractor.GetInt32(Console.ReadLine());

                var dayOfWeek = string.Empty;
                switch ((DayOfWeek) number)
                {
                    case DayOfWeek.Monday:
                        dayOfWeek = "Monday";
                        break;
                    case DayOfWeek.Tuesday:
                        dayOfWeek = "Tuesday";
                        break;
                    case DayOfWeek.Wednesday:
                        dayOfWeek = "Wednesday";
                        break;
                    case DayOfWeek.Thursday:
                        dayOfWeek = "Thursday";
                        break;
                    case DayOfWeek.Friday:
                        dayOfWeek = "Friday";
                        break;
                    case DayOfWeek.Saturday:
                        dayOfWeek = "Saturday";
                        break;
                    case DayOfWeek.Sunday:
                        dayOfWeek = "Sunday";
                        break;
                    default:
                        isWork = false;
                        break;
                }

                Console.WriteLine(dayOfWeek);
            }
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