using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first number: ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the second number: ");
            int num2 = Convert.ToInt32(Console.ReadLine());
            Console.ReadLine();
            Console.WriteLine("1.Addition");
            Console.WriteLine("2.Subtraction");
            Console.WriteLine("3.Multiplicaion");
            Console.WriteLine("4.Division");
            Console.WriteLine("5.modulus");
                
            int op =Convert.ToInt32(Console.Read());

            switch (op)
            {
                case 1:
                    Console.WriteLine("Addition Of Two Numbers : " + (num1 + num2));
                    break;
                case 2:
                    Console.WriteLine("Subtraction Of Two Numbers : " + (num1 - num2));
                    break;
                case 3:
                    Console.WriteLine("Multiplicaion Of Two Numbers : " + (num1 * num2));
                    break;
                case 4:
                    Console.WriteLine("Division Of Two Numbers : " + (num1 / num2));
                    break;
                case 5:
                    Console.WriteLine("modulus Of Two Numbers : " + (num1 % num2));
                    break;
                


            }
    }
}
