using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore.OOP.Component;
using DevIncubatorCore.OOP.Component.Base;

namespace DevIncubatorCore.OOP
{
    class AnimalExecuter : ITask
    {
        public void RunTask()
        {
            var herd = new Animal[7];
            herd[0] = new Horse("Horse", 4, false);
            herd[1] = new Animal("Dog", 4, false);
            herd[2] = new Dragonfly("DragonFly", 4, true);
            herd[3] = new Kangaroo("Kangaroo", 2, true);
            herd[4] = new Animal("Fish", 0, false);
            herd[5] = new Animal("Cat", 4, false);
            herd[6] = new Animal("Unknown type", 10, true);

            var horse = new Horse("Horse 3", 4, false);
            var kangaroo = new Kangaroo("Kangaroo 3", 2, true);
            var dragonfly = new Dragonfly("Dragonfly 3", 4, true);

            foreach (var animal in herd)
            {
                animal.Voice();
                animal.Move();
                Console.WriteLine();
            }

            horse.Move();
            kangaroo.Move();
            dragonfly.Move();

            Console.WriteLine(string.Empty.PadLeft(70, '-'));

            // is hungry tests
            foreach (var animal in herd)
            {
                animal.IsHungry();
            }

            horse.IsHungry();
            kangaroo.IsHungry();
            dragonfly.IsHungry();

        }
    }
}
