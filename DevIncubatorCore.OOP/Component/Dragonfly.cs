using System;
using DevIncubatorCore.OOP.Component.Base;

namespace DevIncubatorCore.OOP.Component
{
    internal class Dragonfly : Animal
    {
        public Dragonfly()
        {
        }

        public Dragonfly(string name, int footNumber, bool hasMustache)
            : base(name, footNumber, hasMustache)
        {
        }

        public override void Voice()
        {
            Console.WriteLine("bj-w-w");
        }

        public override void Move()
        {
            Console.WriteLine("flight");
        }

        public new void IsHungry()
        {
            Console.WriteLine("I want insects");
        }
    }
}