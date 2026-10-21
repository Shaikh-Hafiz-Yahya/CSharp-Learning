using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    internal class Constructor
    {

        public Constructor()
        {

            Name = "Andrew";
            Score = 50;

        }

        public string Name = "";
        public int Score = 50;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} has {Score} points");
        }
    }
}
