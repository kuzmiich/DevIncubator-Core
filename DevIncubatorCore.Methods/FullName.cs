using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Methods
{
    class FullName : ITask
    {
        public void RunTask()
        {
            var firstName = "Vasily";
            var surname = "McGregor";
            var lastName = "Ivanov";

            Console.WriteLine($"{firstName} {surname} {lastName}");
        }
    }
}
