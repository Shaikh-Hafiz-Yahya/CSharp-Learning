using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpdateClassAtributes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Player pObj = new Player();
            pObj.Name = "John";
            pObj.Health = 100;
            Console.WriteLine($"Player Name : {pObj.Name}");
            Console.WriteLine($"Player Health : {pObj.Health}");

            // update health
            pObj.Health = pObj.Health * 100;
            pObj.MaxHealth(pObj.Health);
            Console.WriteLine($"\nHealth is updated : {pObj.Health}");
        }
    }
}
