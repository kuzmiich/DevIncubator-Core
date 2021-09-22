using System;
using System.Linq;

namespace DevIncubatorCore.ArraysForeach
{
    internal enum CompareType
    {
        Ascending,
        Descending
    }

    internal class BubbleSortVariable : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Filling the array with values:");
            var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();

            BubbleSort(in arr, CompareType.Descending);

            Console.WriteLine(string.Join(' ', arr));

            BubbleSort(in arr, CompareType.Ascending);

            Console.WriteLine(string.Join(' ', arr));
        }

        // min -> max
        private static void BubbleSortAscending(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            for (var j = i + 1; j < array.Length; j++)
                if (array[i] > array[j])
                    (array[i], array[j]) = (array[j], array[i]);
        }

        private static void BubbleSortDescending(int[] array)
        {
            for (var i = 0; i < array.Length; i++)
            for (var j = i + 1; j < array.Length; j++)
                if (array[i] < array[j])
                    (array[i], array[j]) = (array[j], array[i]);
        }

        //
        private static void BubbleSort(in int[] array, CompareType compare)
        {
            if (compare == CompareType.Ascending)
                BubbleSortAscending(array);
            else
                BubbleSortDescending(array);
        }
    }
}