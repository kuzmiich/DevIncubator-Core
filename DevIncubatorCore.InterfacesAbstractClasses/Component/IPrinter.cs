using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIncubatorCore.InterfacesAbstractClasses.Component
{
    internal interface IPrinter
    {
        void Print(string text);

        void Scan();
    }
}
