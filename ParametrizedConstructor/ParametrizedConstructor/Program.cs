using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrizedConstructor
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Health p1 = new Health("critical","John",10,2,true,1110.95); // Parameters/Args
            Health p2 = new Health("normal", "Albert", 90, 29, true, 120.50); // Parameters/Args

            p1.PatientName = "Faraday";
            //p1.PatientHealth = "normal";
            p1.HealthLevel = 50;
            //p1.Appoinment = 25;
            p1.SugarLevel = false;
            //p1.Dues = 2000.77;

            p1.PatientInfo();
            p2.PatientInfo();
            Console.WriteLine($"\nName:{p1.PatientName}\nHealth:{p1.HealthLevel}\nSugar:{p1.SugarLevel}");
         
        }
    }
}
