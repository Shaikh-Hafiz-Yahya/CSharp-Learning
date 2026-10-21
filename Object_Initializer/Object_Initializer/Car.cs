using System;
using System.Collections.Generic;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    internal class Car
    {

        // Constructor / initializer
        public Car()

        {

            model = 2025;
            mycar = "blue";
            quantity = 100;

        }

        // Attributes 
        public int model;
        public string mycar = ""; 
        public int quantity;

        // Method 
        public void Info()
        {
            Console.Write($"\nYour car color is {mycar}\nYour selected model {model}\nBuy {quantity} Cars.\n");

        }

    }
}
