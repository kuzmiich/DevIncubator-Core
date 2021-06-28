using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore.Generics.Components.RackStore.Base;
using DevIncubatorCore.Generics.Components.RackStore.Products;

namespace DevIncubatorCore.Generics.Components.RackStore.GeneratorService
{
    static class ProductGenerator
    {
        private enum ProductType
        {
            Bread,
            Milk,
            Pasta,
            Porridge
        }
        private static readonly List<string> ProductNames = new()
        {
            "Bread", 
            "Milk",
            "Pasta",
            "Porridge"
        };
        
        private static readonly Random _random = new();

        private static Bread GetBread()
        {
            var index = _random.Next(ProductNames.Count);
            var name = ProductNames[_random.Next(index)];
            return new Bread(name);
        }

        public static List<Bread> GetBread(int count)
        {
            if (count > 0)
            {
                var products = new List<Bread>();

                for (int i = 0; i < count; i++)
                {
                    products.Add(GetBread());
                }

                return products;
            }

            return new List<Bread>();
        }

        public static Milk GetMilk()
        {
            const int index = 1;
            var name = ProductNames[_random.Next(index)];
            return new Milk(name);
        }

        public static List<Milk> GetMilk(int count)
        {
            if (count > 0)
            {
                var products = new List<Milk>();

                for (int i = 0; i < count; i++)
                {
                    products.Add(GetMilk());
                }

                return products;
            }

            return new List<Milk>();
        }


        private static Pasta GetPasta()
        {
            const int index = 2;
            var name = ProductNames[index];
            return new Pasta(name);
        }

        public static List<Pasta> GetPasta(int count)
        {
            if (count > 0)
            {
                var products = new List<Pasta>();

                for (int i = 0; i < count; i++)
                {
                    products.Add(GetPasta());
                }

                return products;
            }

            return new List<Pasta>();
        }

        public static Porridge GetPorridge()
        {
            const int index = 3;
            var name = ProductNames[index];
            return new Porridge(name);
        }

        public static List<Porridge> GetPorridge(int count)
        {
            if (count > 0)
            {
                var products = new List<Porridge>();

                for (int i = 0; i < count; i++)
                {
                    products.Add(GetPorridge());
                }

                return products;
            }

            return new List<Porridge>();
        }
    }
}
