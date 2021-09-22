using System;
using System.Collections;
using System.Collections.Generic;

namespace DevIncubatorCore.Collections
{
    internal class JosephExecuter : ITask
    {
        public void RunTask()
        {
            Console.Write("Input n people: ");
            var number = Extractor.GetInt32(Console.ReadLine());

            //Console.WriteLine(string.Join(' ', FromJoseph(number)));
        }

        private void FromJoseph(int number)
        {
            var linkedList = new LinkedList<ArrayList>();
            var arrayList = new ArrayList();
            var limit = (int) Math.Ceiling(number / 2m);

            for (var i = 1; i < limit; i++)
            {
                arrayList.Add(i);
                if (linkedList.Count == 1) return; // i
            }
        }
    }
}