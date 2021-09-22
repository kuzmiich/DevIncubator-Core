using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevIncubatorCore.StringStringBuilder
{
    internal class TextProcessor : ITask
    {
        //

        public void RunTask()
        {
            A();
            B();
            C();
            D();
            E();
            F();
        }

        public void A()
        {
            Console.Write("Input source string: ");
            var hashSetString = Console.ReadLine()?.Split().ToHashSet();

            Console.Write("String without repetitions - ");
            foreach (var str in hashSetString) Console.Write($"{str} ");
            Console.WriteLine();
        }

        //
        private static StringBuilder Insert(StringBuilder builder, int position, string text)
        {
            if (position > builder.Length) return new StringBuilder("Error, position out of range!");
            return builder.Insert(position, text);
        }

        private static StringBuilder Append(StringBuilder builder, string text)
        {
            return builder.AppendLine(text);
        }

        private static StringBuilder Delete(StringBuilder builder, char criteria)
        {
            var startIndex = 0;
            foreach (var symbol in builder.GetChunks())
            {
                if (symbol.Equals(criteria)) break;

                startIndex++;
            }

            const int Count = 1;
            return builder.Remove(startIndex, Count);
        }

        private static StringBuilder Replace(StringBuilder builder, string old, string replace)
        {
            return builder.Replace(old, replace);
        }

        public void B()
        {
            // get data
            Console.Write("Text: ");
            var splitString = Console.ReadLine()?.Split(": ", StringSplitOptions.TrimEntries);

            var text = new StringBuilder();
            if (splitString != null)
            {
                var correctString = splitString[1].Replace("\"", "");
                text.Append(correctString);
            }

            Console.Write("Operation type and data: ");
            var splitOperationTypeAndData = Console.ReadLine()?.Split(": ");

            var operationType = string.Empty;
            string[] data = { };
            if (splitOperationTypeAndData != null)
            {
                var operationTypeJoin = string.Join(' ', splitOperationTypeAndData[0]);
                operationType = operationTypeJoin.Split(' ')[^1];

                var dataJoin = string.Join(' ', splitOperationTypeAndData[1])
                    .Replace("\"", "");
                data = dataJoin.Split(' ');
            }

            // end get data
            var editString = operationType switch
            {
                "append" => Append(text, data[0]),
                "insert" => Insert(text, 6, data[0]),
                "delete" => Delete(text, data[0][0]),
                "replace" => Replace(text, data[0], data[1]),
                _ => new StringBuilder("Error, incorrect operation!")
            };
            Console.WriteLine(editString);
        }

        //
        private static void Reverse<T>(params T[] array)
        {
            for (var i = 0; i < array.Length / 2; i++)
            {
                var j = array.Length - i - 1;
                (array[i], array[j]) = (array[j], array[i]);
            }
        }

        public void C()
        {
            Console.Write("Input source string: ");
            var charArray = Console.ReadLine()?.ToCharArray();

            Reverse(charArray);

            Console.WriteLine($"Reverse string - {string.Join("", charArray)}");
        }

        //
        private static IEnumerable<T> Split<T>(IEnumerable<T> array, T separator)
        {
            var splitArray = new List<T>();
            var i = 0;
            foreach (var symbol in array)
            {
                if (!symbol.Equals(separator)) splitArray.Add(symbol);
                i++;
            }

            return splitArray;
        }

        public void D()
        {
            Console.Write("Input source string: ");
            var charArray = Console.ReadLine()?.ToCharArray();

            var splitArray = Split(charArray, ' ');

            Console.WriteLine($"Reverse string - {string.Join("", splitArray)}");
        }
        //

        private static string ToUpper(char[] charArray)
        {
            var upperString = string.Empty;
            foreach (var symbol in charArray)
                if (symbol is (>= 'A' and <= 'Z'))
                    upperString += symbol;
            return upperString;
        }

        public void E()
        {
            Console.Write("Input source string: ");
            var charArray = Console.ReadLine()?.ToCharArray();

            var uppercaseArray = ToUpper(charArray);

            Console.WriteLine($"Only uppercase string: {uppercaseArray}");
        }

        //
        private static string ToEvenLetter(StringBuilder sb)
        {
            var upperString = string.Empty;
            for (var i = 1; i < sb.Length; i += 2) upperString += sb[i];

            return upperString;
        }

        public void F()
        {
            Console.Write("Input source string: ");
            var sb = new StringBuilder(Console.ReadLine());

            var uppercaseArray = ToEvenLetter(sb);

            Console.WriteLine($"Only uppercase string: {uppercaseArray.ToUpper()}");
        }
    }
}