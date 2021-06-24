using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.ArraysForeach
{
    class TwoDimensionalArray : ITask
    {
        private static int Sum(int[,] arr)
        {
            int sum = 0;

            foreach (var element in arr)
            {
                sum += element;
            }

            return sum;
        }
        private static int[,] GetArrayElementDifference(int[,] arr, int n, int m)
        {
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    arr[i, j] = i - j;
                }
            }

            return arr;
        }
        private static void PrettyShowArray(int[,] arr, int n, int m)
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
            Console.Write("Input n: ");
            var n = Extractor.GetInt32(Console.ReadLine());

            Console.Write("Input m: ");
            var m = Extractor.GetInt32(Console.ReadLine());

            if (n < 0 || m < 0)
            {
                Console.WriteLine("Error, number n and m is natural");
            }

            var arr = new int[n, m];

            var arrWithDifferenceElements = GetArrayElementDifference(arr, n, m);

            PrettyShowArray(arrWithDifferenceElements, n, m);
            
            Console.WriteLine($"Length - {arr.Length}");
            Console.WriteLine($"Array dimension - {arr.Rank}");
            Console.WriteLine($"Sum elements = {Sum(arr)}");
        }
    }
}
