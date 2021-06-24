using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Module.HelloWorld
{
    class D : ITask
    {
        public void RunTask()
        {
            string a = "default";
            int b = 21;
            double c = 34.432;

            var stringHashCode = a.GetHashCode();
            var intHashCode = b.GetHashCode();
            var doubleHashCode = c.GetHashCode();

            Console.WriteLine($"String hash code - {stringHashCode}, int hash code - {intHashCode}, double hash code - {doubleHashCode}");
        }
    }
}
