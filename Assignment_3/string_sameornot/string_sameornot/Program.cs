using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_sameornot
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter the first word: ");
            string word1 = Console.ReadLine();

            Console.Write("Enter the second word: ");
            string word2 = Console.ReadLine();

            if (word1.Equals(word2, StringComparison.OrdinalIgnoreCase))

                Console.WriteLine("The words are the same.");
            else
                Console.WriteLine("The words are not same.");

            Console.ReadLine();
        }   
    }
}
