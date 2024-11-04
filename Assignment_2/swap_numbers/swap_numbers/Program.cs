using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number1 = 5, number2 = 10;

            Console.WriteLine($"Before swapping: number1 = {number1}, number2 = {number2}");
            Console.ReadLine();
            (number1, number2) = (number2, number1);

            Console.WriteLine($"After swapping: number1 = {number1}, number2 = {number2}");
            Console.ReadLine();
        }
    }
}
