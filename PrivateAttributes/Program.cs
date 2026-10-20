using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrivateAttributes
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Security CompObj = new Security();

            CompObj.CompanyName = "XYZ";
            Console.WriteLine(CompObj.CompanyName);

            CompObj.PublicDocs = "Always Read";
            Console.WriteLine(CompObj.PublicDocs);

            Console.WriteLine(CompObj.GetPrivateDocs()); // Method k through private Attr access.

            Console.WriteLine(CompObj.GetSecrates());
            Console.ReadLine(); // Console ko open rakhega

        }
    }
}
