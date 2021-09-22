using System;

namespace DevIncubatorCore.OOP.Component.Base
{
    internal class Animal
    {
        public Animal()
        {
        }

        public Animal(string name, int footNumber, bool hasMustache)
        {
            Name = name;
            FootNumber = footNumber;
            HasMustache = hasMustache;
        }

        public string Name { get; protected set; }
        public int FootNumber { get; }
        public bool HasMustache { get; }

        public virtual void Voice()
        {
            Console.WriteLine("Voice");
        }

        public virtual void Move()
        {
            Console.WriteLine("Movement");
        }

        public virtual void IsHungry()
        {
            Console.WriteLine("Not hungry");
        }
    }
}