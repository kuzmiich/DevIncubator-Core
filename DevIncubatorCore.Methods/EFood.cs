using System;

namespace DevIncubatorCore.Methods
{
    internal class EFood : ITask
    {
        public void RunTask()
        {
            Console.Write("Input burgers count: ");
            var burgersCount = Extractor.GetInt32(Console.ReadLine());

            Console.Write("Input lattes count: ");
            var lattesCount = Extractor.GetInt32(Console.ReadLine());

            Console.Write("Input ice creams count: ");
            var iceCreamsCount = Extractor.GetInt32(Console.ReadLine());

            Console.Write("Do you want >1 table set (1=yes or 0=no):");
            var needTable = Extractor.GetBool(Console.ReadLine());

            var tableSetCount = 1;
            if (needTable)
            {
                Console.Write("How much table set count you need? ");
                tableSetCount = Extractor.GetInt32(Console.ReadLine());
                if (tableSetCount < 0) tableSetCount = 0;
            }

            Console.WriteLine(
                $"You ordered {burgersCount} burgers, {lattesCount} lattes, {iceCreamsCount} ice cream\n" +
                $"Additional {tableSetCount} table set");
        }
    }
}