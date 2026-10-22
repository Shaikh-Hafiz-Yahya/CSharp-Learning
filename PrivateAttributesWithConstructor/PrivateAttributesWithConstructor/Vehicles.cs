using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAttributesWithConstructor
{
    internal class Vehicles
    {
        // Parametrized Constructor
        public Vehicles(string CColor1, int CSpeed1)
        {
            CColor = CColor1;
            CSpeed = CSpeed1;
        }

        // Private Attributes
        private string CColor;
        private int CSpeed;

        // Methods
        public void DisplayInfo()
        {
            Console.WriteLine($"\nCar Color : {CColor}\n Car Velocity : {CSpeed}");
        }
    }
}
