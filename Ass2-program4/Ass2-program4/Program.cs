using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_program4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 8, 3, 5, 1, 2 };

            double average = arr.Average();
            Console.WriteLine("Average value is: " + average);

            int minValue = arr.Min();
            Console.WriteLine("Minimum value is: " + minValue);
            int maxValue = arr.Max();
            Console.WriteLine("Maximum value is: " + maxValue);
            Console.ReadLine();
        }
    }
}
