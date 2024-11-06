using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the third number: ");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int largest = num1;

            if (num2 > largest)
            {
                largest = num2;
            }

            if (num3 > largest)
            {
                largest = num3;
            }

            Console.WriteLine($"The largest number among {num1}, {num2}, and {num3} is {largest}.");
            Console.ReadLine();
        }
    }
}

