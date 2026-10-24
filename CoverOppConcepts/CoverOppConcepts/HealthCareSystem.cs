using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoverOppConcepts
{
    internal class HealthCareSystem
    {
        // Parametized Constructor.
        public HealthCareSystem(string Name, int Age, bool h1, int h2, int h3) 
        {

            pName = Name;
            pAge = Age;
            pHealth = h1;
            pHealth2 = h2;
            pHealth3 = h3;

        }
        // Attributes/Properties (Use Public & Private Concepts.)
        public string pName;
        public int pAge;
        private bool pHealth;
        private int pHealth2;
        public int pHealth3;

        // Method1 (Update Attributes) 
        public void UpdateAttr(int pH2 , int pH3)
        {
            pHealth2 = pH2;
            pHealth3 = pH3;
        }

        // Method2 (1st Private Attr access)
        public int AccessPrivateAttributes1()
        {
            return pHealth2;
        }

        // Method3 (2nd Private Attr access)
        public int AccessPrivateAttributes2()
        {
            return pHealth3;
        }

        // Method3
        public void GetInfo()
        {
            Console.WriteLine($"\nName:{pName}\nAge:{pAge}\nPopulation Health(Average):{pHealth}\n");
        }

    }
}
