using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Methods
{
    enum CompareType
    {
        Ascending,
        Descending
    }
    class BubbleSortVariable : ITask
    {
        // min -> max
        private void BubbleSortAscending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] > array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
        }
        private void BubbleSortDescending(int[] array)
        {
            for (int i = 0; i < array.Length; i++)
            {
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[i] < array[j])
                    {
                        (array[i], array[j]) = (array[j], array[i]);
                    }
                }
            }
        }
        //
        private int[] BubbleSort(CompareType compare, params int[] array)
        {
            if (compare == CompareType.Ascending)
            {
                BubbleSortAscending(array);
            }
            else
            {
                BubbleSortDescending(array);
            }

            return array;
        }
        public void RunTask()
        {
            Console.WriteLine("Filling the array with values");
            var arr = Console.ReadLine()?.Split().Select(int.Parse).ToArray();

            var descendingArray = BubbleSort(CompareType.Descending, arr);
            Console.WriteLine(string.Join(' ', descendingArray));

            var ascendingArray = BubbleSort(CompareType.Ascending, arr);
            Console.WriteLine(string.Join(' ', ascendingArray));
        }
    }
}
