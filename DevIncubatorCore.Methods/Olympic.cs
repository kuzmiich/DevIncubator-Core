using System;
using System.Collections.Generic;
using System.Linq;

namespace DevIncubatorCore.Methods
{
    class Olympic : ITask
    {

        private static int Max(params int[] collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            int max = 0;
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] > max)
                {
                    max = collection[i];
                }
            }

            return max;
        }

        private static int Min(params int[] collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            int min = collection[0];
            for (int i = 0; i < collection.Length; i++)
            {
                if (collection[i] < min)
                {
                    min = collection[i];
                }
            }

            return min;
        }

        private static int Sum(params int[] collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            int sum = 0;
            foreach (var element in collection)
            {
                sum += element;
            }

            return sum;
        }

        private static float Average(params int[] collection)
        {
            return Sum(collection) / (float) collection.Length;
        }

        public void RunTask()
        {
            Console.WriteLine("Input the height of the participants of the competition(by SPACE): ");
            var strArrayNumbers = Console.ReadLine()?.Split(" ");

            if (strArrayNumbers?.Length == 1)
            {
                return;
            }
            var participantsList = new List<int>();

            foreach (var strNumber in strArrayNumbers)
            {
                participantsList.Add(Extractor.GetInt32(strNumber));
            }

            var participantsArray = participantsList.ToArray();

            var min = Min(participantsArray);
            var max = Max(participantsArray);

            Console.WriteLine("Delete min and max indexes:");
            if (participantsList.Count > 2)
            {
                participantsList.Remove(min);
                participantsList.Remove(max);
            }

            Console.WriteLine(string.Join(' ', participantsList));

            Console.WriteLine($"Average value - {Average(participantsList.ToArray())}");
            
        }
    }
}
