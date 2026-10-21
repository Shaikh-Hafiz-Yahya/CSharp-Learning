using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyPlayer p1 = new MyPlayer();
            p1.Name = "Albert";
            p1.Score = 100;
            p1.ShowInfo();

            MyPlayer p2 = new MyPlayer { Name = "Andrew", Score = 50 }; //Object Initializer.
            p2.ShowInfo();

            Constructor p1 = new Constructor();
            p1.Name = "Albert";
            p1.Score = 100;
            p1.ShowInfo();

            Constructor p2 = new Constructor(); // object initialize
            p2.ShowInfo();

            Car c1 = new Car();
            Car c2 = new Car();

            c2.model = 2020;
            c2.mycar = "Red";
            c2.quantity = 11;

            c1.Info();
            c2.Info();


            HealthCare h1 = new HealthCare();
            h1.PatientName = "John";
            h1.PatientAge = 30;
            h1.PatientReport = true;
            h1.GetPatientInfo1();

            HealthCare h2 = new HealthCare();
            h2.GetPatientInfo1();        
            
        }
    }
}
