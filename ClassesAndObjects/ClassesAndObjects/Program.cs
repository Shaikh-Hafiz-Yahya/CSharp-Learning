using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndObjects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Classes obj = new Classes();

            obj.Name = "Test";
            obj.Description = "This is C# PROGRAMMING LANGUAGE";

            Console.WriteLine(obj.Name);
            Console.WriteLine(obj.Description.ToLower());

        }
    }
}
