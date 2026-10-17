using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Methods CarObj = new Methods();
            CarObj.CarColor = "Dark Grey";
            CarObj.CarModel = 2026;
            CarObj.method1();

            Methods CarObj2 = new Methods();
            CarObj2.CarColor = "Red";
            CarObj2.CarModel = 1995;
            CarObj2.method2();

            Methods CarObj3 = new Methods();
            CarObj3.CarColor = "Blue";
            CarObj3.CarModel = 2021;
            CarObj3.method3();      
        }
    }
}
