using System;
using DevIncubatorCore.InterfacesAbstractClasses.Component;

namespace DevIncubatorCore.InterfacesAbstractClasses
{
    internal class InkjetPrinter : Printer, IPrinter
    {
        public InkjetPrinter(string type, bool isPresence)
            : base(type, isPresence)
        {
        }

        public string StampType { get; init; }

        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Scan()
        {
            Console.WriteLine("The scan is complete");
        }

        public override void Start(string text)
        {
            Print(text);
            Scan();
        }
    }
}