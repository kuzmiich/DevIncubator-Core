using System.Collections;
using System.Collections.Generic;
using DevIncubatorCore.Generics.Components.RackStore.Base;

namespace DevIncubatorCore.Generics.Components.RackStore
{
    class Rack<T> : IEnumerable<T> where T : Product
    {
        public static int Count { get; private set; }

        public Rack()
        {
        }

        public Rack(List<T> products)
        {
            Products = products;
            Count += products.Count;
        }
        public List<T> Products { get; private set; }

        public void Add(T product)
        {
            Products.Add(product);
            Count++;
        }

        public IEnumerator<T> GetEnumerator()
        {
            return Products.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
