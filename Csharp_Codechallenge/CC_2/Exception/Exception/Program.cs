using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exception
{
    class Program
    {
        static void CheckNumber(int number)
        {
            if (number < 0)
                throw new ArgumentException("Number cannot be negative.");
            else
                Console.WriteLine($"The number is: {number}");
        }
        static void Main()
        {
            try
            {
                Console.WriteLine("Enter the Number:");
                int number = Convert.ToInt32(Console.ReadLine());
                CheckNumber(number);
            }
            catch(ArgumentException ax)
            {
                Console.WriteLine("Error:" + ax.Message);
            }
            catch(FormatException)
            {
                Console.WriteLine("Invalid input.. Enter a valid number");
            }
            Console.ReadLine();

        }
    }
}
