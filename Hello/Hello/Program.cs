using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Hello
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // 1. Comments:
            //single line comment

            /*
             Multiline comments
             Multiline comments
             Multiline comments
             Multiline comments..
             */

            // 2. print statements:
            //Console.WriteLine("Hello World");
            //Console.WriteLine("programming");

            // 3. Variables and Datatypes:
            //int i = 0;
            //{
            //    Console.WriteLine(i);
            //}

            //string myStr = "I love C#";
            //{
            //    Console.WriteLine(myStr);
            //}

            //bool isGreat = false;
            //{
            //    Console.WriteLine(isGreat);
            //}

            //char alpha = 'A';
            //{
            //    Console.WriteLine(alpha);

            //}

            //float deci = 3.14f;
            //{
            //    Console.WriteLine(deci);
            //}

            //double highPrecision = 3.55d;
            //{
            //    Console.WriteLine(highPrecision);
            //}

            // Important:
            // float  → less precision
            // double → more precision

            //4. User Input
            //string inputUser = Console.ReadLine();
            //{
            //    Console.WriteLine(inputUser);
            //}

            // 5. Output/Print Statement:
            // There are two types.

            // 1. WriteLine() 
            //Console.WriteLine("Hello programmers");
            //Console.WriteLine("I love C#");

            // 2. Write()
            //Console.Write("Hello programmers");
            //Console.Write("I love C#");

            /*
            Important Difference:
            WriteLine() → output ke baad new line
            Write() → output ke baad new line nahi
            */

            // 6. String Concatenation:
            //int num = 101;
            //{
            //    Console.WriteLine("Programmers" + num);
            //}

            // python main string + int = Concatenation Error

            // 7. Data Types & Type Casting:
            //There are two types:

            // 1. Implicit
            // Implicit casting mein C# khud conversion karta hai jab conversion safe ho.

            //int number = 2;
            //double db = number;
            //{
            //    Console.WriteLine(db);
            //}

            //Common Implicit Conversion Chain:
            //char -> int -> long -> float -> double

            //char alpha = 'A';
            //int numeric = alpha;
            //long l = numeric;
            //float lessPrecision = l;
            //double greaterPrecision = lessPrecision;

            //{
            //    Console.WriteLine(alpha);
            //    Console.WriteLine(numeric);
            //    Console.WriteLine(l);
            //    Console.WriteLine(lessPrecision);
            //    Console.WriteLine(greaterPrecision);
            //}

            // 5. Explicit Casting
            // Explicit casting mein programmer khud conversion specify karta hai.

            //int numeric = (int) 2.3;
            //Console.WriteLine(numeric);

            //char alpha = (char) 90;
            //Console.WriteLine(alpha);

            // Char to int
            //int cr = 'Y';
            //Console.WriteLine(cr); // Return ASCII

            // int to char
            //int i = 89;
            //char c = (char) i;
            //Console.WriteLine(c);

            // 6. Type Conversion Comparison:
            //string s = "17";
            //Console.WriteLine(int.Parse(s));

            //string mystr = "hello";
            //Console.WriteLine(int.Parse(mystr)); // Error

            // Important:
            //  int.Parse("7")       → 7
            //  int.Parse("hello")   → Exception

            // 7. Check DataType

            //Console.WriteLine(23.GetType());
            //Console.WriteLine(3.1.GetType());
            //Console.WriteLine("hello".GetType());
            //Console.WriteLine('A'.GetType());
            //Console.WriteLine(true.GetType());

            // User Input + String Concatenation
            //Console.WriteLine("Input from user..");
            //string inputUser = Console.ReadLine();
            //Console.WriteLine("I love" + inputUser + "programming.." + 12);


















        }
    }
}
