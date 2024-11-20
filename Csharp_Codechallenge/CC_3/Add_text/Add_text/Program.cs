using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Add_text
{
    class Program
    {
        static void Main()
        {
            string filePath = "C:\\Nirmala\\Csharp_Codechallenge\\CC_3\\ Nirmala.txt";
            Console.Write("Enter text to append: ");
            string text = Console.ReadLine();

            using (StreamWriter writer = File.AppendText(filePath))
            {
                writer.WriteLine(text);
            }

            Console.WriteLine("Text appended successfully.");
            Console.WriteLine("Appended text:");
            Console.WriteLine(File.ReadAllText(filePath));

            Console.Read();
        }
    }
}
    
