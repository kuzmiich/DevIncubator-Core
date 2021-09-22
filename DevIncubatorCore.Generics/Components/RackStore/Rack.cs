using System.Collections;
using System.Collections.Generic;
using DevIncubatorCore.Generics.Components.RackStore.Base;

namespace DevIncubatorCore.Generics.Components.RackStore
{
    internal class Rack<T> : IEnumerable<T> where T : Product
    {
        public Rack()
        {
        }

        public Rack(List<T> products)
        {
            Products = products;
            Count += products.Count;
        }

        public static int Count { get; private set; }
        public List<T> Products { get; }

        public IEnumerator<T> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }

        public void Add(T product)
        {
            Products.Add(product);
            Count++;
        }
    }
}