using System;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    internal class AverageAge : ITask
    {
        public void RunTask()
        {
            Console.Write("Input count string: ");
            var count = Extractor.GetInt32(Console.ReadLine());
            if (count == 0) return;

            Console.WriteLine("Input numbers: ");

            var sourceData = new int?[count];
            for (var i = 0; i < count; i++)
            {
                var str = Console.ReadLine();
                if (str.Equals(string.Empty))
                {
                    sourceData[i] = null;
                    continue;
                }

                sourceData[i] = int.Parse(str);
            }

            var averageAge = GetAverageAge(sourceData);

            Console.WriteLine($"Average age - {Math.Round(averageAge, 2)}");
        }

        private static double GetAverageAge(params int?[] array)
        {
            var count = 0.0;
            var sum = 0;
            foreach (var element in array)
                if (element.HasValue)
                {
                    sum += element.Value;
                    count++;
                }

            return sum / count;
        }
    }
}