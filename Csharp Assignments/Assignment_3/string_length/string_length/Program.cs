using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_length
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");
            
            string Input = Console.ReadLine();

            int length = Input.Length;

            Console.WriteLine("The length of the word is: " + length);
            Console.ReadLine();
        }
       
    }
}
