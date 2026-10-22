using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAttributesWithConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // Objects 
            Vehicles c1 = new Vehicles("Black" , 70);
            Vehicles c2 = new Vehicles("Red" , 99);
            Vehicles c3 = new Vehicles("Grey" , 80);

            c1.DisplayInfo(); // Access private Attr
            c2.DisplayInfo(); // Access private Attr
            c3.DisplayInfo(); // Access private Attr

        }

    }
}
