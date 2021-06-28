using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.Generics.Components.TableWriter
{
    internal class User
    {
        public User()
        {
            
        }
        public User(int id, string name, string surname, int? age)
        {
            Id = id;
            Name = name;
            Surname = surname;
            Age = age;
        }
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int? Age { get; set; }

        public override string ToString()
        {
            return $"{Id, 2}{Name, 9}{Surname, 12}{Age, 6}";
        }
    }
}
