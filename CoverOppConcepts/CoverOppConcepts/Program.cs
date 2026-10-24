using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverOppConcepts
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Object  
            HealthCareSystem R1 = new HealthCareSystem("john", 59, true, 0, 0);
            HealthCareSystem R2 = new HealthCareSystem("Jay", 20, false, 1, 1);
            HealthCareSystem R3 = new HealthCareSystem("Andrew", 49, true, 0, 0);

            R1.UpdateAttr(1, 0); // Updated Attr private bhi hain
            Console.WriteLine($"{R2.pName}  Health : {R2.AccessPrivateAttributes1()}");
            Console.WriteLine($"\n{R3.pName}  Health : {R3.AccessPrivateAttributes2()}");

            Console.WriteLine($"\n{R1.pName}\nHealth:{R1.pHealth3}\nAge:{R1.pAge}");
            Console.WriteLine($"\n{R2.pName}\nHealth:{R2.pHealth3}\nAge:{R2.pAge}");
            Console.WriteLine($"\n{R3.pName}\nHealth:{R3.pHealth3}\nAge:{R3.pAge}");

            // Call Method
            R1.GetInfo();
            R2.GetInfo();
            R3.GetInfo();   

        }
    }
}
