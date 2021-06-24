using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Methods
{
    class TwoDimensionalArray : ITask
    {
        private int Sum(int[,] arr, int n, int m)
        {
            int sum = 0;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    sum += arr[i, j];
                }
            }

            return sum;
        }
        private int[,] GetArrayElementDifference(int[,] arr, int n, int m)
        {
            int lines = 0;
            for (int i = n; i > 0; i--)
            {
                int columns = 0;
                for (int j = m; j > 0; j--)
                {
                    arr[lines, columns] = i - j;
                    columns++;
                }
                lines++;
            }

            return arr;
        }
        private void PrettyShowArray(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Console.Write($"{arr[i, j],3}");
                }
                Console.WriteLine();
            }
        }
        public void RunTask()
        {
            Console.WriteLine("Input n: ");
            var n = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine("Input m: ");
            var m = Extractor.GetInt32(Console.ReadLine());

            if (n < 0 || m < 0)
            {
                Console.WriteLine("Error, number n and m is natural");
            }

            var arr = new int[n, m];

            var arrWithDifferenceElements = GetArrayElementDifference(arr, n, m);

            PrettyShowArray(arrWithDifferenceElements, n, m);
            
            Console.WriteLine($"Length - {arr.Length}");
            Console.WriteLine($"Size {n} by {m}");
            Console.WriteLine($"Sum elements = {Sum(arr, n, m)}");
        }
    }
}
