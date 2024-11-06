using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_program6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] a = new int[10] { 92, 93, 95, 97, 100, 86, 93, 99, 89, 90 };
            int total = 0;
            for (int i = 0; i <= a.Length - 1; i++)
            {
                total += a[i];
            }
            Console.WriteLine(total);
            Console.ReadLine();
            int size = a.Length;
            int avg = (total / size);
            Console.WriteLine(avg);
            Console.ReadLine();
            int min = a[0];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] < min)
                    min = a[i];
            }
            Console.WriteLine(min);
            Console.Read();
            int max = a[0];
            for (int i = 0; i <= a.Length - 1; i++)
            {
                if (a[i] > max)
                    max = a[i];
            }
            Console.WriteLine(max);
            Console.Read();
            Array.Sort(a);
            Console.WriteLine("The sorted array is");
            foreach (int arr in a)
            {
                Console.WriteLine(arr);

            }
            Console.ReadLine();
            Array.Reverse(a);
            Console.WriteLine("Array in reverse order is");
            Console.ReadLine();
            foreach (int rev in a)
            {
                Console.WriteLine(rev);

            }
            Console.ReadLine();

        }
    }
}
