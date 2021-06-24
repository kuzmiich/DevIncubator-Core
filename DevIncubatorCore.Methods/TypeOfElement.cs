using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Methods
{
    class TypeOfElement : ITask
    {
        private void ShowType(params object[] objects)
        {
            foreach (var obj in objects)
            {
                Console.Write($"{obj.GetType()} ");
            }
            Console.WriteLine();
        }
        public void RunTask()
        {
            ShowType(10, "hello", 10.0, true, '1', -1 );
        }
    }
}
