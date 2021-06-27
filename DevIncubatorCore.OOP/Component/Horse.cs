using System;
using DevIncubatorCore.OOP.Component.Base;

namespace DevIncubatorCore.OOP.Component
{
    class Horse : Animal
    {
        public Horse()
        {

        }
        public Horse(string name, int footNumber, bool hasMustache) 
            : base(name, footNumber, hasMustache)
        {
            
        }

        public override void Voice()
        {
            Console.WriteLine("I-go-go");
        }

        public override void Move()
        {
            Console.WriteLine("Top-top");
        }

        public new void IsHungry()
        {
            Console.WriteLine("I want hay");
        }
    }
}
