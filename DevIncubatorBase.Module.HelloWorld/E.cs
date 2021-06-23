using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Module.HelloWorld
{
    class E : ITask
    {
        public void RunTask()
        {
            object first = 1;
            object second = 1;
            object third = first;

            Console.WriteLine($"First variable equal second variable - {object.Equals(first, second)}");

            Console.WriteLine($"First variable reference equal second variable - {object.ReferenceEquals(first, third)}");
        }
    }
}
