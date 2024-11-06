using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace string_reverce
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a word: ");

            string Input = Console.ReadLine();

            char[] charArray = Input.ToCharArray();
            Array.Reverse(charArray);

            string reversedWord = new string(charArray);

            Console.WriteLine("Reversed word: " + reversedWord);

            Console.ReadLine();

        }
    }
}
