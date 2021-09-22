using System;

namespace DevIncubatorCore.ArraysForeach
{
    internal class TwoDimensionalArray : ITask
    {
        public void RunTask()
        {
            Console.Write("Input n: ");
            var n = Extractor.GetInt32(Console.ReadLine());

            Console.Write("Input m: ");
            var m = Extractor.GetInt32(Console.ReadLine());

            if (n < 0 || m < 0) Console.WriteLine("Error, number n and m is natural");

            var arr = new int[n, m];

            var arrWithDifferenceElements = GetArrayElementDifference(arr, n, m);

            PrettyShowArray(arrWithDifferenceElements, n, m);

            Console.WriteLine($"Length - {arr.Length}");
            Console.WriteLine($"Array dimension - {arr.Rank}");
            Console.WriteLine($"Sum elements = {Sum(arr)}");
        }

        private static int Sum(int[,] arr)
        {
            var sum = 0;

            foreach (var element in arr) sum += element;

            return sum;
        }

        private static int[,] GetArrayElementDifference(int[,] arr, int n, int m)
        {
            for (var i = 0; i < n; i++)
            for (var j = 0; j < m; j++)
                arr[i, j] = i - j;

            return arr;
        }

        private static void PrettyShowArray(int[,] arr, int n, int m)
        {
            for (var i = 0; i < n; i++)
            {
                for (var j = 0; j < m; j++) Console.Write($"{arr[i, j],3}");
                Console.WriteLine();
            }
        }
    }
}