using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Oop
{
    internal class Program
    {
        // yahan Property/Attr main public nahi use higa.Reason: jis file main class ha is main obj bhi ha
        //string name = "John";
        //int age = 35;
        static void Main(string[] args)

        //{
        //    Program myObj = new Program(); // obj same class main exist krta ha jis class main Attr/Property ha
        //    Console.WriteLine(myObj.name);
        //}

        // Update Class Attribute --> Using Method:
        //{

        //Player tommy = new Player();
        //Console.WriteLine(tommy.health);
        //tommy.SetHealth(57);
        //Console.WriteLine(tommy.health);
        //Console.ReadLine();


        //}

        //{

        //    Player2 tommy2 = new Player2();
        //    Console.WriteLine(tommy2.name);

        //    //public access modifier = protection ki wajah sy Error aany ko kehty hain.
        //    //Console.WriteLine(tommy2.health); // Ye private Attr ha isy without method access nahi kr skty.
        //    Console.WriteLine(tommy2.GetHealth()); // Ab private Attr publicly avai ha method k through access krr skty hain.

        //}

        // Public Attr:

        //{
        //    ClassesAndObj Employee = new ClassesAndObj();   
        //    Console.WriteLine("Employee Name:" + Employee.name + " " + "Emplyee Age:" + Employee.age);
        //    Console.WriteLine(Employee.salary);
        //    Console.WriteLine(Employee.pinCode); // Easily Access.
        //}

        // Private Attr:

        //{
        //    classesAndObj2 Employee = new classesAndObj2();
        //    Console.WriteLine("Employee Name:" + Employee.name + " " + "Emplyee Age:" + Employee.age);
        //    Console.WriteLine(Employee.salary);
        //    Console.WriteLine(Employee.GetPinCode()); // pincode Easily Not Access.Method k through access.
        //}

        // Update Class Attribute --> Using Method:
        //{
        //    UpdateClassAttr obj = new UpdateClassAttr();

        //    Console.WriteLine(obj.name);

        //    obj.SetMethod("Hamid");
        //    Console.WriteLine(obj.name);

        //    Console.WriteLine(obj.age);

        //    obj.SetAge(67);
        //    Console.WriteLine(obj.age);
        //}

        //{

        //    UpdateClassAttr userObj = new UpdateClassAttr();

        //Console.WriteLine($"User Name: {userObj.userName}");
        //Console.WriteLine($"User ID: {Convert.ToInt32(userObj.userId)}");
        //Console.WriteLine($"User Salary: {Convert.ToInt32(userObj.userSalary)}");
        //Console.WriteLine($"User Password: {userObj.userPassword}");

        //Console.WriteLine($"User Id: {userObj.userId}");

        //userObj.UpdateAttr("10010");
        //Console.WriteLine($"Updated User Id: {userObj.userId}");
        //Console.WriteLine($"Updated User Id DataType: {userObj.userId.GetType()}\n");

        //Console.WriteLine($"Updated User Id Convert To Int: {Convert.ToInt32(userObj.userId)}");
        //Console.WriteLine($"Updated User Id DataType: {Convert.ToInt32(userObj.userId).GetType()}");

        //}

        //{
        // Object Program class main store ha jb K Attr/Property car class main but Attr assign obj k through.    
        //       car carObj = new car();
        //       carObj.name = "Test";
        //       Console.WriteLine(carObj.name);
        //    }

        //{
        //    UpdateClassAttr UpUpdateCarCountObject = new UpdateClassAttr();
        //    UpUpdateCarCountObject.UpdateCarCount("100");
        //    Console.WriteLine($"Updated Car count: {Convert.ToInt32(UpUpdateCarCountObject.carCountnth)}");

        //    UpdateClassAttr updateObj2  = new UpdateClassAttr();
        //    updateObj2.UpdateCarColor("Red");
        //    Console.WriteLine($"Updated Car Colors: {updateObj2.carColor3}");

        //}
    }
    //class car
    //{
    //    public string name;
    //}

}
