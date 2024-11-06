using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_3
{
    class StringQuestions
    {
        public static string ReverseString(string s)
        {
            char[] ch = s.ToCharArray();
            Array.Reverse(ch);
            string reversed_string = string.Join("", ch);
            return reversed_string;
        }
        public static void StringEqualOrNot(string s1, string s2)
        {
            if (string.Equals(s1, s2))
            {
                Console.WriteLine("Two strings are same");
            }
            else
            {
                Console.WriteLine("Two strings are not same");
            }

        }

        static void Main(string[] args)
        {
            Console.WriteLine("-------------Program to find length of given string-------------");
            Console.WriteLine("Enter the String : ");
            string str = Console.ReadLine();
            Console.WriteLine("Length of the String : {0} ", str.Length);

            Console.WriteLine("-------------Program to print reverse of the given string-------------");
            Console.WriteLine("Reverse of the String : {0}", ReverseString(str));

            Console.WriteLine("-------------Program to check two strings are equal or not-------------");
            Console.WriteLine("Enter the first String : ");
            string str1 = Console.ReadLine();
            Console.WriteLine("Enter the second  String : ");
            string str2 = Console.ReadLine();
            StringEqualOrNot(str1, str2);
            Console.Read();
        }
    }
}
