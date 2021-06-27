using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.ReferenceValueTypesNullableTypesEnums
{
    class EmptyString : ITask
    {
        private static IEnumerable<string> FixEmptyString(params string[] array)
        {
            var fixArrayString = new string[array.Length];

            for (int i = 0; i < array.Length; i++)
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
        public void RunTask()
        {
            Console.Write("Input count string: ");
            var count = Extractor.GetInt32(Console.ReadLine());

            Console.WriteLine("Input strings: ");
            var sourceData = new string[count];
            for (int i = 0; i < count; i++)
            {
                sourceData[i] += Console.ReadLine();
            }

            var editArrayString = FixEmptyString(sourceData);

            Console.WriteLine($"{string.Join('\n', editArrayString)}");
        }
    }
}
