using System;
using CalculateLibrary;

namespace Assignment_6
{
    class CalculateClass
    {
        static void Main()
        { 
            Console.WriteLine("Enter Name:");
            string name = Console.ReadLine();
            Console.WriteLine("Enter Age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Class1 obj = new Class1();
            obj.CalculateConcession(name, age);
            Console.Read();

        }
    }
}
