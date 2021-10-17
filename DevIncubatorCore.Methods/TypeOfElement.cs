using System;

namespace DevIncubatorCore.Methods
{
    internal class TypeOfElement : ITask
    {
        public void RunTask()
        {
            ShowType(10, "hello", 10.0, true, '1', -1);
        }

        private void ShowType(params object[] objects)
        {
            foreach (var obj in objects)
            {
                Console.Write($"{obj.GetType()} ");
            }

            Console.WriteLine();
        }
    }
}