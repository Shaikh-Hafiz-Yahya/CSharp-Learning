using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassMethods
{
    internal class Methods
    {
        public string CarColor;
        public int CarModel;

        public void method1()
        {
            Console.WriteLine($"This Car is : {CarColor}\n Car Model : {CarModel}");

        }

        public void method2()
        {
            Console.WriteLine($"\nThis Car is : {CarColor}\n Car model : {CarModel}");
        }

        public void method3()
        {
            Console.WriteLine($"\nThis Car is : {CarColor}\n Car model : {CarModel}");
        }


    }

}
