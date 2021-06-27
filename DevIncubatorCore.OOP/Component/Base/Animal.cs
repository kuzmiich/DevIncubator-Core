using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.OOP.Component.Base
{
    class Animal
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
