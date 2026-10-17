using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class UpdateClassAttr
    {
        //public string name = "Imtiaz";
        //public int age = 39;

        //public void SetMethod(string n)
        //{

        //    name = n;

        //}

        //public void SetAge(int a)
        //{

        //    age = a;

        //}

        //public string userName = Console.ReadLine();

        //public string userPassword = Console.ReadLine();

        //public string userId = Console.ReadLine();

        //public string userSalary = Console.ReadLine();

        //public void UpdateAttr(string id)
        //{
        //    userId = id;
        //}

        //public string carName = Console.ReadLine();

        //public string carColor = Console.ReadLine();

        //public int carCount = 1;

        //public string carName2 = Console.ReadLine();    

        //public string carColor2 = Console.ReadLine();

        //public string carCount2 = Console.ReadLine();

        //public string carName3 = Console.ReadLine();

        public string carColor3 = Console.ReadLine();

        //public string carCount3 = Console.ReadLine();

        public string carCountnth = Console.ReadLine();

        public void UpdateCarCount(string nth)
        {
            carCountnth = nth; // Update Attr/Property Through Method.
        }

        public void UpdateCarColor(string newColor)
        {
            carColor3 = newColor;
        }

    }
}
