using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first integer:");
            int number1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second integer:");
            int number2 = Convert.ToInt32(Console.ReadLine());

            int result = Sum(number1, number2);
            Console.WriteLine("The result is: " + result);
            Console.ReadLine();
        }

        static int Sum(int a, int b)
        {
            if(a == b)
                return 3 * (a + b);
            else
                return a + b;
           
        }
    }
}
