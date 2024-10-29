using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number1 to check equal or not");
            int Number1 = Console.Read();
            Console.ReadLine();
            Console.WriteLine("Enter second number to compare");
            int Number2 = Console.Read();
            Console.ReadLine();
            if (Number1 == Number2)
                Console.WriteLine("NUmber1 And Number2 are equal");
            else
                Console.WriteLine("NUmber1 And Number2 are not equal");
            Console.ReadLine();
        }
    }
}
