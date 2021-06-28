using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DevIncubatorCore.Generics.Components.RackStore.Base;

namespace DevIncubatorCore.Generics.Components.RackStore.Products
{
    class Bread : Product
    {
        public Bread()
        {  
        }

        public Bread(string name) : base(name)
        {
        }
    }
}
