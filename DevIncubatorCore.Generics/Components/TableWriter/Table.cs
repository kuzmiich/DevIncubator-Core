using System.Collections;
using System.Collections.Generic;

namespace DevIncubatorCore.Generics.Components.TableWriter
{
    internal class Table<T> : IEnumerable<T> where T : User
    {
        public Table(List<T> users)
        {
            Users = users;
        }

        public List<T> Users { get; }


        public T this[int index]
        {
            get => Users[index];
            set => Users[index] = value;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Users.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public override string ToString()
        {
            return "ID |  Name  |  Surname  | Age |\n" +
                   $"{string.Join('\n', Users)}";
        }
    }
}