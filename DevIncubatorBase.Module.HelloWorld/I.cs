using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.HelloWorld
{
    class I : ITask
    {
        public void RunTask()
        {
            Console.WriteLine("Have you done all your homework?");
            var a = Console.ReadLine();

            Console.WriteLine("Did you make a team project?");
            var b = Console.ReadLine();

            Console.WriteLine("If you have debt at university?");
            var c = Console.ReadLine();

            if (a == "Yes" && b == "Yes" && c == "No")
            {
                Console.WriteLine("Today, you can go for a walk with friends.");
            }
            else
            {
                Console.WriteLine("You still have things to do, you can`t go out with your friends today.");
            }
        }
    }
}
