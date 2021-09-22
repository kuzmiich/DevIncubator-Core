using System;
using System.Collections.Generic;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    internal class EmptyString : ITask
    {
        public void RunTask()
        {
            Console.Write("Input count string: ");
            var count = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine("Input strings: ");
            var sourceData = new string[count];
            for (var i = 0; i < count; i++) sourceData[i] += Console.ReadLine();

            var editArrayString = FixEmptyString(sourceData);

            Console.WriteLine($"{string.Join('\n', editArrayString)}");
        }

        private static IEnumerable<string> FixEmptyString(params string[] array)
        {
            var fixArrayString = new string[array.Length];

            for (var i = 0; i < array.Length; i++)
            {
                if (array[i].Equals(string.Empty))
                {
                    fixArrayString[i] = "String is empty";
                    continue;
                }

                fixArrayString[i] = array[i];
            }

            return fixArrayString;
        }
    }
}