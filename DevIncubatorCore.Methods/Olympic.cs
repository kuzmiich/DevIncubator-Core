using System;
using System.Collections.Generic;

namespace DevIncubatorCore.Methods
{
    class Olympic : ITask
    {

        private static int Max(IReadOnlyList<int> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            int max = 0;
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] > max)
                {
                    max = collection[i];
                }
            }

            return max;
        }

        private static int Min(IReadOnlyList<int> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            int min = collection[0];
            for (int i = 0; i < collection.Count; i++)
            {
                if (collection[i] < min)
                {
                    min = collection[i];
                }
            }

            return min;
        }

        private static int Sum(IReadOnlyCollection<int> collection)
        {
            if (collection == null) throw new ArgumentNullException(nameof(collection));

            int sum = 0;
            foreach (var element in collection)
            {
                sum += element;
            }

            return sum;
        }

        private static float Average(IReadOnlyCollection<int> collection)
        { 
            return Sum(collection) / (float)collection.Count;
        }

        public void RunTask()
        {
            Console.WriteLine("Input the height of the participants of the competition(by SPACE): ");
            var strArrayNumbers = Console.ReadLine()?.Split(" ");

            if (strArrayNumbers?.Length == 1)
            {
                return;
            }
            var listParticipants = new List<int>();

            foreach (var strNumber in strArrayNumbers)
            {
                listParticipants.Add(Extractor.GetInt32(strNumber));
            }

            Console.WriteLine("Delete min and max indexes:");
            if (listParticipants.Count > 2)
            {
                var min = Min(listParticipants);
                var max = Max(listParticipants);

                listParticipants.Remove(min);
                listParticipants.Remove(max);
            }

            Console.WriteLine(string.Join(' ', listParticipants));

            Console.WriteLine($"Average value - {Average(listParticipants)}");
            
        }
    }
}
