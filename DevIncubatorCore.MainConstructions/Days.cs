using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.MainConstructions
{
    enum DayOfWeek
    {
        Monday = 1,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday
    }
    class Days : ITask
    {
        public void RunTask()
        {
            bool isWork = true;
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
    }
}
