using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_program3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the day number (1-7): ");
            int dayNumber = int.Parse( Console.ReadLine());

            switch (dayNumber) { 
            
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Invalid day number. Please enter a number between 1 and 7.");
                    break;
            }
            Console.ReadLine();
        }
    }
}
