using System;
using DevIncubatorCore.InterfacesAbstractClasses.Component;

namespace DevIncubatorCore.InterfacesAbstractClasses
{
    internal class LaserPrinter : Printer, IPrinter
    {
        public LaserPrinter(string type, bool isPresence)
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
            Console.WriteLine("The scan is impossible");
        }

        public override void Start(string text)
        {
            Print(text);
            Scan();
        }
    }
}