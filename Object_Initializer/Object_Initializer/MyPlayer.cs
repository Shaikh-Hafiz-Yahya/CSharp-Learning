using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    internal class MyPlayer
    {
        public string Name = "";
        public int Score;

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} has {Score} points");
        }

    }
}
