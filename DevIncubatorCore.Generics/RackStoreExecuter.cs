using System;
using DevIncubatorCore.Generics.Components.RackStore;
using DevIncubatorCore.Generics.Components.RackStore.GeneratorService;
using DevIncubatorCore.Generics.Components.RackStore.Products;

namespace DevIncubatorCore.Generics
{
    internal class RackStoreExecuter : ITask
    {
        public void RunTask()
        {
            var rackBread1 = new Rack<Bread>(ProductGenerator.GetBread(30));
            var rackBread2 = new Rack<Bread>(ProductGenerator.GetBread(40));
            var rackBreads3 = new Rack<Bread>(ProductGenerator.GetBread(40));
            var rackMilks1 = new Rack<Milk>(ProductGenerator.GetMilk(40));
            var rackMilks2 = new Rack<Milk>(ProductGenerator.GetMilk(45));
            var rackPastas = new Rack<Pasta>(ProductGenerator.GetPasta(70));
            var rackPorridges = new Rack<Porridge>(ProductGenerator.GetPorridge(60));


            Console.WriteLine($"Milk: {Rack<Milk>.Count}");
            Console.WriteLine($"Porridge: {Rack<Porridge>.Count}");
            Console.WriteLine($"Pasta: {Rack<Pasta>.Count}");
            Console.WriteLine($"Bread: {Rack<Bread>.Count}");
        }
    }
}