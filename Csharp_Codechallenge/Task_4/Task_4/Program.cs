using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_4
{
    class Program4
    {
        static int CountLetterOccurrences(string str, char letter)
        {
            int count = 0;
            foreach (char c in str.ToLower())
            {
                if (c == char.ToLower(letter)) count++;
            }
            return count;
        }

        static void Main()
        {
            Console.Write("Enter a string: ");
            string str = Console.ReadLine();
            Console.Write("Enter a letter: ");
            char letter = Console.ReadLine()[0];

            Console.WriteLine($"The letter '{letter}' appears {CountLetterOccurrences(str, letter)} times.");
            Console.Read();
        }
    }
}

