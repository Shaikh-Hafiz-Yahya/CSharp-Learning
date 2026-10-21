using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Object_Initializer
{
    internal class HealthCare
    {
        // Constructor / Initializer
        public HealthCare() 
        {

            PatientName = "Emily";
            PatientAge = 27;
            PatientReport = false;
            PatientRisk = 0;

        }

        // Attributes / Properties
        public string PatientName;

        public int PatientAge;

        public bool PatientReport;

        public double PatientRisk = 0.95;

        public void GetPatientInfo1()
        {

            Console.WriteLine($"\nPatient:{PatientName}\nAge:{PatientAge}\nReport:{PatientReport}\nRisk{PatientRisk}");

        }

    }
}
