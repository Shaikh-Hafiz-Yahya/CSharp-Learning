using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParametrizedConstructor
{
    internal class Health
    {
        // Parametrized Constructor / Initializer
        public Health(string h1 , string n1 , int hlevel1 , int a1 , bool s1 , double d1) 
        {

            PatientHealth = h1;
            PatientName = n1;
            HealthLevel = hlevel1;
            Appoinment = a1;
            SugarLevel = s1;
            Dues = d1;

        }
        // Attributes
        public string PatientHealth;
        public string PatientName;
        public int HealthLevel;
        public int Appoinment;
        public bool SugarLevel;
        public double Dues;
        
        // Method
        public void PatientInfo()
        {
            Console.WriteLine($"\nPatient: {PatientName}\nHealth: {PatientHealth}\nHealthLevel: {HealthLevel}\nAppoinment: {Appoinment}\nSugar: {SugarLevel}\nDues: {Dues}");
        }

    }
}
