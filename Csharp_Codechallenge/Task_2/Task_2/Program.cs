using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_2
{
    class Program2
    {
        static void Main()
        {
            Console.WriteLine("Enter a string:");
            string input = Console.ReadLine();
            if (input.Length <= 1)
            {
                Console.WriteLine(input);
            }
            else
            {

                string result = input[input.Length - 1] + input.Substring(1, input.Length - 2) + input[0];
                Console.WriteLine("New string: " + result);
                Console.Read();
            }
        }
    }
}