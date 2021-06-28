using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore;

namespace PrimeNumbers
{
    class PrimeNumbersExecuter : ITask
    {
        private static bool IsPrime(int number)
        {
            if (number == 1) return false;
            if (number == 2) return true;

            var limit = Math.Ceiling(Math.Sqrt(number));
            for (int i = 2; i <= limit; i++)
            {
                if (number % i == 0)
                    return false;
            }
                
            return true;
        }
        public static IEnumerable<int> GetPrimeNumbers(int count)
        {
            var list = new List<int>();
            if (count < 0)
            {
                return list;
            }
            var i = 0;
            var number = 1;
            while (i < count)
            {
                while (true)
                {
                    number++; // start with number == 2
                    if (IsPrime(number))
                    {
                        list.Add(number);
                        i++;
                        break;
                    }

                }

            }

            return list;
        }

        public void RunTask()
        {
            Console.Write("Input number of prime number sequence: ");
            var number = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine(string.Join(' ', GetPrimeNumbers(number)));
        }
    }
}
