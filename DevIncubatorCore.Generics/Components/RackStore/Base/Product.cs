namespace DevIncubatorCore.Generics.Components.RackStore.Base
{
    internal abstract class Product
    {
        protected Product()
        {
        }

        protected Product(string name)
        {
            Name = name;
        }

        public string Name { get; set; }
    }
}