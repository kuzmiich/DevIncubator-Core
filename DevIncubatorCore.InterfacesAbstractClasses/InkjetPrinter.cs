using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore.InterfacesAbstractClasses.Component;

namespace DevIncubatorCore.InterfacesAbstractClasses
{
    class InkjetPrinter : Printer, IPrinter
    {
        public InkjetPrinter(string type, bool isPresence) 
            : base(type, isPresence)
        {
        }

        public string StampType { get; init; }

        public override void Start(string text)
        {
            Print(text);
            Scan();
        }
        public void Print(string text)
        {
            Console.WriteLine(text);
        }

        public void Scan()
        {
            Console.WriteLine("The scan is complete");
        }
    }
}
