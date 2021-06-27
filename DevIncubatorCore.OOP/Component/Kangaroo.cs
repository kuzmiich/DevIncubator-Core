using System;
using DevIncubatorCore.OOP.Component.Base;

namespace DevIncubatorCore.OOP.Component
{
    class Kangaroo : Animal
    {
        public Kangaroo()
        {

        }
        public Kangaroo(string name, int footNumber, bool hasMustache) 
            : base(name, footNumber, hasMustache)
        {
            
        }

        public override void Voice()
        {
            Console.WriteLine("khe-khe");
        }

        public override void Move()
        {
            Console.WriteLine("Jump-jump");
        }

        public new void IsHungry()
        {
            Console.WriteLine("I want berries");
        }
    }
}
