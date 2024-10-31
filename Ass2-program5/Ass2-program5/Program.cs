using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ass2_program5
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr1= { 1, 2, 3, 4, 5 };
            int[] arr2 = new int[arr1.Length];
            for (int i = 0; i < arr1.Length; i++)
            {
                arr2[i] = arr1[i];
            }
            Console.WriteLine("Elements of the array 2:");
            foreach (int element in arr2)
            {
                Console.Write(element + " ");
            }
            Console.ReadLine();
        }
    }
}
